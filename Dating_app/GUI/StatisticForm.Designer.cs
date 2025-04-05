namespace Dating_app.GUI
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statisticLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeMinLable = new System.Windows.Forms.Label();
            this.ageMinTextBox = new System.Windows.Forms.TextBox();
            this.AgeMaxLable = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.ageMaxTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.myStatisticLabel = new System.Windows.Forms.Label();
            this.middleAgeTextBox = new System.Windows.Forms.TextBox();
            this.middleAgeLabel = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.userStatisticPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.adminStatisticPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.highestRatingDataGridView = new System.Windows.Forms.DataGridView();
            this.savePDFButton = new System.Windows.Forms.Button();
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.blockedCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countChatsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countDatingTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countDatingLabel = new System.Windows.Forms.Label();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.interestTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.InterestTableAdapter();
            this.dating_historyTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Dating_historyTableAdapter();
            this.clientTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.userStatisticPanel.SuspendLayout();
            this.adminStatisticPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestRatingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dating_app.Properties.Resources.Icon2;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.statisticLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 139);
            this.panel1.TabIndex = 33;
            // 
            // statisticLabel
            // 
            this.statisticLabel.AutoSize = true;
            this.statisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticLabel.Location = new System.Drawing.Point(256, 27);
            this.statisticLabel.Name = "statisticLabel";
            this.statisticLabel.Size = new System.Drawing.Size(399, 76);
            this.statisticLabel.TabIndex = 10;
            this.statisticLabel.Text = "Статистика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(-7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Загальна статистика (найпопулярніше)";
            // 
            // AgeMinLable
            // 
            this.AgeMinLable.AutoSize = true;
            this.AgeMinLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeMinLable.Location = new System.Drawing.Point(38, 55);
            this.AgeMinLable.Name = "AgeMinLable";
            this.AgeMinLable.Size = new System.Drawing.Size(207, 29);
            this.AgeMinLable.TabIndex = 36;
            this.AgeMinLable.Text = "Мінімальний вік:";
            // 
            // ageMinTextBox
            // 
            this.ageMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageMinTextBox.Location = new System.Drawing.Point(342, 52);
            this.ageMinTextBox.Name = "ageMinTextBox";
            this.ageMinTextBox.ReadOnly = true;
            this.ageMinTextBox.Size = new System.Drawing.Size(130, 34);
            this.ageMinTextBox.TabIndex = 37;
            this.ageMinTextBox.Text = "-";
            this.ageMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgeMaxLable
            // 
            this.AgeMaxLable.AutoSize = true;
            this.AgeMaxLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeMaxLable.Location = new System.Drawing.Point(38, 104);
            this.AgeMaxLable.Name = "AgeMaxLable";
            this.AgeMaxLable.Size = new System.Drawing.Size(232, 29);
            this.AgeMaxLable.TabIndex = 38;
            this.AgeMaxLable.Text = "Максимальний вік:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(38, 154);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(86, 29);
            this.sexLabel.TabIndex = 39;
            this.sexLabel.Text = "Стать:";
            // 
            // ageMaxTextBox
            // 
            this.ageMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageMaxTextBox.Location = new System.Drawing.Point(342, 101);
            this.ageMaxTextBox.Name = "ageMaxTextBox";
            this.ageMaxTextBox.ReadOnly = true;
            this.ageMaxTextBox.Size = new System.Drawing.Size(130, 34);
            this.ageMaxTextBox.TabIndex = 40;
            this.ageMaxTextBox.Text = "-";
            this.ageMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexTextBox.Location = new System.Drawing.Point(342, 151);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(130, 34);
            this.sexTextBox.TabIndex = 41;
            this.sexTextBox.Text = "-";
            this.sexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myStatisticLabel
            // 
            this.myStatisticLabel.AutoSize = true;
            this.myStatisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myStatisticLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.myStatisticLabel.Location = new System.Drawing.Point(142, 205);
            this.myStatisticLabel.Name = "myStatisticLabel";
            this.myStatisticLabel.Size = new System.Drawing.Size(211, 31);
            this.myStatisticLabel.TabIndex = 42;
            this.myStatisticLabel.Text = "Моя статистика";
            // 
            // middleAgeTextBox
            // 
            this.middleAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleAgeTextBox.Location = new System.Drawing.Point(342, 256);
            this.middleAgeTextBox.Name = "middleAgeTextBox";
            this.middleAgeTextBox.ReadOnly = true;
            this.middleAgeTextBox.Size = new System.Drawing.Size(130, 34);
            this.middleAgeTextBox.TabIndex = 44;
            this.middleAgeTextBox.Text = "-";
            this.middleAgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // middleAgeLabel
            // 
            this.middleAgeLabel.AutoSize = true;
            this.middleAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleAgeLabel.Location = new System.Drawing.Point(38, 259);
            this.middleAgeLabel.Name = "middleAgeLabel";
            this.middleAgeLabel.Size = new System.Drawing.Size(285, 29);
            this.middleAgeLabel.TabIndex = 43;
            this.middleAgeLabel.Text = "Середній вік знайомих:";
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminLabel.ForeColor = System.Drawing.Color.Red;
            this.adminLabel.Location = new System.Drawing.Point(12, 499);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(143, 29);
            this.adminLabel.TabIndex = 45;
            this.adminLabel.Text = "Для адмінa";
            this.adminLabel.Visible = false;
            this.adminLabel.Click += new System.EventHandler(this.adminLabel_Click);
            // 
            // userStatisticPanel
            // 
            this.userStatisticPanel.Controls.Add(this.exitButton);
            this.userStatisticPanel.Controls.Add(this.label2);
            this.userStatisticPanel.Controls.Add(this.ageMinTextBox);
            this.userStatisticPanel.Controls.Add(this.middleAgeTextBox);
            this.userStatisticPanel.Controls.Add(this.middleAgeLabel);
            this.userStatisticPanel.Controls.Add(this.AgeMinLable);
            this.userStatisticPanel.Controls.Add(this.myStatisticLabel);
            this.userStatisticPanel.Controls.Add(this.AgeMaxLable);
            this.userStatisticPanel.Controls.Add(this.sexLabel);
            this.userStatisticPanel.Controls.Add(this.sexTextBox);
            this.userStatisticPanel.Controls.Add(this.ageMaxTextBox);
            this.userStatisticPanel.Location = new System.Drawing.Point(130, 151);
            this.userStatisticPanel.Name = "userStatisticPanel";
            this.userStatisticPanel.Size = new System.Drawing.Size(616, 383);
            this.userStatisticPanel.TabIndex = 46;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(160, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(192, 43);
            this.exitButton.TabIndex = 70;
            this.exitButton.Text = "Повернутися";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(248, 767);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(195, 43);
            this.backButton.TabIndex = 61;
            this.backButton.Text = "Повернутися";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // adminStatisticPanel
            // 
            this.adminStatisticPanel.Controls.Add(this.dataGridView1);
            this.adminStatisticPanel.Controls.Add(this.highestRatingDataGridView);
            this.adminStatisticPanel.Controls.Add(this.savePDFButton);
            this.adminStatisticPanel.Controls.Add(this.ratingNumericUpDown);
            this.adminStatisticPanel.Controls.Add(this.label6);
            this.adminStatisticPanel.Controls.Add(this.blockedCheckBox);
            this.adminStatisticPanel.Controls.Add(this.nameTextBox);
            this.adminStatisticPanel.Controls.Add(this.nameLabel);
            this.adminStatisticPanel.Controls.Add(this.label5);
            this.adminStatisticPanel.Controls.Add(this.label4);
            this.adminStatisticPanel.Controls.Add(this.countChatsTextBox);
            this.adminStatisticPanel.Controls.Add(this.label3);
            this.adminStatisticPanel.Controls.Add(this.countDatingTextBox);
            this.adminStatisticPanel.Controls.Add(this.label1);
            this.adminStatisticPanel.Controls.Add(this.countDatingLabel);
            this.adminStatisticPanel.Controls.Add(this.backButton);
            this.adminStatisticPanel.Location = new System.Drawing.Point(42, 151);
            this.adminStatisticPanel.Name = "adminStatisticPanel";
            this.adminStatisticPanel.Size = new System.Drawing.Size(730, 888);
            this.adminStatisticPanel.TabIndex = 62;
            this.adminStatisticPanel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(15, 527);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(689, 165);
            this.dataGridView1.TabIndex = 79;
            // 
            // highestRatingDataGridView
            // 
            this.highestRatingDataGridView.AllowUserToAddRows = false;
            this.highestRatingDataGridView.AllowUserToDeleteRows = false;
            this.highestRatingDataGridView.ColumnHeadersHeight = 29;
            this.highestRatingDataGridView.Location = new System.Drawing.Point(15, 258);
            this.highestRatingDataGridView.Name = "highestRatingDataGridView";
            this.highestRatingDataGridView.ReadOnly = true;
            this.highestRatingDataGridView.RowHeadersWidth = 51;
            this.highestRatingDataGridView.RowTemplate.Height = 24;
            this.highestRatingDataGridView.Size = new System.Drawing.Size(689, 150);
            this.highestRatingDataGridView.TabIndex = 78;
            // 
            // savePDFButton
            // 
            this.savePDFButton.AutoSize = true;
            this.savePDFButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.savePDFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePDFButton.Location = new System.Drawing.Point(248, 716);
            this.savePDFButton.Name = "savePDFButton";
            this.savePDFButton.Size = new System.Drawing.Size(195, 39);
            this.savePDFButton.TabIndex = 77;
            this.savePDFButton.Text = "Скачати в PDF";
            this.savePDFButton.UseVisualStyleBackColor = false;
            this.savePDFButton.Click += new System.EventHandler(this.savePDFButton_Click);
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingNumericUpDown.Location = new System.Drawing.Point(326, 207);
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.Size = new System.Drawing.Size(120, 34);
            this.ratingNumericUpDown.TabIndex = 76;
            this.ratingNumericUpDown.ValueChanged += new System.EventHandler(this.ratingNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(231, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "rating:";
            // 
            // blockedCheckBox
            // 
            this.blockedCheckBox.AutoSize = true;
            this.blockedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blockedCheckBox.Location = new System.Drawing.Point(417, 461);
            this.blockedCheckBox.Name = "blockedCheckBox";
            this.blockedCheckBox.Size = new System.Drawing.Size(288, 30);
            this.blockedCheckBox.TabIndex = 74;
            this.blockedCheckBox.Text = "Заблоковані користувачі";
            this.blockedCheckBox.UseVisualStyleBackColor = true;
            this.blockedCheckBox.CheckedChanged += new System.EventHandler(this.blockedCheckBox_CheckedChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(189, 457);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 34);
            this.nameTextBox.TabIndex = 72;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(-5, 457);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(155, 29);
            this.nameLabel.TabIndex = 71;
            this.nameLabel.Text = "Введіть ім\'я:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(40, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(597, 31);
            this.label5.TabIndex = 69;
            this.label5.Text = "Користувач за ім\'ям / заблоковані користувачі";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(125, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 31);
            this.label4.TabIndex = 68;
            this.label4.Text = "Користувачі з високим рейтингом";
            // 
            // countChatsTextBox
            // 
            this.countChatsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countChatsTextBox.Location = new System.Drawing.Point(445, 106);
            this.countChatsTextBox.Name = "countChatsTextBox";
            this.countChatsTextBox.ReadOnly = true;
            this.countChatsTextBox.Size = new System.Drawing.Size(130, 34);
            this.countChatsTextBox.TabIndex = 67;
            this.countChatsTextBox.Text = "-";
            this.countChatsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(141, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "Кількість чатів:";
            // 
            // countDatingTextBox
            // 
            this.countDatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDatingTextBox.Location = new System.Drawing.Point(445, 55);
            this.countDatingTextBox.Name = "countDatingTextBox";
            this.countDatingTextBox.ReadOnly = true;
            this.countDatingTextBox.Size = new System.Drawing.Size(130, 34);
            this.countDatingTextBox.TabIndex = 65;
            this.countDatingTextBox.Text = "-";
            this.countDatingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(195, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "Взаємодії користувачів";
            // 
            // countDatingLabel
            // 
            this.countDatingLabel.AutoSize = true;
            this.countDatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDatingLabel.Location = new System.Drawing.Point(141, 58);
            this.countDatingLabel.Name = "countDatingLabel";
            this.countDatingLabel.Size = new System.Drawing.Size(255, 29);
            this.countDatingLabel.TabIndex = 64;
            this.countDatingLabel.Text = "Кількість знайомств:";
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // interestTableAdapter
            // 
            this.interestTableAdapter.ClearBeforeFill = true;
            // 
            // dating_historyTableAdapter
            // 
            this.dating_historyTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 1025);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.userStatisticPanel);
            this.Controls.Add(this.adminStatisticPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 2);
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userStatisticPanel.ResumeLayout(false);
            this.userStatisticPanel.PerformLayout();
            this.adminStatisticPanel.ResumeLayout(false);
            this.adminStatisticPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestRatingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label statisticLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AgeMinLable;
        private Dating_app_baseDataSetTableAdapters.InterestTableAdapter interestTableAdapter;
        private Dating_app_baseDataSetTableAdapters.Dating_historyTableAdapter dating_historyTableAdapter;
        private Dating_app_baseDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox ageMinTextBox;
        private System.Windows.Forms.Label AgeMaxLable;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox ageMaxTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.Label myStatisticLabel;
        private System.Windows.Forms.TextBox middleAgeTextBox;
        private System.Windows.Forms.Label middleAgeLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Panel userStatisticPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel adminStatisticPanel;
        private System.Windows.Forms.TextBox countChatsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countDatingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countDatingLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.CheckBox blockedCheckBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button savePDFButton;
        private System.Windows.Forms.DataGridView highestRatingDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}