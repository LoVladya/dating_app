namespace Dating_app
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.chatFormLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.sendPictureBox = new System.Windows.Forms.PictureBox();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.fatnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.setImgButton = new System.Windows.Forms.Button();
            this.setIconPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fatnessLabel = new System.Windows.Forms.Label();
            this.favoriteLabel = new System.Windows.Forms.Label();
            this.starPictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chat_messageTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Chat_messageTableAdapter();
            this.dating_app_baseDataSet = new Dating_app.Dating_app_baseDataSet();
            this.chatmessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.ClientTableAdapter();
            this.client_chatTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Client_chatTableAdapter();
            this.chatTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.ChatTableAdapter();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorLabel = new System.Windows.Forms.Label();
            this.msgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.security_eventTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Security_eventTableAdapter();
            this.codeNameLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatnessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dating_app_baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatmessageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chatFormLabel
            // 
            this.chatFormLabel.AutoSize = true;
            this.chatFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatFormLabel.Location = new System.Drawing.Point(370, 35);
            this.chatFormLabel.Name = "chatFormLabel";
            this.chatFormLabel.Size = new System.Drawing.Size(149, 76);
            this.chatFormLabel.TabIndex = 9;
            this.chatFormLabel.Text = "Чат";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chatFormLabel);
            this.panel1.Controls.Add(this.iconPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 139);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Dating_app.Properties.Resources.gear;
            this.pictureBox1.Location = new System.Drawing.Point(833, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Dating_app.Properties.Resources.Icon21;
            this.iconPictureBox.Location = new System.Drawing.Point(3, 4);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(147, 126);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 6;
            this.iconPictureBox.TabStop = false;
            // 
            // msgTextBox
            // 
            this.msgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msgTextBox.Location = new System.Drawing.Point(41, 641);
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(798, 34);
            this.msgTextBox.TabIndex = 37;
            // 
            // sendPictureBox
            // 
            this.sendPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendPictureBox.Image = global::Dating_app.Properties.Resources.send;
            this.sendPictureBox.Location = new System.Drawing.Point(857, 635);
            this.sendPictureBox.Name = "sendPictureBox";
            this.sendPictureBox.Size = new System.Drawing.Size(44, 40);
            this.sendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendPictureBox.TabIndex = 38;
            this.sendPictureBox.TabStop = false;
            this.sendPictureBox.Click += new System.EventHandler(this.sendPictureBox_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteLabel.Location = new System.Drawing.Point(22, 576);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(149, 78);
            this.deleteLabel.TabIndex = 65;
            this.deleteLabel.Text = "Вийти з чату";
            this.deleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteLabel.Visible = false;
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            // 
            // fatnessNumericUpDown
            // 
            this.fatnessNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatnessNumericUpDown.Location = new System.Drawing.Point(476, 281);
            this.fatnessNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.fatnessNumericUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.fatnessNumericUpDown.Name = "fatnessNumericUpDown";
            this.fatnessNumericUpDown.Size = new System.Drawing.Size(120, 41);
            this.fatnessNumericUpDown.TabIndex = 69;
            this.fatnessNumericUpDown.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.fatnessNumericUpDown.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(476, 163);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(341, 41);
            this.nameTextBox.TabIndex = 66;
            this.nameTextBox.Text = "1";
            this.nameTextBox.Visible = false;
            // 
            // setImgButton
            // 
            this.setImgButton.AutoSize = true;
            this.setImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setImgButton.Location = new System.Drawing.Point(138, 468);
            this.setImgButton.Name = "setImgButton";
            this.setImgButton.Size = new System.Drawing.Size(188, 39);
            this.setImgButton.TabIndex = 71;
            this.setImgButton.Text = "Вибрати фото";
            this.setImgButton.UseVisualStyleBackColor = true;
            this.setImgButton.Visible = false;
            this.setImgButton.Click += new System.EventHandler(this.setImgButton_Click);
            // 
            // setIconPictureBox
            // 
            this.setIconPictureBox.BackColor = System.Drawing.Color.Bisque;
            this.setIconPictureBox.Location = new System.Drawing.Point(476, 399);
            this.setIconPictureBox.Name = "setIconPictureBox";
            this.setIconPictureBox.Size = new System.Drawing.Size(168, 168);
            this.setIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setIconPictureBox.TabIndex = 70;
            this.setIconPictureBox.TabStop = false;
            this.setIconPictureBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(132, 163);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(183, 36);
            this.nameLabel.TabIndex = 72;
            this.nameLabel.Text = "Назва чату:";
            this.nameLabel.Visible = false;
            // 
            // fatnessLabel
            // 
            this.fatnessLabel.AutoSize = true;
            this.fatnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatnessLabel.Location = new System.Drawing.Point(132, 286);
            this.fatnessLabel.Name = "fatnessLabel";
            this.fatnessLabel.Size = new System.Drawing.Size(159, 36);
            this.fatnessLabel.TabIndex = 73;
            this.fatnessLabel.Text = "Жирність:";
            this.fatnessLabel.Visible = false;
            // 
            // favoriteLabel
            // 
            this.favoriteLabel.AutoSize = true;
            this.favoriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favoriteLabel.Location = new System.Drawing.Point(131, 353);
            this.favoriteLabel.Name = "favoriteLabel";
            this.favoriteLabel.Size = new System.Drawing.Size(315, 36);
            this.favoriteLabel.TabIndex = 74;
            this.favoriteLabel.Text = "Цей чат улюблений?";
            this.favoriteLabel.Visible = false;
            // 
            // starPictureBox
            // 
            this.starPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starPictureBox.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox.Location = new System.Drawing.Point(476, 338);
            this.starPictureBox.Name = "starPictureBox";
            this.starPictureBox.Size = new System.Drawing.Size(50, 54);
            this.starPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox.TabIndex = 75;
            this.starPictureBox.TabStop = false;
            this.starPictureBox.Visible = false;
            this.starPictureBox.Click += new System.EventHandler(this.starPictureBox_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(383, 576);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 49);
            this.saveButton.TabIndex = 76;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chat_messageTableAdapter
            // 
            this.chat_messageTableAdapter.ClearBeforeFill = true;
            // 
            // dating_app_baseDataSet
            // 
            this.dating_app_baseDataSet.DataSetName = "Dating_app_baseDataSet";
            this.dating_app_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chatmessageBindingSource
            // 
            this.chatmessageBindingSource.DataMember = "Chat_message";
            this.chatmessageBindingSource.DataSource = this.dating_app_baseDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // client_chatTableAdapter
            // 
            this.client_chatTableAdapter.ClearBeforeFill = true;
            // 
            // chatTableAdapter
            // 
            this.chatTableAdapter.ClearBeforeFill = true;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.BackColor = System.Drawing.Color.Bisque;
            this.colorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorLabel.Location = new System.Drawing.Point(0, 635);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(38, 39);
            this.colorLabel.TabIndex = 77;
            this.colorLabel.Text = "●";
            this.colorLabel.Click += new System.EventHandler(this.colorLabel_Click);
            // 
            // msgRichTextBox
            // 
            this.msgRichTextBox.BackColor = System.Drawing.Color.Bisque;
            this.msgRichTextBox.Location = new System.Drawing.Point(0, 136);
            this.msgRichTextBox.Name = "msgRichTextBox";
            this.msgRichTextBox.ReadOnly = true;
            this.msgRichTextBox.Size = new System.Drawing.Size(923, 471);
            this.msgRichTextBox.TabIndex = 78;
            this.msgRichTextBox.Text = "";
            // 
            // security_eventTableAdapter
            // 
            this.security_eventTableAdapter.ClearBeforeFill = true;
            // 
            // codeNameLabel
            // 
            this.codeNameLabel.AutoSize = true;
            this.codeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeNameLabel.Location = new System.Drawing.Point(131, 220);
            this.codeNameLabel.Name = "codeNameLabel";
            this.codeNameLabel.Size = new System.Drawing.Size(260, 36);
            this.codeNameLabel.TabIndex = 79;
            this.codeNameLabel.Text = "Код запрошення:";
            this.codeNameLabel.Visible = false;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeLabel.Location = new System.Drawing.Point(470, 220);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(25, 36);
            this.codeLabel.TabIndex = 80;
            this.codeLabel.Text = "-";
            this.codeLabel.Visible = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(922, 700);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeNameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.msgTextBox);
            this.Controls.Add(this.starPictureBox);
            this.Controls.Add(this.favoriteLabel);
            this.Controls.Add(this.fatnessLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.setImgButton);
            this.Controls.Add(this.setIconPictureBox);
            this.Controls.Add(this.fatnessNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.sendPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.msgRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(940, 747);
            this.MinimumSize = new System.Drawing.Size(940, 747);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мій чат";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatnessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dating_app_baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatmessageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chatFormLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox msgTextBox;
        private Dating_app_baseDataSetTableAdapters.Chat_messageTableAdapter chat_messageTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox sendPictureBox;
        private Dating_app_baseDataSet dating_app_baseDataSet;
        private System.Windows.Forms.BindingSource chatmessageBindingSource;
        private Dating_app_baseDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private Dating_app_baseDataSetTableAdapters.Client_chatTableAdapter client_chatTableAdapter;
        private System.Windows.Forms.Label deleteLabel;
        private Dating_app_baseDataSetTableAdapters.ChatTableAdapter chatTableAdapter;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.NumericUpDown fatnessNumericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button setImgButton;
        private System.Windows.Forms.PictureBox setIconPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fatnessLabel;
        private System.Windows.Forms.Label favoriteLabel;
        private System.Windows.Forms.PictureBox starPictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RichTextBox msgRichTextBox;
        private Dating_app_baseDataSetTableAdapters.Security_eventTableAdapter security_eventTableAdapter;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label codeNameLabel;
    }
}