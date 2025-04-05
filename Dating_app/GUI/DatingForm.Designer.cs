namespace Dating_app
{
    partial class DatingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatingForm));
            this.datingFormLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.interestTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.InterestTableAdapter();
            this.photoTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.PhotoTableAdapter();
            this.starPictureBox5 = new System.Windows.Forms.PictureBox();
            this.starPictureBox4 = new System.Windows.Forms.PictureBox();
            this.starPictureBox3 = new System.Windows.Forms.PictureBox();
            this.starPictureBox2 = new System.Windows.Forms.PictureBox();
            this.starPictureBox1 = new System.Windows.Forms.PictureBox();
            this.rightLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.namePhotoLabel = new System.Windows.Forms.Label();
            this.dating_historyTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Dating_historyTableAdapter();
            this.chatTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.ChatTableAdapter();
            this.client_chatTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.Client_chatTableAdapter();
            this.clientTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datingFormLabel
            // 
            this.datingFormLabel.AutoSize = true;
            this.datingFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datingFormLabel.Location = new System.Drawing.Point(274, 25);
            this.datingFormLabel.Name = "datingFormLabel";
            this.datingFormLabel.Size = new System.Drawing.Size(549, 76);
            this.datingFormLabel.TabIndex = 9;
            this.datingFormLabel.Text = "Пошук інтересів";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Dating_app.Properties.Resources.Icon2;
            this.iconPictureBox.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(147, 126);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 6;
            this.iconPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.datingFormLabel);
            this.panel1.Controls.Add(this.iconPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 139);
            this.panel1.TabIndex = 34;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photoPictureBox.Location = new System.Drawing.Point(82, 158);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(321, 336);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 35;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(472, 159);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(469, 289);
            this.infoLabel.TabIndex = 37;
            this.infoLabel.Text = "label1";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(242, 572);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(224, 53);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "Пропустити";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.Location = new System.Drawing.Point(498, 572);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(224, 53);
            this.confirmButton.TabIndex = 45;
            this.confirmButton.Text = "Познайомитися";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // interestTableAdapter
            // 
            this.interestTableAdapter.ClearBeforeFill = true;
            // 
            // photoTableAdapter
            // 
            this.photoTableAdapter.ClearBeforeFill = true;
            // 
            // starPictureBox5
            // 
            this.starPictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starPictureBox5.Enabled = false;
            this.starPictureBox5.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox5.Location = new System.Drawing.Point(298, 500);
            this.starPictureBox5.Name = "starPictureBox5";
            this.starPictureBox5.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox5.TabIndex = 50;
            this.starPictureBox5.TabStop = false;
            this.starPictureBox5.Click += new System.EventHandler(this.starPictureBox5_Click);
            // 
            // starPictureBox4
            // 
            this.starPictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starPictureBox4.Enabled = false;
            this.starPictureBox4.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox4.Location = new System.Drawing.Point(262, 500);
            this.starPictureBox4.Name = "starPictureBox4";
            this.starPictureBox4.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox4.TabIndex = 49;
            this.starPictureBox4.TabStop = false;
            this.starPictureBox4.Click += new System.EventHandler(this.starPictureBox4_Click);
            // 
            // starPictureBox3
            // 
            this.starPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starPictureBox3.Enabled = false;
            this.starPictureBox3.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox3.Location = new System.Drawing.Point(226, 500);
            this.starPictureBox3.Name = "starPictureBox3";
            this.starPictureBox3.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox3.TabIndex = 48;
            this.starPictureBox3.TabStop = false;
            this.starPictureBox3.Click += new System.EventHandler(this.starPictureBox3_Click);
            // 
            // starPictureBox2
            // 
            this.starPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starPictureBox2.Enabled = false;
            this.starPictureBox2.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox2.Location = new System.Drawing.Point(190, 500);
            this.starPictureBox2.Name = "starPictureBox2";
            this.starPictureBox2.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox2.TabIndex = 47;
            this.starPictureBox2.TabStop = false;
            this.starPictureBox2.Click += new System.EventHandler(this.starPictureBox2_Click);
            // 
            // starPictureBox1
            // 
            this.starPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starPictureBox1.Enabled = false;
            this.starPictureBox1.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox1.Location = new System.Drawing.Point(154, 499);
            this.starPictureBox1.Name = "starPictureBox1";
            this.starPictureBox1.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox1.TabIndex = 46;
            this.starPictureBox1.TabStop = false;
            this.starPictureBox1.Click += new System.EventHandler(this.starPictureBox1_Click);
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLabel.ForeColor = System.Drawing.Color.Black;
            this.rightLabel.Location = new System.Drawing.Point(412, 289);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(80, 76);
            this.rightLabel.TabIndex = 52;
            this.rightLabel.Text = "⇾";
            this.rightLabel.Visible = false;
            this.rightLabel.Click += new System.EventHandler(this.rightLabel_Click);
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftLabel.Enabled = false;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.leftLabel.Location = new System.Drawing.Point(-9, 299);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(80, 76);
            this.leftLabel.TabIndex = 51;
            this.leftLabel.Text = "⇽";
            this.leftLabel.Visible = false;
            this.leftLabel.Click += new System.EventHandler(this.leftLabel_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(380, 572);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(224, 53);
            this.returnButton.TabIndex = 54;
            this.returnButton.Text = "Повернутися";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // namePhotoLabel
            // 
            this.namePhotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePhotoLabel.Location = new System.Drawing.Point(505, 159);
            this.namePhotoLabel.Name = "namePhotoLabel";
            this.namePhotoLabel.Size = new System.Drawing.Size(469, 335);
            this.namePhotoLabel.TabIndex = 53;
            this.namePhotoLabel.Text = "namePhotoLabel";
            this.namePhotoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.namePhotoLabel.Visible = false;
            // 
            // dating_historyTableAdapter
            // 
            this.dating_historyTableAdapter.ClearBeforeFill = true;
            // 
            // chatTableAdapter
            // 
            this.chatTableAdapter.ClearBeforeFill = true;
            // 
            // client_chatTableAdapter
            // 
            this.client_chatTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // DatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1009, 628);
            this.Controls.Add(this.namePhotoLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.starPictureBox5);
            this.Controls.Add(this.starPictureBox4);
            this.Controls.Add(this.starPictureBox3);
            this.Controls.Add(this.starPictureBox2);
            this.Controls.Add(this.starPictureBox1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.returnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1027, 675);
            this.MinimumSize = new System.Drawing.Size(1027, 675);
            this.Name = "DatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Знайомства";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datingFormLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private Dating_app_baseDataSetTableAdapters.InterestTableAdapter interestTableAdapter;
        private Dating_app_baseDataSetTableAdapters.PhotoTableAdapter photoTableAdapter;
        private System.Windows.Forms.PictureBox starPictureBox5;
        private System.Windows.Forms.PictureBox starPictureBox4;
        private System.Windows.Forms.PictureBox starPictureBox3;
        private System.Windows.Forms.PictureBox starPictureBox2;
        private System.Windows.Forms.PictureBox starPictureBox1;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label namePhotoLabel;
        private Dating_app_baseDataSetTableAdapters.Dating_historyTableAdapter dating_historyTableAdapter;
        private Dating_app_baseDataSetTableAdapters.ChatTableAdapter chatTableAdapter;
        private Dating_app_baseDataSetTableAdapters.Client_chatTableAdapter client_chatTableAdapter;
        private Dating_app_baseDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}