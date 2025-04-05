using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Dating_app
{
    internal class ImageProcessor
    {
        string connectionString;
        public ImageProcessor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public byte[] GetPictureArray(PictureBox pictureBox)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    return File.ReadAllBytes(openFileDialog.FileName);
                }
                return null;
            }
        }
        public byte[] RetrieveByID(PictureBox pictureBox, int ID, bool isChat)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                if (isChat)
                {
                    command.CommandText = "SELECT icon FROM Chat WHERE chat_id = @chat_id";
                    command.Parameters.AddWithValue("@chat_id", ID);
                }
                else
                {
                    command.CommandText = "SELECT photo FROM Photo WHERE photo_id = @photo_id";
                    command.Parameters.AddWithValue("@photo_id", ID);
                }
                
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] imageData;
                        if (isChat)
                        {
                            imageData = (byte[])reader["icon"];
                        }
                        else
                        {
                            imageData = (byte[])reader["photo"];
                        }

                        using (var memoryStream = new MemoryStream(imageData))
                        {
                            pictureBox.Image = Image.FromStream(memoryStream);
                            return imageData;
                        }
                    }
                    return null;
                }
            }
        }
    }
}
