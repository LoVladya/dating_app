using Dating_app.GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dating_app
{
    public partial class MainForm : BaseForm
    {
        int clientID;
        byte[] image = null;
        byte clicked = 0;
        string connectionString;
        Chats chats;
        List<Chats> listChats;
        ImageProcessor imageProcessor;
        public MainForm(int clientID, string connectionString) : base(clientID, connectionString)
        {
            this.connectionString = connectionString;
            this.clientID = clientID;
            chats = new Chats(connectionString);
            imageProcessor = new ImageProcessor(connectionString);
            InitializeComponent();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm(clientID, connectionString);
            profileForm.Show();
        }

        private void intrstLabel_Click(object sender, EventArgs e)
        {
            var interestForm = new InterestForm(clientID);
            interestForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (dating_historyTableAdapter.MessageDatingScalarQuery(clientID) != null)
            {
                var datingForm = new DatingForm(clientID, true, connectionString);
                datingForm.ShowDialog();
            }

            chatListFill();
            chatListBox.TopIndex = chatListBox.Items.Count - 1;
            chatListBox.MouseDoubleClick += ListBoxChats_MouseDoubleClick;
        }
        private void chatListFill()
        {
            string sortAtribut;
            chatListBox.Items.Clear();
            chatListBox.DrawItem += chatListBox_DrawItem;
            chatListBox.DrawMode = DrawMode.OwnerDrawFixed;

            if (clicked == 0)
            {
                sortAtribut = "favorite_status DESC";
            }
            else if(clicked == 1)
            {
                sortAtribut = "Chat.chat_name ASC";
            }
            else
            {
                sortAtribut = "date";
            }
            listChats = chats.GetChatsFromDatabase(clientID, sortAtribut);
            int maxItemWidth = 0;
            foreach (Chats chat in listChats)
            {
                string itemText = chat.ChatName;
                SizeF stringSize = chatListBox.CreateGraphics().MeasureString(itemText, chatListBox.Font);
                if (stringSize.Width > maxItemWidth)
                {
                    maxItemWidth = (int)stringSize.Width;
                }
                chatListBox.Items.Add(chat);
            }
            chatListBox.HorizontalExtent = maxItemWidth;
        }
        private void ListBoxChats_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = chatListBox.IndexFromPoint(e.Location);

            if (selectedIndex >= 0 && selectedIndex < listChats.Count)
            {
                int selectedChatID = listChats[selectedIndex].ChatID;

                
                var chatForm = new ChatForm(selectedChatID, clientID, connectionString);
                if (!chatForm.IsDisposed)
                {
                    chatForm.ShowDialog();
                }
                chatListFill();
            }
        }
        private void chatListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0 && e.Index < chatListBox.Items.Count)
            {
                Chats chat = (Chats)chatListBox.Items[e.Index];
                string itemText = chat.ChatName;

                if (chat.IsFavorite)
                {
                    Image starImage = Image.FromFile(@"..\..\images\starOn.png");

                    int newWidth = starImage.Width / 9;
                    int newHeight = starImage.Height / 9;
                    Image resizedStarImage = new Bitmap(starImage, new Size(newWidth, newHeight));

                    e.Graphics.DrawImage(resizedStarImage, e.Bounds.Left, e.Bounds.Top + (e.Bounds.Height - resizedStarImage.Height) / 2);
                }

                int itemHeight = chatListBox.ItemHeight;

                SizeF stringSize = e.Graphics.MeasureString(itemText, chatListBox.Font);

                float x = (e.Bounds.Width - stringSize.Width) / 2;
                float y = e.Bounds.Top + (itemHeight - stringSize.Height) / 2;

                e.Graphics.DrawString(itemText, chatListBox.Font, Brushes.Black, x, y);
            }

            e.DrawFocusRectangle();
        }

        private void createChatLabel_Click(object sender, EventArgs e)
        {
            datingButton.Visible = false;
            chatListBox.Visible = false;
            photoButton.Visible = false;
            createChatLabel.Visible = false;
            joinLabel.Visible = false;
            sortButton.Visible = false;

            nameChatTextBox.Visible = true;
            setImgButton.Visible = true;
            iconPictureBox.Visible = true;
            saveButton.Visible = true;
            nameChatLabel.Visible = true;
            backButton.Visible = true;

            image = File.ReadAllBytes(@"..\..\images\chat.png");
        }

        private void createChatLabel_MouseEnter(object sender, EventArgs e)
        {
            createChatLabel.ForeColor = Color.FromArgb(140, 120, 106);
        }

        private void createChatLabel_MouseLeave(object sender, EventArgs e)
        {
            createChatLabel.ForeColor = Color.Black;
        }

        private void setImgButton_Click(object sender, EventArgs e)
        {
            image = imageProcessor.GetPictureArray(iconPictureBox);
        }

        private void CreateChat()
        {
            while (true)
            {
                try
                {
                    string inviteCode = randomCode(8);
                    chatTableAdapter.InsertQuery(clientID, nameChatTextBox.Text, image, inviteCode);
                    int chatID = (int)chatTableAdapter.ChatIDScalarQuery(inviteCode);

                    client_chatTableAdapter.InsertQuery(clientID, chatID, false, 11);
                    return;
                }
                catch (SqlException ex)
                {
                    if (ex.Number != 2627)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(nameChatTextBox.Text.Length < 1)
            {
                errorProvider.SetError(nameChatTextBox, "Вкажіть ім'я чату");
                return;
            }
            if (MessageBox.Show("Створити чат?", "Новий чат", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CreateChat();
                iconPictureBox.Image = null;
                nameChatTextBox.Clear();
            }
        }

        private void MainMenuSetter()
        {
            chatListFill();

            backButton.Visible = false;
            nameChatTextBox.Visible = false;
            setImgButton.Visible = false;
            iconPictureBox.Visible = false;
            nameChatLabel.Visible = false;
            saveButton.Visible = false;
            inviteTextBox.Visible = false;
            inviteLabel.Visible = false;
            joinButton.Visible = false;

            photoButton.Visible = true;
            chatListBox.Visible = true;
            datingButton.Visible = true;
            createChatLabel.Visible = true;
            joinLabel.Visible = true;
            sortButton.Visible = true;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenuSetter();
        }

        private void profileLabel_MouseEnter(object sender, EventArgs e)
        {
            profileLabel.ForeColor = Color.FromArgb(140, 120, 106);
        }

        private void profileLabel_MouseLeave(object sender, EventArgs e)
        {
            profileLabel.ForeColor = Color.Black;
        }

        private void intrstLabel_MouseEnter(object sender, EventArgs e)
        {
            intrstLabel.ForeColor = Color.FromArgb(140, 120, 106);
        }

        private void intrstLabel_MouseLeave(object sender, EventArgs e)
        {
            intrstLabel.ForeColor = Color.Black;
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            var photoForm = new PhotoForm(clientID, connectionString);
            photoForm.ShowDialog();
        }

        private void joinLabel_MouseEnter(object sender, EventArgs e)
        {
            joinLabel.ForeColor = Color.FromArgb(140, 120, 106);
        }

        private void joinLabel_MouseLeave(object sender, EventArgs e)
        {
            joinLabel.ForeColor = Color.Black;
        }

        private void joinLabel_Click(object sender, EventArgs e)
        {
            datingButton.Visible = false;
            chatListBox.Visible = false;
            photoButton.Visible = false;
            createChatLabel.Visible = false;
            joinLabel.Visible = false;
            sortButton.Visible = false;

            backButton.Visible = true;
            inviteLabel.Visible = true;
            inviteTextBox.Visible = true;
            joinButton.Visible = true;
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(inviteTextBox, null); 
            if(inviteTextBox.Text.Length < 1)
            {
                errorProvider.SetError(inviteTextBox, "Поле пусте!");
                return;
            }
            if (MessageBox.Show("Приєднатися до чату?", "Новий чат", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int chatID = (int)chatTableAdapter.ChatIDScalarQuery(inviteTextBox.Text);
                    client_chatTableAdapter.InsertQuery(clientID, chatID, false, 11);
                    MainMenuSetter();
                }
                catch(InvalidOperationException ex)
                {
                    if (ex.Message == "Nullable object must have a value.")
                    {
                        MessageBox.Show("Код невірний!", "Помилка", MessageBoxButtons.OK);
                        errorProvider.SetError(inviteTextBox, "Код невірний!");
                    }
                    else
                    {
                        MessageBox.Show($"Помилка: {ex.Message}");
                    }
                }
            }
        }

        private void datingButton_Click(object sender, EventArgs e)
        {
            var datingForm = new DatingForm(clientID, false, connectionString);
            if(!datingForm.IsDisposed)
            {
                datingForm.ShowDialog();
            }
        }

        private void statisticLabel_Click(object sender, EventArgs e)
        {
            var statisticform = new StatisticForm(clientID, connectionString);
            statisticform.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(clicked == 0)
            {
                clicked++;
                sortButton.Text = "Назва";
            }
            else if(clicked == 1)
            {
                clicked++;
                sortButton.Text = "Старі";
            }
            else
            {
                clicked = 0;
                sortButton.Text = "Улюблені";
            }
            chatListFill();
        }
    }
}
