using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dating_app
{
    public partial class ProfileForm : BaseForm
    {
        bool clickToEye;
        int clientID;
        public ProfileForm(int clientID, string connectionString) : base(connectionString)
        {
            this.clientID = clientID;
            InitializeComponent();
            clickToEye = true;
            pswdTextBox.UseSystemPasswordChar = true;
        }
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            int s = clientID;
            var client = new Dating_app_baseDataSet.ClientDataTable();
            clientTableAdapter.FillBy(client, clientID);
            object[] row = client.Rows[0].ItemArray;
            string sex = row[2].ToString();

            if(sex == "man")
            {
                mSexRadioButton.Checked = true;
            }
            else if (sex == "woman")
            {
                wSexRadioButton.Checked = true;
            }
            else if (sex == "other")
            {
                oSexRadioButton.Checked = true;
            }

            nameTextBox.Text = row[1].ToString();
            maritalCheckBox.Checked = Convert.ToBoolean(row[3]);
            descrTextBox.Text = row[6].ToString();
            emailTextBox.Text = row[7].ToString();
            ageNumericUpDown.Value = Convert.ToInt32(row[8]);
            phoneTextBox.Text = row[9].ToString();
            pswdTextBox.Text = row[10].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isError = false;
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
            if (clientTableAdapter.EmailScalarQuery(emailTextBox.Text) == 1 && clientTableAdapter.SelectClientIDScalarQuery(emailTextBox.Text) != clientID)
            {
                emailErrorProvider.SetError(emailTextBox, "Пошта вже існує!");
                isError = true;
            }

            if (isError) { return; }


            if (MessageBox.Show("Підтвердити зміни?", "Збереження змін", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                clientTableAdapter.UpdateQuery(nameTextBox.Text,sex,
                maritalCheckBox.Checked, descrTextBox.Text, emailTextBox.Text,
                (byte)ageNumericUpDown.Value, phoneTextBox.Text, pswdTextBox.Text, clientID);
            };
        }

        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            eyePictureBoxClick(eyePictureBox, pswdTextBox, ref clickToEye);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити свій профіль?", "ВИДАЛЕННЯ ПРОФІЛЮ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (MessageBox.Show("Профіль буде НЕМОЖЛИВО відновити", "ВИДАЛЕННЯ ПРОФІЛЮ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MessageBox.Show("Нам шкода :(");
                    clientTableAdapter.DeleteQuery(clientID);
                    Application.Exit();
                }
            }
        }
    }
}
