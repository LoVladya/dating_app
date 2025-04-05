using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dating_app
{
    public partial class MainFormLogin : BaseForm
    {
        bool eyeIsPressed;
        int countFailedLogin;
        string connectionString;
        public MainFormLogin(string connectionString) : base(connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            countFailedLogin = Convert.ToInt32(security_clientTableAdapter.FailedLoginsScalarQuery(ipAddress));
            eyeIsPressed = true;
            pswdTextBox.UseSystemPasswordChar = true;
            CheckForBan();
        }
        private void CheckForBan()
        {
            int minutesOfBan = Convert.ToInt32(security_eventTableAdapter.IsBannedFlLginScalarQuery(ipAddress));
            if (minutesOfBan > 0)
            {
                MessageBox.Show($"Ви заблоковані! Хвилин до розбану: {minutesOfBan}");
                Close();
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool isError = false;
            errorProvider1.SetError(emailTextBox, null);
            errorProvider1.SetError(pswdTextBox, null);
            if (!IsValidEmail(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "Пошта невірного формата!");
                isError = true;
            }
            if (!IsValidPassword(pswdTextBox.Text))
            {
                errorProvider1.SetError(pswdTextBox, "Пароль невірного формата!");
                isError = true;
            }
            if (isError) { return; }

            if (Convert.ToInt32(clientTableAdapter.CheckLoginScalarQuery(emailTextBox.Text, pswdTextBox.Text)) == 1)
            {
                int clientID = Convert.ToInt32(clientTableAdapter.SelectClientIDScalarQuery(emailTextBox.Text));
                var mainForm = new MainForm(clientID, connectionString);

                mainForm.ShowDialog();
            }
            else
            {
                countFailedLogin++;
                if (countFailedLogin < 5 || countFailedLogin == 7 || countFailedLogin == 10)
                {
                    security_clientTableAdapter.FailLoginInsertQuery(ipAddress, emailTextBox.Text);
                    countFailedLogin = Convert.ToInt32(security_clientTableAdapter.FailedLoginsScalarQuery(ipAddress));
                }
                MessageBox.Show("Неправильна пошта або пароль!", "Помилка", MessageBoxButtons.OK);
                int timeBanned = 1;
                int countFailToBanned = 7;

                if (countFailedLogin > 7)
                {
                    timeBanned = 24;
                    countFailToBanned = 10;
                }
                if (countFailedLogin > 4 && countFailedLogin != 7 && countFailedLogin != 10)
                {
                    string warning = $"Занадто багато невдалих спроб! Ваш акаунт буде заблокований на {timeBanned} годину через {countFailToBanned - countFailedLogin} спроб.";
                    MessageBox.Show(warning, "Попередження", MessageBoxButtons.OK);
                    string query = $"INSERT INTO [Security_client] ([client_id], [date_event], [failed_login], [ip_address]) " +
                            $"SELECT client_id, GETDATE(), 1, '{ipAddress}' FROM Client WHERE email = '{emailTextBox.Text}';" +
                            $"INSERT INTO [dbo].[Security_event] ([security_client_id], [banned], " +
                            $"[warnings], [message_event], [date_end_event]) VALUES (SCOPE_IDENTITY(), 0, 1, 'Невдалі спроби (ПОПЕРЕДЖЕННЯ)', DATEADD(HOUR, 1, GETDATE()));";

                    InsertQuery(query);
                }
                CheckForBan();
            }
        }

        private void regLabel_Click(object sender, EventArgs e)
        {
            var reg = new RegForm(connectionString);
            reg.ShowDialog();
        }

        private void regLabel_MouseEnter(object sender, EventArgs e)
        {
            regLabel.ForeColor = Color.FromArgb(140, 120, 106);
        }

        private void regLabel_MouseLeave(object sender, EventArgs e)
        {
            regLabel.ForeColor = Color.Black;
        }

        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            if (eyeIsPressed)
            {
                eyePictureBox.Image = Image.FromFile(@"..\..\images\eye2.png");
                pswdTextBox.UseSystemPasswordChar = false;
                eyeIsPressed = false;
            }
            else
            {
                eyePictureBox.Image = Image.FromFile(@"..\..\images\eye1.png");
                pswdTextBox.UseSystemPasswordChar = true;
                eyeIsPressed = true;
            }
        }
    }
}
