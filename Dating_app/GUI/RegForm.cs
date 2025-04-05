using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Dating_app
{
    public partial class RegForm : BaseForm
    {
        bool eyeIsPressed;
        string connectionString;
        public RegForm(string connectionString) : base(connectionString)
        {
            this.connectionString = connectionString;
            eyeIsPressed = true;
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dating_app_baseDataSet);

        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.dating_app_baseDataSet.Client);
            pswdTextBox.UseSystemPasswordChar = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            bool isError = false;
            errorProvider1.SetError(emailTextBox, null);

            Dictionary<int, TextBox> textBox = new Dictionary<int, TextBox>()
            {
                [0] = nameTextBox,
                [1] = emailTextBox,
                [2] = phoneTextBox,
                [3] = pswdTextBox
            };
            Dictionary<int, ErrorProvider> errorProvider = new Dictionary<int, ErrorProvider>()
            {
                [0] = nameErrorProvider,
                [1] = emailErrorProvider,
                [2] = phoneErrorProvider,
                [3] = pswdErrorProvider,
            };

            for (int i = 0; i < errorProvider.Count; i++)
            {
                errorProvider[i].SetError(textBox[i], null);
                if (textBox[i].Text == "")
                {
                    isError = true;
                    errorProvider[i].SetError(textBox[i], "Поле пусте!");
                }
            }

            if (!IsValidEmail(emailTextBox.Text))
            {
                emailErrorProvider.SetError(emailTextBox, "Пошта невірного формата!");
                isError = true;
            }
            if (!IsValidPhone(phoneTextBox.Text))
            {
                phoneErrorProvider.SetError(phoneTextBox, "Телефон невірний!");
                isError = true;
            }
            if (!IsValidPassword(pswdTextBox.Text))
            {
                pswdErrorProvider.SetError(pswdTextBox, "Пароль невірного формата!");
                isError = true;
            }

            if (clientTableAdapter.EmailScalarQuery(emailTextBox.Text) == 1)
            {
                errorProvider1.SetError(emailTextBox, "Пошта вже існує!");
                isError = true;
            }

            if (isError) { return; }

            if (MessageBox.Show("Створити акаунт?", "Реєстрація", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sex;

                if (mSexRadioButton.Checked == true)
                {
                    sex = "man";
                }
                else if (wSexRadioButton.Checked == true)
                {
                    sex = "woman";
                }
                else
                {
                    sex = "other";
                }

                clientTableAdapter.InsertQuery(nameTextBox.Text, sex,
                maritalCheckBox.Checked, 0, false, descrTextBox.Text, emailTextBox.Text,
                (byte)ageNumericUpDown.Value, phoneTextBox.Text, pswdTextBox.Text);

                int clientID;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT client_id from Client where email = '{emailTextBox.Text}';";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            clientID = reader.GetInt32(reader.GetOrdinal("client_id"));
                        }
                    }
                }
                interestTableAdapter.InsertQuery(clientID, null, null, null);
                photoTableAdapter.InsertQuery(clientID, File.ReadAllBytes($@"..\..\images\{sex}.png"), null, null);

                Close();
            }
        }

        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            eyePictureBoxClick(eyePictureBox, pswdTextBox, ref eyeIsPressed);
        }
    }
}
