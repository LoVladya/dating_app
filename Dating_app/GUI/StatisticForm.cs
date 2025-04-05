using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Dating_app.GUI
{
    public partial class StatisticForm : BaseForm
    {
        string connectionString;
        public StatisticForm(int clientID, string connectionString) : base(connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
            InterestPopularFill();
            MiddleAgeFill(clientID);

            this.Size = new Size(620, 478); // 818; 584
            this.MinimumSize = new Size(620, 478);
            this.MaximumSize = new Size(620, 478);

            if (clientTableAdapter.AdminScalarQuery(clientID) != null)
            {
                adminLabel.Visible = true;
                ratingNumericUpDown.DecimalPlaces = 1;
                ratingNumericUpDown.Value = 4.5m;
                ratingNumericUpDown.Minimum = 0.0m;
                ratingNumericUpDown.Maximum = 6.0m;
                ratingNumericUpDown.Increment = 0.1m;
            }
        }
        private void DatingAndChatsFill()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT COUNT(DISTINCT Dating_history.dating_history_id) AS Count_dating, " +
                    $"COUNT(DISTINCT Client_chat.chat_id) AS Count_chats FROM Client LEFT JOIN Dating_history " +
                    $"ON Dating_history.client_id = Client.client_id AND Dating_history.reciprocity = 1 " +
                    $"LEFT JOIN Client_chat ON Client_chat.client_id = Client.client_id;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        countDatingTextBox.Text = reader.GetInt32(reader.GetOrdinal("Count_dating")).ToString();
                        countChatsTextBox.Text = reader.GetInt32(reader.GetOrdinal("Count_chats")).ToString();
                    }
                }
            }
        }
        
        private void InterestPopularFill()
        {
            string ageMin = "байдуже";
            string ageMax = "байдуже";
            string sex = "байдуже";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT age_min AS ageMin, age_max AS ageMax, sex AS sex " +
                    $"FROM (SELECT TOP 1 age_min FROM Interest GROUP BY age_min ORDER BY COUNT(interest_id) DESC)  AS age_min " +
                    $"LEFT JOIN (SELECT TOP 1 age_max FROM Interest GROUP BY age_max ORDER BY COUNT(interest_id) DESC) AS age_max ON 1 = 1 " +
                    $"LEFT JOIN (SELECT TOP 1 sex FROM Interest GROUP BY sex ORDER BY COUNT(interest_id) DESC) AS sex ON 1 = 1;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.IsDBNull(reader.GetOrdinal("ageMin")))
                        {
                            ageMin = reader.GetByte(reader.GetOrdinal("ageMin")).ToString();
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("ageMax")))
                        {
                            ageMax = reader.GetByte(reader.GetOrdinal("ageMax")).ToString();
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("sex")))
                        {
                            sex = reader.GetString(reader.GetOrdinal("sex"));
                        }
                    }
                }
            }
            ageMinTextBox.Text = ageMin;
            ageMaxTextBox.Text = ageMax;
            sexTextBox.Text = sex;
        }
        private void MiddleAgeFill(int clientID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT TOP 1 Client.age, COUNT(Client.age) AS age_count " +
                    $"FROM Dating_history JOIN Client ON Dating_history.client_by_interest_id = Client.client_id " +
                    $"WHERE Dating_history.client_id = {clientID} AND Dating_history.reciprocity = 1 " +
                    $"GROUP BY Client.age ORDER BY age_count DESC;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            middleAgeTextBox.Text = reader.GetByte(reader.GetOrdinal("age")).ToString();
                        }
                    }
                }
            }
        }
        private void adminLabel_Click(object sender, EventArgs e)
        {
            adminLabel.Visible = false;
            userStatisticPanel.Visible = false;
            adminStatisticPanel.Visible = true;
            this.Size = new Size(620, 840);
            this.MinimumSize = new Size(620, 840);
            this.MaximumSize = new Size(620, 840);
            this.Location = new System.Drawing.Point(300, 23);
            
            DatingAndChatsFill();
            FillHighRatingClients();
        }
        
        private void FillHighRatingClients()
        {
            string query = $"SELECT client_name, sex, marital_status, rating, status_online, description_client, " +
                $"email, age, phone_number FROM Client WHERE rating >= {ratingNumericUpDown.Value.ToString().Replace(",", ".")} ORDER BY rating DESC;";
            DataGridViewProfileFill(highestRatingDataGridView, query);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            adminLabel.Visible = true;
            userStatisticPanel.Visible = true;
            adminStatisticPanel.Visible = false;
            this.Size = new Size(620, 478); // 818; 584
            this.MinimumSize = new Size(620, 478);
            this.MaximumSize = new Size(620, 478);
            //this.Location = new System.Drawing.Point(300, 23);
        }

        private void blockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nameErrorProvider.SetError(nameTextBox, null);
            if (blockedCheckBox.Checked)
            {
                nameTextBox.Enabled = false;
                dataGridView1.Enabled = false;
            }
            else
            {
                nameTextBox.Enabled = true;
                dataGridView1.Enabled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ratingNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillHighRatingClients();
        }

        private void savePDFButton_Click(object sender, EventArgs e)
        {
            if (blockedCheckBox.Checked)
            {
                string query = $"SELECT se.message_event, sc.ip_address, sc.client_id, se.date_end_event, (SELECT COUNT(*) " +
                    $"FROM Security_client WHERE ip_address = sc.ip_address AND date_event >= DATEADD(DAY, -1, GETDATE()) " +
                    $"AND failed_login = 1) AS failedLoginsCount, (SELECT COUNT(*) FROM Security_client JOIN Security_event " +
                    $"ON Security_client.security_client_id = Security_event.security_client_id WHERE client_id = sc.client_id " +
                    $"AND Security_client.date_event >= DATEADD(DAY, -1, GETDATE()) AND Security_event.message_event " +
                    $"= 'Спам повідомлення (БАН ЧАТУ на 10хв)') AS spamCount FROM Security_event se JOIN Security_client sc " +
                    $"ON se.security_client_id = sc.security_client_id WHERE se.banned = 1 AND se.date_end_event > GETDATE() " +
                    $"GROUP BY se.message_event, sc.ip_address, se.date_end_event, sc.client_id;";

                CreatePdf(query, $"Заблоковані користувачаі ВІД {DateTime.Now:HH-mm-ss dd.MM.yyyy}");
            }
            else
            {

                

                nameErrorProvider.SetError(nameTextBox, null);
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    nameErrorProvider.SetError(nameTextBox, "Оберіть рядок з користувачем!");
                    return;
                }
                int selectID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string query = $"SELECT Client.client_name, Client.sex, Client.marital_status, " +
                    $"Client.rating, Client.status_online, Client.description_client, Client.email, " +
                    $"Client.age, Client.phone_number, Interest.age_min, Interest.age_max, Interest.sex, " +
                    $"COUNT(DISTINCT Photo.photo_id) AS count_photo, COUNT(DISTINCT Client_chat.client_chat_id) " +
                    $"AS count_chats, COUNT(DISTINCT Chat_message.chat_message_id) AS count_messages FROM Client " +
                    $"JOIN Interest ON Client.client_id = Interest.client_id LEFT JOIN Photo " +
                    $"ON Client.client_id = Photo.client_id LEFT JOIN Client_chat ON Client.client_id = " +
                    $"Client_chat.client_id LEFT JOIN Chat_message ON Client_chat.client_chat_id = " +
                    $"Chat_message.client_chat_id WHERE Client.client_id = '{selectID}' GROUP BY Client.client_name, " +
                    $"Client.sex, Client.marital_status, Client.rating, Client.status_online, " +
                    $"Client.description_client, Client.email, Client.age, Client.phone_number, " +
                    $"Interest.age_min, Interest.age_max, Interest.sex;";

                CreatePdf(query, $"Користувач {nameTextBox.Text} ВІД {DateTime.Now:HH-mm-ss dd.MM.yyyy}");
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            string query = $"SELECT client_id, client_name, sex, marital_status, rating, description_client, email, age, phone_number " +
                $"FROM Client WHERE client_name = '{nameTextBox.Text}'";
            DataGridViewProfileFill(dataGridView1, query);
        }
    }
}
