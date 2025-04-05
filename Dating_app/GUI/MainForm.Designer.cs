namespace Dating_app
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statisticLabel = new System.Windows.Forms.Label();
            this.intrstLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.datingButton = new System.Windows.Forms.Button();
            this.createChatLabel = new System.Windows.Forms.Label();
            this.chatListBox = new System.Windows.Forms.ListBox();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.setImgButton = new System.Windows.Forms.Button();
            this.nameChatTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameChatLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.photoButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.joinLabel = new System.Windows.Forms.Label();
            this.joinButton = new System.Windows.Forms.Button();
            this.inviteTextBox = new System.Windows.Forms.TextBox();
            this.inviteLabel = new System.Windows.Forms.Label();
            this.chatTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.ChatTableAdapter();
            this.client_chatTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Client_chatTableAdapter();
            this.dating_historyTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Dating_historyTableAdapter();
            this.sortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dating_app.Properties.Resources.Icon2;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel1.Controls.Add(this.intrstLabel);
            this.panel1.Controls.Add(this.profileLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 139);
            this.panel1.TabIndex = 32;
            // 
            // statisticLabel
            // 
            this.statisticLabel.AutoSize = true;
            this.statisticLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticLabel.Location = new System.Drawing.Point(573, 10);
            this.statisticLabel.Name = "statisticLabel";
            this.statisticLabel.Size = new System.Drawing.Size(168, 31);
            this.statisticLabel.TabIndex = 9;
            this.statisticLabel.Text = "Статистика";
            this.statisticLabel.Click += new System.EventHandler(this.statisticLabel_Click);
            // 
            // intrstLabel
            // 
            this.intrstLabel.AutoSize = true;
            this.intrstLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.intrstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intrstLabel.Location = new System.Drawing.Point(403, 10);
            this.intrstLabel.Name = "intrstLabel";
            this.intrstLabel.Size = new System.Drawing.Size(131, 31);
            this.intrstLabel.TabIndex = 8;
            this.intrstLabel.Text = "Інтереси";
            this.intrstLabel.Click += new System.EventHandler(this.intrstLabel_Click);
            this.intrstLabel.MouseEnter += new System.EventHandler(this.intrstLabel_MouseEnter);
            this.intrstLabel.MouseLeave += new System.EventHandler(this.intrstLabel_MouseLeave);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileLabel.Location = new System.Drawing.Point(173, 10);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(177, 31);
            this.profileLabel.TabIndex = 7;
            this.profileLabel.Text = "Мій профіль";
            this.profileLabel.Click += new System.EventHandler(this.profileLabel_Click);
            this.profileLabel.MouseEnter += new System.EventHandler(this.profileLabel_MouseEnter);
            this.profileLabel.MouseLeave += new System.EventHandler(this.profileLabel_MouseLeave);
            // 
            // datingButton
            // 
            this.datingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.datingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datingButton.Location = new System.Drawing.Point(517, 425);
            this.datingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datingButton.Name = "datingButton";
            this.datingButton.Size = new System.Drawing.Size(192, 53);
            this.datingButton.TabIndex = 34;
            this.datingButton.Text = "Знайомства";
            this.datingButton.UseVisualStyleBackColor = false;
            this.datingButton.Click += new System.EventHandler(this.datingButton_Click);
            // 
            // createChatLabel
            // 
            this.createChatLabel.AutoSize = true;
            this.createChatLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createChatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createChatLabel.Location = new System.Drawing.Point(113, 150);
            this.createChatLabel.Name = "createChatLabel";
            this.createChatLabel.Size = new System.Drawing.Size(200, 25);
            this.createChatLabel.TabIndex = 35;
            this.createChatLabel.Text = "Створити новий чат";
            this.createChatLabel.Click += new System.EventHandler(this.createChatLabel_Click);
            this.createChatLabel.MouseEnter += new System.EventHandler(this.createChatLabel_MouseEnter);
            this.createChatLabel.MouseLeave += new System.EventHandler(this.createChatLabel_MouseLeave);
            // 
            // chatListBox
            // 
            this.chatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chatListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatListBox.FormattingEnabled = true;
            this.chatListBox.HorizontalScrollbar = true;
            this.chatListBox.ItemHeight = 29;
            this.chatListBox.Location = new System.Drawing.Point(65, 181);
            this.chatListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.Size = new System.Drawing.Size(663, 236);
            this.chatListBox.TabIndex = 36;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.White;
            this.iconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iconPictureBox.Location = new System.Drawing.Point(392, 266);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(173, 117);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 37;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.Visible = false;
            // 
            // setImgButton
            // 
            this.setImgButton.AutoSize = true;
            this.setImgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setImgButton.Location = new System.Drawing.Point(207, 306);
            this.setImgButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setImgButton.Name = "setImgButton";
            this.setImgButton.Size = new System.Drawing.Size(149, 33);
            this.setImgButton.TabIndex = 38;
            this.setImgButton.Text = "Вибрати фото";
            this.setImgButton.UseVisualStyleBackColor = true;
            this.setImgButton.Visible = false;
            this.setImgButton.Click += new System.EventHandler(this.setImgButton_Click);
            // 
            // nameChatTextBox
            // 
            this.nameChatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameChatTextBox.Location = new System.Drawing.Point(392, 208);
            this.nameChatTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameChatTextBox.Name = "nameChatTextBox";
            this.nameChatTextBox.Size = new System.Drawing.Size(173, 34);
            this.nameChatTextBox.TabIndex = 39;
            this.nameChatTextBox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(517, 422);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 53);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Створити чат";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameChatLabel
            // 
            this.nameChatLabel.AutoSize = true;
            this.nameChatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameChatLabel.Location = new System.Drawing.Point(203, 208);
            this.nameChatLabel.Name = "nameChatLabel";
            this.nameChatLabel.Size = new System.Drawing.Size(144, 29);
            this.nameChatLabel.TabIndex = 42;
            this.nameChatLabel.Text = "Назва чату:";
            this.nameChatLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(80, 416);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(192, 53);
            this.backButton.TabIndex = 40;
            this.backButton.Text = "Повернутися";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // photoButton
            // 
            this.photoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.photoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoButton.Location = new System.Drawing.Point(80, 425);
            this.photoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(192, 53);
            this.photoButton.TabIndex = 43;
            this.photoButton.Text = "Мої фото";
            this.photoButton.UseVisualStyleBackColor = false;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // joinLabel
            // 
            this.joinLabel.AutoSize = true;
            this.joinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinLabel.Location = new System.Drawing.Point(401, 150);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(258, 25);
            this.joinLabel.TabIndex = 44;
            this.joinLabel.Text = "Приєднатися до існуючого";
            this.joinLabel.Click += new System.EventHandler(this.joinLabel_Click);
            this.joinLabel.MouseEnter += new System.EventHandler(this.joinLabel_MouseEnter);
            this.joinLabel.MouseLeave += new System.EventHandler(this.joinLabel_MouseLeave);
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.joinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinButton.Location = new System.Drawing.Point(517, 425);
            this.joinButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(192, 53);
            this.joinButton.TabIndex = 45;
            this.joinButton.Text = "Приєднатися";
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Visible = false;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // inviteTextBox
            // 
            this.inviteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inviteTextBox.Location = new System.Drawing.Point(437, 258);
            this.inviteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inviteTextBox.Name = "inviteTextBox";
            this.inviteTextBox.Size = new System.Drawing.Size(203, 41);
            this.inviteTextBox.TabIndex = 46;
            this.inviteTextBox.Visible = false;
            // 
            // inviteLabel
            // 
            this.inviteLabel.AutoSize = true;
            this.inviteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inviteLabel.Location = new System.Drawing.Point(141, 261);
            this.inviteLabel.Name = "inviteLabel";
            this.inviteLabel.Size = new System.Drawing.Size(260, 36);
            this.inviteLabel.TabIndex = 47;
            this.inviteLabel.Text = "Код запрошення:";
            this.inviteLabel.Visible = false;
            // 
            // chatTableAdapter
            // 
            this.chatTableAdapter.ClearBeforeFill = true;
            // 
            // client_chatTableAdapter
            // 
            this.client_chatTableAdapter.ClearBeforeFill = true;
            // 
            // dating_historyTableAdapter
            // 
            this.dating_historyTableAdapter.ClearBeforeFill = true;
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortButton.Location = new System.Drawing.Point(337, 429);
            this.sortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(119, 44);
            this.sortButton.TabIndex = 74;
            this.sortButton.Text = "Улюблені";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.inviteLabel);
            this.Controls.Add(this.inviteTextBox);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.nameChatLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nameChatTextBox);
            this.Controls.Add(this.setImgButton);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.createChatLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chatListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.datingButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 531);
            this.MinimumSize = new System.Drawing.Size(818, 531);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label intrstLabel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Button datingButton;
        private System.Windows.Forms.Label createChatLabel;
        private System.Windows.Forms.ListBox chatListBox;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button setImgButton;
        private System.Windows.Forms.TextBox nameChatTextBox;
        private System.Windows.Forms.Button saveButton;
        private Dating_app_baseDataSetTableAdapters.ChatTableAdapter chatTableAdapter;
        private Dating_app_baseDataSetTableAdapters.Client_chatTableAdapter client_chatTableAdapter;
        private System.Windows.Forms.Label nameChatLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Label inviteLabel;
        private System.Windows.Forms.TextBox inviteTextBox;
        private System.Windows.Forms.Label statisticLabel;
        private Dating_app_baseDataSetTableAdapters.Dating_historyTableAdapter dating_historyTableAdapter;
        private System.Windows.Forms.Button sortButton;
    }
}