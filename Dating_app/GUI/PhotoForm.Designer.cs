namespace Dating_app
{
    partial class PhotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.createPhotoLabel = new System.Windows.Forms.Label();
            this.createExitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.starPictureBox5 = new System.Windows.Forms.PictureBox();
            this.starPictureBox4 = new System.Windows.Forms.PictureBox();
            this.starPictureBox3 = new System.Windows.Forms.PictureBox();
            this.starPictureBox2 = new System.Windows.Forms.PictureBox();
            this.starPictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.photoTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.PhotoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.profileLabel);
            this.panel1.Controls.Add(this.iconPictureBox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 139);
            this.panel1.TabIndex = 33;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileLabel.Location = new System.Drawing.Point(274, 31);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(326, 76);
            this.profileLabel.TabIndex = 9;
            this.profileLabel.Text = "Мої фото";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Dating_app.Properties.Resources.Icon21;
            this.iconPictureBox.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(147, 126);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 6;
            this.iconPictureBox.TabStop = false;
            // 
            // downloadButton
            // 
            this.downloadButton.AutoSize = true;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadButton.Location = new System.Drawing.Point(209, 279);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(215, 46);
            this.downloadButton.TabIndex = 26;
            this.downloadButton.Text = "Загрузити фото";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Фото:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(99, 198);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 29);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Ім\'я фото:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(235, 198);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(189, 34);
            this.nameTextBox.TabIndex = 23;
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftLabel.Enabled = false;
            this.leftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.leftLabel.Location = new System.Drawing.Point(217, 367);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(80, 76);
            this.leftLabel.TabIndex = 34;
            this.leftLabel.Text = "⇽";
            this.leftLabel.Click += new System.EventHandler(this.leftLabel_Click);
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLabel.ForeColor = System.Drawing.Color.Black;
            this.rightLabel.Location = new System.Drawing.Point(460, 367);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(80, 76);
            this.rightLabel.TabIndex = 35;
            this.rightLabel.Text = "⇾";
            this.rightLabel.Click += new System.EventHandler(this.rightLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(288, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 45);
            this.exitButton.TabIndex = 60;
            this.exitButton.Text = "Повернутися";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createPhotoLabel
            // 
            this.createPhotoLabel.AutoSize = true;
            this.createPhotoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPhotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPhotoLabel.Location = new System.Drawing.Point(285, 145);
            this.createPhotoLabel.Name = "createPhotoLabel";
            this.createPhotoLabel.Size = new System.Drawing.Size(209, 25);
            this.createPhotoLabel.TabIndex = 61;
            this.createPhotoLabel.Text = "Створити нове фото";
            this.createPhotoLabel.Click += new System.EventHandler(this.createChatLabel_Click);
            this.createPhotoLabel.MouseEnter += new System.EventHandler(this.createChatLabel_MouseEnter);
            this.createPhotoLabel.MouseLeave += new System.EventHandler(this.createChatLabel_MouseLeave);
            // 
            // createExitButton
            // 
            this.createExitButton.AutoSize = true;
            this.createExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createExitButton.Location = new System.Drawing.Point(167, 391);
            this.createExitButton.Name = "createExitButton";
            this.createExitButton.Size = new System.Drawing.Size(182, 45);
            this.createExitButton.TabIndex = 62;
            this.createExitButton.Text = "Повернутися";
            this.createExitButton.UseVisualStyleBackColor = false;
            this.createExitButton.Visible = false;
            this.createExitButton.Click += new System.EventHandler(this.createExitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(476, 391);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 45);
            this.saveButton.TabIndex = 63;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteLabel.Location = new System.Drawing.Point(21, 367);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(140, 55);
            this.deleteLabel.TabIndex = 65;
            this.deleteLabel.Text = "Видалити фото";
            this.deleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            // 
            // starPictureBox5
            // 
            this.starPictureBox5.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox5.Location = new System.Drawing.Point(662, 336);
            this.starPictureBox5.Name = "starPictureBox5";
            this.starPictureBox5.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox5.TabIndex = 40;
            this.starPictureBox5.TabStop = false;
            // 
            // starPictureBox4
            // 
            this.starPictureBox4.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox4.Location = new System.Drawing.Point(626, 336);
            this.starPictureBox4.Name = "starPictureBox4";
            this.starPictureBox4.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox4.TabIndex = 39;
            this.starPictureBox4.TabStop = false;
            // 
            // starPictureBox3
            // 
            this.starPictureBox3.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox3.Location = new System.Drawing.Point(590, 336);
            this.starPictureBox3.Name = "starPictureBox3";
            this.starPictureBox3.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox3.TabIndex = 38;
            this.starPictureBox3.TabStop = false;
            // 
            // starPictureBox2
            // 
            this.starPictureBox2.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox2.Location = new System.Drawing.Point(554, 336);
            this.starPictureBox2.Name = "starPictureBox2";
            this.starPictureBox2.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox2.TabIndex = 37;
            this.starPictureBox2.TabStop = false;
            // 
            // starPictureBox1
            // 
            this.starPictureBox1.Image = global::Dating_app.Properties.Resources.star;
            this.starPictureBox1.Location = new System.Drawing.Point(518, 335);
            this.starPictureBox1.Name = "starPictureBox1";
            this.starPictureBox1.Size = new System.Drawing.Size(30, 33);
            this.starPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.starPictureBox1.TabIndex = 36;
            this.starPictureBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(521, 162);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(168, 168);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 27;
            this.pictureBox.TabStop = false;
            // 
            // photoTableAdapter
            // 
            this.photoTableAdapter.ClearBeforeFill = true;
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.createPhotoLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.starPictureBox5);
            this.Controls.Add(this.starPictureBox4);
            this.Controls.Add(this.starPictureBox3);
            this.Controls.Add(this.starPictureBox2);
            this.Controls.Add(this.starPictureBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.createExitButton);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "PhotoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мої фото";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private Dating_app_baseDataSetTableAdapters.PhotoTableAdapter photoTableAdapter;
        private System.Windows.Forms.PictureBox starPictureBox1;
        private System.Windows.Forms.PictureBox starPictureBox2;
        private System.Windows.Forms.PictureBox starPictureBox3;
        private System.Windows.Forms.PictureBox starPictureBox4;
        private System.Windows.Forms.PictureBox starPictureBox5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label createPhotoLabel;
        private System.Windows.Forms.Button createExitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
    }
}