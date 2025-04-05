using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Dating_app
{
    public partial class DatingForm : BaseForm
    {
        int clientID;
        int suitableClientID;
        int numClient = 0;
        int numPhoto = 1;
        decimal ratingClient = 0;
        bool photoIsOpen = false;
        bool isRequest;

        DataRow rowClient;
        DataRow rowPhoto;
        Dating_app_baseDataSet.InterestDataTable suitableClientDT = new Dating_app_baseDataSet.InterestDataTable();
        Dating_app_baseDataSet.PhotoDataTable photoDT = new Dating_app_baseDataSet.PhotoDataTable();
        ImageProcessor imageProcessor;
        List<PhotoRating> ratingList = new List<PhotoRating>();
        public DatingForm(int clientID, bool isRequest, string connectionString) : base(connectionString)
        {
            InitializeComponent();
            this.clientID = clientID;
            this.isRequest = isRequest;
            imageProcessor = new ImageProcessor(connectionString);
            if (isRequest)
            {
                interestTableAdapter.ClientRequestsFillBy(suitableClientDT, clientID);
            }
            else
            {
                interestTableAdapter.ClientOfInterestsFillBy(suitableClientDT, clientID);
            }
            clientFill();
        }

        private void clientFill()
        {
            if (numClient < suitableClientDT.Rows.Count)
            {
                string sex = "";
                
                ratingList.Clear();
                rowClient = suitableClientDT.Rows[numClient];
                if (rowClient["sex"].ToString() == "man")
                {
                    sex = ", хлопець";
                }
                else if (rowClient["sex"].ToString() == "woman")
                {
                    sex = ", дівчина";
                }
                suitableClientID = Convert.ToInt32(rowClient["client_id"]);
                infoLabel.Text = $"{rowClient["client_name"]}, {rowClient["age"]} років{sex}. {rowClient["description_client"]}";

                photoTableAdapter.FillBy(photoDT, suitableClientID);
                PhotoLoad();

                numClient++;
                
                if (rowClient["rating"] != DBNull.Value)
                {
                    ratingClient = Convert.ToDecimal(rowClient["rating"]);
                }

                if (photoDT.Rows.Count == 1)
                {
                    rightLabel.ForeColor = Color.FromArgb(162, 162, 162);
                    rightLabel.Enabled = false;
                }
                ratingClient = Math.Round(ratingClient);
                StarFill((int)ratingClient);
            }
            else
            {
                MessageBox.Show("Нема більше((");
                Close();
            }
        }
        
        private void SaveSolution(bool succesDating)
        {
            foreach (var photoRating in ratingList)
            {
                photoRating.rating = Math.Round(photoRating.rating, 2);
                try
                {
                    photoTableAdapter.RatingUpdateQuery(Convert.ToDecimal(photoRating.rating), photoRating.photoId);
                    clientTableAdapter.RatingUpdateQuery(Convert.ToDecimal(0.1), (int)rowClient["client_id"]);
                }
                catch { }
            }
            if (isRequest)
            {
                dating_historyTableAdapter.RequestUpdateQuery(succesDating, (int)rowClient["client_id"], clientID);
                if(succesDating)
                {
                    CreateChat();
                    try
                    {
                        clientTableAdapter.RatingUpdateQuery(Convert.ToDecimal(0.3), clientID);
                    }
                    catch { }
                }
            }
            else
            {
                dating_historyTableAdapter.InsertQuery(clientID, (int)rowClient["client_id"], succesDating);
            }
            
            clientFill();
        }

        private void CreateChat()
        {
            while (true)
            {
                try
                {
                    byte[] imageData = File.ReadAllBytes(@"..\..\images\chat.png");
                    string inviteCode = randomCode(8);
                    
                    chatTableAdapter.InsertQuery(clientID, (string)rowClient["client_name"], imageData, inviteCode);
                    int chatID = (int)chatTableAdapter.ChatIDScalarQuery(inviteCode);

                    client_chatTableAdapter.InsertQuery(clientID, chatID, false, 11);
                    client_chatTableAdapter.InsertQuery((int)rowClient["client_id"], chatID, false, 11);
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
        private void confirmButton_Click(object sender, EventArgs e)
        {
            SaveSolution(true);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SaveSolution(false);
        }

        private void PhotoLoad()
        {
            rowPhoto = photoDT.Rows[numPhoto - 1];
            imageProcessor.RetrieveByID(photoPictureBox, Convert.ToInt32(rowPhoto["photo_id"]), false);
            namePhotoLabel.Text = rowPhoto["photo_name"].ToString();

            PhotoRating foundItem = ratingList.FirstOrDefault(r => r.photoId == Convert.ToInt32(rowPhoto["photo_id"]));
            if (foundItem != null)
            {
                if(rowPhoto["rating"] == DBNull.Value)
                {
                    StarFill((int)foundItem.rating);
                }
                else
                {
                    double ratingCoeff = 7;
                    double numStars = (foundItem.rating - Convert.ToDouble(rowPhoto["rating"])) * ratingCoeff + Convert.ToDouble(rowPhoto["rating"]);
                    numStars = Math.Round(numStars);
                    StarFill((int)numStars);
                }
            }
        }

        private void StarFill(int numStarOn)
        {
            Dictionary<int, PictureBox> star = new Dictionary<int, PictureBox>()
            {
                [0] = starPictureBox1,
                [1] = starPictureBox2,
                [2] = starPictureBox3,
                [3] = starPictureBox4,
                [4] = starPictureBox5,
            };

            for (int n = 0; n < 5; n++)
            {
                star[n].Image = Image.FromFile(@"..\..\images\star.png");
                if (n < numStarOn)
                {
                    star[n].Image = Image.FromFile(@"..\..\images\starOn.png");
                }
                if (photoIsOpen && star[n].Enabled != true)
                {
                    star[n].Enabled = true;
                }
                else if(!photoIsOpen)
                {
                    star[n].Enabled = false;
                }
            }
        }

        private void ScrollPhoto(int n, int notActive, int active, Label notActiveLabel, Label activeLabel)
        {
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
            StarFill(0);
            PhotoLoad();
        }

        private void leftLabel_Click(object sender, EventArgs e)
        {
            ScrollPhoto(-1, 1, photoDT.Rows.Count - 1, leftLabel, rightLabel);
        }

        private void rightLabel_Click(object sender, EventArgs e)
        {
            ScrollPhoto(1, photoDT.Rows.Count, 2, rightLabel, leftLabel);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            rightLabel.Visible = false;
            leftLabel.Visible = false;
            returnButton.Visible = false;
            namePhotoLabel.Visible = false;
            photoIsOpen = false;

            infoLabel.Visible = true;
            confirmButton.Visible = true;
            cancelButton.Visible = true;

            panel1.BackColor = Color.FromArgb(202, 255, 196);
            this.BackColor = Color.Bisque;

            int n = 1;
            if(photoDT.Rows.Count == 1)
            {
                n = 0;
            }
            ScrollPhoto(-numPhoto + 1, 1, n, leftLabel, rightLabel);
            StarFill((int)ratingClient);
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            if (!photoIsOpen)
            {
                infoLabel.Visible = false;
                confirmButton.Visible = false;
                cancelButton.Visible = false;

                rightLabel.Visible = true;
                leftLabel.Visible = true;
                returnButton.Visible = true;
                namePhotoLabel.Visible = true;
                photoIsOpen = true;

                panel1.BackColor = Color.FromArgb(163, 200, 152);
                this.BackColor = Color.FromArgb(191, 170, 146);
                StarFill(0);
                PhotoLoad();
            }
        }
        void PhotoRatingListFill(double rating)
        {
            StarFill((int)rating);
            int photoID = Convert.ToInt32(rowPhoto["photo_id"]);
            if (rowPhoto["rating"] != DBNull.Value)
            {
                int ratingCoeff = 7;
                rating = (rating - Convert.ToDouble(rowPhoto["rating"])) / ratingCoeff + Convert.ToDouble(rowPhoto["rating"]);
            }
            
            if (ratingList.Exists(photoRating => photoRating.photoId == photoID))
            {
                var photoRatingToUpdate = ratingList.Find(photoRating => photoRating.photoId == photoID);
                photoRatingToUpdate.rating = rating;
            }
            else
            {
                ratingList.Add(new PhotoRating(photoID, rating));
            }
        }

        private void starPictureBox1_Click(object sender, EventArgs e)
        {
            PhotoRatingListFill(1);
        }

        private void starPictureBox2_Click(object sender, EventArgs e)
        {
            PhotoRatingListFill(2);
        }

        private void starPictureBox3_Click(object sender, EventArgs e)
        {
            PhotoRatingListFill(3);
        }

        private void starPictureBox4_Click(object sender, EventArgs e)
        {
            PhotoRatingListFill(4);
        }

        private void starPictureBox5_Click(object sender, EventArgs e)
        {
            PhotoRatingListFill(5);
        }
    }
    public class PhotoRating
    {
        public int photoId;
        public double rating;

        public PhotoRating(int photoId, double rating)
        {
            this.photoId = photoId;
            this.rating = rating;
        }
    }
}
