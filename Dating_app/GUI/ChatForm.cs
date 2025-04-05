using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Dating_app
{
    public partial class ChatForm : BaseForm
    {
        int chatID;
        int clientID;
        int clientChatID;
        int fatness;
        int fastMessageCount = 0;
        byte[] image;
        bool stngIsClicked = false;
        bool favoriteIsClicked;
        bool isAuthor;
        long lastMilliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;


        private Timer updateTimer;
        private ImageProcessor imageProcessor; 

        public ChatForm(int chatID, int clientID, string connectionString) : base(connectionString)
        {
            InitializeComponent();
            this.chatID = chatID;
            this.clientID = clientID;
            var clientChatDT = new Dating_app_baseDataSet.Client_chatDataTable();
            var chatDT = new Dating_app_baseDataSet.ChatDataTable();
            imageProcessor = new ImageProcessor(connectionString);
            updateTimer = new Timer();

            client_chatTableAdapter.FillBy(clientChatDT, clientID, chatID);
            chatTableAdapter.FillBy(chatDT, chatID);
            DataRow rowClientChat = clientChatDT.Rows[0];
            DataRow rowChat = chatDT.Rows[0];
            clientChatID = Convert.ToInt32(rowClientChat["client_chat_id"]);
            favoriteIsClicked = (bool)rowClientChat["favorite_status"];
            fatness = Convert.ToInt32(rowClientChat["text_fatness"]);
            
            fatnessNumericUpDown.Value = fatness;
            if ((int)rowChat["client_author_id"] == clientID)
            {
                isAuthor = true;
                codeLabel.Text = rowChat["invitation_code"].ToString();
                nameTextBox.Text = (string)rowChat["chat_name"];
                image = imageProcessor.RetrieveByID(setIconPictureBox, chatID, true);
            }
            
            imageProcessor.RetrieveByID(iconPictureBox, chatID, true);
            fatnessNumericUpDown.Value = fatness;

            if (favoriteIsClicked)
            {
                starPictureBox.Image = Image.FromFile(@"..\..\images\starOn.png");
            }

            updateTimer.Interval = 20;
            updateTimer.Tick += UpdateChat;
            updateTimer.Start();
            CheckForBan();
        }
        private void CheckForBan()
        {
            int minutesOfBan = Convert.ToInt32(security_eventTableAdapter.IsBannedChatScalarQuery(clientID));
            if (minutesOfBan > 0)
            {
                MessageBox.Show($"Ви заблоковані! Хвилин до розбану: {minutesOfBan}");
                updateTimer.Stop();
                Close();
            }
        }
        private void UpdateChat(object sender, EventArgs e)
        {
            int countMsgFromDB = Convert.ToInt32(chat_messageTableAdapter.CountMsgScalarQuery(chatID));
            if (countMsgFromDB > msgRichTextBox.TextLength)
            {
                GetChatMessages();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (stngIsClicked)
            {
                if (isAuthor)
                {
                    nameLabel.Visible = false;
                    nameTextBox.Visible = false;
                    setImgButton.Visible = false;
                    setIconPictureBox.Visible = false;
                    codeNameLabel.Visible = false;
                    codeLabel.Visible = false;
                }
                msgTextBox.Visible = true;
                msgRichTextBox.Visible = true;
                sendPictureBox.Visible = true;
                colorLabel.Visible = true;

                starPictureBox.Visible = false;
                saveButton.Visible = false;
                stngIsClicked = false;
                deleteLabel.Visible = false;
                fatnessLabel.Visible = false;
                favoriteLabel.Visible = false;
                fatnessNumericUpDown.Visible = false;
            }
            else
            {
                if (isAuthor)
                {
                    nameLabel.Visible = true;
                    nameTextBox.Visible = true;
                    setImgButton.Visible = true;
                    setIconPictureBox.Visible = true;
                    codeNameLabel.Visible = true;
                    codeLabel.Visible = true;
                }
                msgTextBox.Visible = false;
                sendPictureBox.Visible = false;
                msgRichTextBox.Visible = false;
                colorLabel.Visible = false;

                starPictureBox.Visible = true;
                saveButton.Visible = true;
                stngIsClicked = true;
                deleteLabel.Visible = true;
                fatnessLabel.Visible = true;
                favoriteLabel.Visible= true;
                fatnessNumericUpDown.Visible = true;
            }
        }

        private void sendPictureBox_Click(object sender, EventArgs e)
        {
            if (msgTextBox.Text.Length > 0)
            {
                ProcessingInsertMsg();
            }
        }

        public void GetChatMessages()
        {
            msgRichTextBox.Clear();

            var messageDT = new Dating_app_baseDataSet.Chat_messageDataTable();
            chat_messageTableAdapter.FillBy(messageDT, chatID);

            foreach (DataRow row in messageDT.Rows)
            {
                string messageInfo = $"[{row["message_date"]}]  {row["client_name"]}: ";
                Color color = ColorTranslator.FromHtml((string)row["text_color"]);

                AppendColoredText(messageInfo, Color.Black);
                AppendColoredText((string)row["text_message"], color);
                msgRichTextBox.AppendText(Environment.NewLine);
            }
            msgRichTextBox.ScrollToCaret();
        }
        private void AppendColoredText(string text, Color color)
        {
            msgRichTextBox.SelectionStart = msgRichTextBox.TextLength;
            msgRichTextBox.SelectionLength = 0;

            msgRichTextBox.SelectionColor = color;
            msgRichTextBox.SelectionFont = new Font(msgRichTextBox.Font.FontFamily, fatness);
            msgRichTextBox.AppendText(text);
            msgRichTextBox.SelectionColor = msgRichTextBox.ForeColor;
        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з чату?", "ВИДАЛЕННЯ ЧАТУ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                client_chatTableAdapter.DeleteQuery(clientChatID);
                Close();
            }
        }

        private void ProcessingInsertMsg()
        {
            long currentMilliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long delay = (currentMilliseconds - lastMilliseconds);
            string colorRGB = $"#{colorDialog.Color.R:X2}{colorDialog.Color.G:X2}{colorDialog.Color.B:X2}";

            chat_messageTableAdapter.InsertQuery(clientChatID, colorRGB, msgTextBox.Text);
            msgTextBox.Clear();
            GetChatMessages();

            if (delay < 200)
            {
                fastMessageCount++;
                MessageBox.Show("Не так швидко!", "Попередження", MessageBoxButtons.OK);
                if (fastMessageCount == 8)
                {
                    string query = $"INSERT INTO [Security_client] ([client_id], [date_event], [failed_login], [ip_address]) " +
                    $"VALUES ({clientID}, GETDATE(), 0, '{ipAddress}'); INSERT INTO [dbo].[Security_event] ([security_client_id], [banned], " +
                    $"[warnings], [message_event], [date_end_event]) VALUES (SCOPE_IDENTITY(), 0, 1, 'Спам повідомлення (ПОПЕРЕДЖЕННЯ ЧАТУ)', " +
                    $"DATEADD(MINUTE, 5, GETDATE()));";

                    InsertQuery(query);
                    MessageBox.Show("Ви будете відключені від листування на 10 хвилин якщо продовжете спам!", "Попередження", MessageBoxButtons.OK);
                    return;
                }

                if (Convert.ToInt32(security_eventTableAdapter.IsWarningChatScalarQuery(clientID)) > 0)
                {
                    string query = $"INSERT INTO [Security_client] ([client_id], [date_event], [failed_login], [ip_address]) " +
                    $"VALUES ({clientID}, GETDATE(), 0, '{ipAddress}'); INSERT INTO [dbo].[Security_event] ([security_client_id], [banned], " +
                    $"[warnings], [message_event], [date_end_event]) VALUES (SCOPE_IDENTITY(), 1, 0, 'Спам повідомлення (БАН ЧАТУ на 10хв)', " +
                    $"DATEADD(MINUTE, 10, GETDATE()));";

                    InsertQuery(query);
                    try
                    {
                        clientTableAdapter.RatingUpdateQuery(Convert.ToDecimal(-0.1), clientID);
                    }
                    catch { }
                    MessageBox.Show("Ви відключені від листування на 10 хвилин!", "Бан", MessageBoxButtons.OK);
                    Close();
                }
            }
            lastMilliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }
        private void ChatForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && msgTextBox.Text.Length > 0)
            {
                ProcessingInsertMsg();
            }
        }
        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void setImgButton_Click(object sender, EventArgs e)
        {
            image = imageProcessor.GetPictureArray(setIconPictureBox);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(nameLabel, null);

            if (nameTextBox.Text.Length < 1)
            {
                errorProvider.SetError(nameLabel, "Поле не може бути пустим!");
                return;
            }
            if (MessageBox.Show("Підтвердити зміни?", "Збереження змін", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if(isAuthor)
                {
                    chatTableAdapter.UpdateQuery(nameTextBox.Text, image, chatID);
                }
                client_chatTableAdapter.UpdateQuery(favoriteIsClicked, (byte)fatnessNumericUpDown.Value, clientChatID);
                imageProcessor.RetrieveByID(iconPictureBox, chatID, true);
                fatness = Convert.ToInt32(fatnessNumericUpDown.Value);
                GetChatMessages();
            }
        }

        private void starPictureBox_Click(object sender, EventArgs e)
        {
            if(favoriteIsClicked)
            {
                starPictureBox.Image = Image.FromFile(@"..\..\images\star.png");
                favoriteIsClicked = false;
            }
            else
            {
                starPictureBox.Image = Image.FromFile(@"..\..\images\starOn.png");
                favoriteIsClicked = true;
            }
        }

        private void colorLabel_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorLabel.ForeColor = colorDialog.Color;
            msgTextBox.ForeColor = colorDialog.Color;
        }
    }
}
