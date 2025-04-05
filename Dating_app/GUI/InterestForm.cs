using System;
using System.Windows.Forms;

namespace Dating_app
{
    public partial class InterestForm : Form
    {
        int clientID;
        public InterestForm(int clientID)
        {
            this.clientID = clientID;   
            InitializeComponent();
        }

        private void InterestForm_Load(object sender, EventArgs e)
        {
            var interest = new Dating_app_baseDataSet.InterestDataTable();
            interestTableAdapter.FillBy(interest, clientID);
            object[] row = interest.Rows[0].ItemArray;
            string sex = row[1].ToString();

            if (sex == "man")
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
            else
            {
                sexСheckBox.Checked = true;
            }

            if (row[2] != DBNull.Value)
            {
                minAgeCheckBox.Checked = false;
                ageMinNumericUpDown.Value = Convert.ToInt32(row[2]);
            }
            if (row[3] != DBNull.Value)
            {
                maxAgeCheckBox.Checked = false;
                ageMaxNumericUpDown.Value = Convert.ToInt32(row[3]);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ageErrorProvider.SetError(ageMinNumericUpDown, null);
            if (ageMinNumericUpDown.Value > ageMaxNumericUpDown.Value && !(minAgeCheckBox.Checked && maxAgeCheckBox.Checked))
            {
                ageErrorProvider.SetError(ageMinNumericUpDown, "Мінімальний вік не може бути більше максимального!");
                return;
            }   
            if (MessageBox.Show("Підтвердити зміни?", "Збереження змін", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                byte? ageMin = null;
                byte? ageMax = null;
                string sex = null;
                if (!sexСheckBox.Checked)
                {
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
                }
                if (!minAgeCheckBox.Checked)
                {
                    ageMin = (byte)ageMinNumericUpDown.Value;
                }
                if (!maxAgeCheckBox.Checked)
                {
                    ageMax = (byte)ageMaxNumericUpDown.Value;
                }

                interestTableAdapter.UpdateQuery(sex, ageMin, ageMax, clientID);
            };
        }

        private void ageMinNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (ageMinNumericUpDown.Text == "")
            {
                ageMinNumericUpDown.Text = ageMinNumericUpDown.Minimum.ToString();
            }
        }

        private void ageMaxNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (ageMaxNumericUpDown.Text == "")
            {
                ageMaxNumericUpDown.Text = ageMaxNumericUpDown.Minimum.ToString();
            }
        }

        private void minAgeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (minAgeCheckBox.Checked)
            {
                ageMinNumericUpDown.Enabled = false;
            }
            else
            {
                ageMinNumericUpDown.Enabled = true;
            }
        }

        private void maxAgeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (maxAgeCheckBox.Checked)
            {
                ageMaxNumericUpDown.Enabled = false;
            }
            else
            {
                ageMaxNumericUpDown.Enabled = true;
            }
        }

        private void sexСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sexСheckBox.Checked)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled= true;
            }
        }
    }
}
