using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Dating_app.Dating_app_baseDataSetTableAdapters;
using System.Net;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font;

namespace Dating_app
{
    public class BaseForm : Form
    {
        private Security_eventTableAdapter security_eventTableAdapter;
        private int? clientID = null;
        public string ipAddress = "-";
        string connectionString;

        public BaseForm() 
        {
            this.FormClosed += BaseForm_FormClosed;
            this.Load += BaseForm_Load;
        }
        public BaseForm(string connectionString)
        {
            this.connectionString = connectionString;
            this.FormClosed += BaseForm_FormClosed;
            this.Load += BaseForm_Load;
            LoadIP();
        }
        public BaseForm(int clientID, string connectionString)
        {
            this.clientID = clientID;
            this.connectionString = connectionString;
            LoadIP();
            this.FormClosed += BaseForm_FormClosed;
            this.Load += BaseForm_Load;
        }
        private void LoadIP()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    ipAddress = client.DownloadString("https://api64.ipify.org?format=json");
                }
                ipAddress = ExtractNumbers(ipAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }

        string ExtractNumbers(string input)
        {
            return new string(input.ToCharArray().Where(c => char.IsDigit(c) || c == '.').ToArray());
        }

        public void SetClientId(int clientID)
        {
            this.clientID = clientID;
        }
        public void InsertQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                    }
                }
            }
        }

        public void StatusSettings(bool isOnline)
        {
            if(clientID != null)
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    string request = $"UPDATE Client SET status_online = '{isOnline}' WHERE client_id = {clientID}";

                    using (SqlCommand command = new SqlCommand(request, sqlconn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public string randomCode(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            string randomString = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }
        public bool IsValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            return Regex.Match(email, pattern, RegexOptions.IgnoreCase).Success;
        }
        public bool IsValidPassword(string phone)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,20}$";
            return Regex.Match(phone, pattern, RegexOptions.IgnoreCase).Success;
        }
        public bool IsValidPhone(string phone)
        {
            string pattern = @"^\+(?:[0-9] ?){11,14}[0-9]$";
            return Regex.Match(phone, pattern, RegexOptions.IgnoreCase).Success;
        }
        
        public void eyePictureBoxClick(PictureBox picture, TextBox textBox, ref bool isClick)
        {
            if (isClick)
            {
                picture.Image = System.Drawing.Image.FromFile(@"..\..\images\eye2.png");
                textBox.UseSystemPasswordChar = false;
                isClick = false;
            }
            else
            {
                picture.Image = System.Drawing.Image.FromFile(@"..\..\images\eye1.png");
                textBox.UseSystemPasswordChar = true;
                isClick = true;
            }
        }
        public void DataGridViewProfileFill(DataGridView dataGridView, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
        }
        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StatusSettings(false);
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
            StatusSettings(true);
        }

        public void CreatePdf(string query, string name)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                            folderBrowserDialog.Description = "Оберіть папку для збереження файлу";
                            folderBrowserDialog.ShowNewFolderButton = true;

                            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                            {
                                string folderPath = $@"{folderBrowserDialog.SelectedPath}\{name}.pdf";
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                // Створюємо об'єкт PDF-документа
                                using (PdfWriter writer = new PdfWriter(folderPath))
                                {
                                    using (PdfDocument pdf = new PdfDocument(writer))
                                    {
                                        Document document = new Document(pdf);
                                        PdfFont font = PdfFontFactory.CreateFont($@"..\..\fonts\DejaVuSans-Oblique.ttf", PdfEncodings.IDENTITY_H, true);
                                        document.SetFont(font);
                                        // Додаємо заголовок
                                        document.Add(new Paragraph(name));

                                        // Додаємо дані з результатів SQL-запиту
                                        foreach (DataRow row in dt.Rows)
                                        {
                                            foreach (DataColumn col in dt.Columns)
                                            {
                                                string s = row[col].ToString();
                                                document.Add(new Paragraph($"{col.ColumnName}: {s}"));
                                            }
                                            // Роздільник між рядками
                                            document.Add(new Paragraph("--------------------"));
                                        }
                                    }
                                }

                                MessageBox.Show("PDF-файл створено успішно!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.security_eventTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Security_eventTableAdapter();
            this.SuspendLayout();
            // 
            // security_eventTableAdapter
            // 
            this.security_eventTableAdapter.ClearBeforeFill = true;
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "BaseForm";
            this.ResumeLayout(false);
        }
    }
}
