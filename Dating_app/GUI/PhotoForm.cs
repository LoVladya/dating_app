using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dating_app
{
    public partial class PhotoForm : Form
    {
        int clientID;
        int numPhoto = 1;
        int photoID;
        object[] row;
        byte[] selectedPhoto;
        string namePhoto;
        Dating_app_baseDataSet.PhotoDataTable photo;
        ImageProcessor imageProcessor;
        Dictionary<int, PictureBox> star;
        public PhotoForm(int clientID, string connectionString)
        {
            InitializeComponent();
            this.clientID = clientID;
            photo = new Dating_app_baseDataSet.PhotoDataTable();
            imageProcessor = new ImageProcessor(connectionString);
            star = new Dictionary<int, PictureBox>()
            {
                [0] = starPictureBox1,
                [1] = starPictureBox2,
                [2] = starPictureBox3,
                [3] = starPictureBox4,
                [4] = starPictureBox5,
            };

            photoTableAdapter.FillBy(photo,
            clientID);
            PhotoLoad();

            if (photo.Rows.Count == 1)
            {
                rightLabel.ForeColor = Color.FromArgb(162, 162, 162);
                rightLabel.Enabled = false;
            }
        }
        private void PhotoLoad()
        {
            decimal rating = 0;
            selectedPhoto = null;
            
            row = photo.Rows[numPhoto - 1].ItemArray;
            photoID = Convert.ToInt32(row[0]);
            imageProcessor.RetrieveByID(pictureBox, photoID, false);
            namePhoto = row[3].ToString();
            nameTextBox.Text = row[3].ToString();
            if (row[4] != DBNull.Value) 
            {
                rating = Convert.ToDecimal(row[4]);
            }
            rating = Math.Floor(rating);
            StarFill((int)rating);

            if(photo.Rows.Count == 1)
            {
                deleteLabel.Visible = false;
            }
            else
            {
                deleteLabel.Visible = true;
            }
        }
        private void StarFill(int numStarOn)
        {
            for (int n = 0; n < 5; n++)
            {
                star[n].Image = Image.FromFile(@"..\..\images\star.png");
                if (n < numStarOn)
                {
                    star[n].Image = Image.FromFile(@"..\..\images\starOn.png");
                }
            }
        }
        private void ScrollPhoto(int n, int notActive, int active, Label activeLabel, Label notActiveLabel)
        {
            if (namePhoto != nameTextBox.Text || selectedPhoto != null)
            {
                if (MessageBox.Show("Зберегти зміни?", "Зміни фото", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(selectedPhoto == null)
                    {
                        photoTableAdapter.UpdatePhotoNameQuery(nameTextBox.Text, photoID);
                    }
                    else 
                    {
                        photoTableAdapter.UpdateQuery(selectedPhoto, nameTextBox.Text, photoID);
                    }
                    photoTableAdapter.FillBy(photo, clientID);
                }
            }            

            numPhoto += n;
            if (numPhoto == notActive)
            {
                notActiveLabel.ForeColor = Color.FromArgb(162, 162, 162);
                notActiveLabel.Enabled = false;
            }
            if (numPhoto == active)
            {
                activeLabel.ForeColor = Color.Black;
                activeLabel.Enabled = true;
            }
            PhotoLoad();
        }
        private void leftLabel_Click(object sender, EventArgs e)
        {
            ScrollPhoto(-1, 1, photo.Rows.Count - 1, rightLabel, leftLabel);
        }

        private void rightLabel_Click(object sender, EventArgs e)
        {
            ScrollPhoto(1, photo.Rows.Count, 2, leftLabel, rightLabel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(namePhoto != nameTextBox.Text || selectedPhoto != null)
            {

                if (MessageBox.Show("Зберегти зміни?", "Зміни фото", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (selectedPhoto == null)
                    {
                        photoTableAdapter.UpdatePhotoNameQuery(nameTextBox.Text, photoID);
                    }
                    else
                    {
                        photoTableAdapter.UpdateQuery(selectedPhoto, nameTextBox.Text, photoID);
                    }
                }
            }
            Close();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            selectedPhoto = imageProcessor.GetPictureArray(pictureBox);
        }

        private void createChatLabel_Click(object sender, EventArgs e)
        {
            createPhotoLabel.Visible = false;
            leftLabel.Visible = false;
            rightLabel.Visible = false;
            exitButton.Visible = false;
            deleteLabel.Visible = false;

            createExitButton.Visible = true;
            saveButton.Visible = true;
            pictureBox.Image = null;
            nameTextBox.Text = null;
            for (int n = 0; n < 5; n++)
            {
                star[n].Visible = false;
            }
        }

        private void createChatLabel_MouseEnter(object sender, EventArgs e)
        {
            createPhotoLabel.ForeColor = Color.FromArgb(140, 120, 106);
        }

        private void createChatLabel_MouseLeave(object sender, EventArgs e)
        {
            createPhotoLabel.ForeColor = Color.Black;
        }

        private void createExitButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && MessageBox.Show("Вийти? Зміни не будуть збережені!", "Створення фото", MessageBoxButtons.YesNo)
                    == DialogResult.No)
            {
                return;
            }
            createPhotoLabel.Visible = true;
            leftLabel.Visible = true;
            rightLabel.Visible = true;
            exitButton.Visible = true;
            deleteLabel.Visible = true;
            for (int n = 0; n < 5; n++)
            {
                star[n].Visible = true;
            }

            createExitButton.Visible = false;
            saveButton.Visible = false;

            PhotoLoad();

            if (photo.Rows.Count > 1)
            {
                rightLabel.ForeColor = Color.Black;
                rightLabel.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                if (MessageBox.Show("Створити фото?", "Створення фото", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    photoTableAdapter.InsertQuery(clientID, selectedPhoto, null, nameTextBox.Text);
                    pictureBox.Image = null;
                    nameTextBox.Clear();
                    photoTableAdapter.FillBy(photo, clientID);
                }
            }
        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити фото?", "Зміни фото", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (numPhoto == photo.Rows.Count)
                {
                    numPhoto--;
                }
                if(photo.Rows.Count == 2) 
                {
                    rightLabel.ForeColor = Color.FromArgb(162, 162, 162);
                    rightLabel.Enabled = false;
                    leftLabel.ForeColor = Color.FromArgb(162, 162, 162);
                    leftLabel.Enabled = false;
                }
                if(numPhoto + 1 == photo.Rows.Count)
                {
                    rightLabel.ForeColor = Color.FromArgb(162, 162, 162);
                    rightLabel.Enabled = false;
                }
                photoTableAdapter.DeleteQuery(photoID);
                photoTableAdapter.FillBy(photo, clientID);
                PhotoLoad();
            }
        }
    }
}
