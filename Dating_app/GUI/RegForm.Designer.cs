namespace Dating_app
{
    partial class RegForm
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
            System.Windows.Forms.Label client_nameLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label marital_statusLabel;
            System.Windows.Forms.Label description_clientLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label passwLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.regFormLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginFormLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dating_app_baseDataSet = new Dating_app.Dating_app_baseDataSet();
            this.clientTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Dating_app.Dating_app_baseDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.descrTextBox = new System.Windows.Forms.TextBox();
            this.maritalCheckBox = new System.Windows.Forms.CheckBox();
            this.pswdTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sexErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pswdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oSexRadioButton = new System.Windows.Forms.RadioButton();
            this.mSexRadioButton = new System.Windows.Forms.RadioButton();
            this.wSexRadioButton = new System.Windows.Forms.RadioButton();
            this.eyePictureBox = new System.Windows.Forms.PictureBox();
            this.interestTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.InterestTableAdapter();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.photoTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.PhotoTableAdapter();
            client_nameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            marital_statusLabel = new System.Windows.Forms.Label();
            description_clientLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            passwLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dating_app_baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pswdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // client_nameLabel
            // 
            client_nameLabel.AutoSize = true;
            client_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_nameLabel.Location = new System.Drawing.Point(139, 159);
            client_nameLabel.Name = "client_nameLabel";
            client_nameLabel.Size = new System.Drawing.Size(171, 29);
            client_nameLabel.TabIndex = 10;
            client_nameLabel.Text = "Ваш нікнейм:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sexLabel.Location = new System.Drawing.Point(139, 212);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(87, 29);
            sexLabel.TabIndex = 12;
            sexLabel.Text = "Стать:";
            // 
            // marital_statusLabel
            // 
            marital_statusLabel.AutoSize = true;
            marital_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            marital_statusLabel.Location = new System.Drawing.Point(139, 320);
            marital_statusLabel.Name = "marital_statusLabel";
            marital_statusLabel.Size = new System.Drawing.Size(202, 29);
            marital_statusLabel.TabIndex = 14;
            marital_statusLabel.Text = "Ви в стосунках?";
            // 
            // description_clientLabel
            // 
            description_clientLabel.AutoSize = true;
            description_clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            description_clientLabel.Location = new System.Drawing.Point(139, 483);
            description_clientLabel.Name = "description_clientLabel";
            description_clientLabel.Size = new System.Drawing.Size(250, 29);
            description_clientLabel.TabIndex = 20;
            description_clientLabel.Text = "Розкажіть про себе:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(139, 373);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(97, 29);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Пошта:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ageLabel.Location = new System.Drawing.Point(139, 263);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(56, 29);
            ageLabel.TabIndex = 24;
            ageLabel.Text = "Вік:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phone_numberLabel.Location = new System.Drawing.Point(139, 428);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(220, 29);
            phone_numberLabel.TabIndex = 26;
            phone_numberLabel.Text = "Номер телефону:";
            // 
            // passwLabel
            // 
            passwLabel.AutoSize = true;
            passwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwLabel.Location = new System.Drawing.Point(139, 537);
            passwLabel.Name = "passwLabel";
            passwLabel.Size = new System.Drawing.Size(107, 29);
            passwLabel.TabIndex = 39;
            passwLabel.Text = "Пароль:";
            // 
            // regFormLabel
            // 
            this.regFormLabel.AutoSize = true;
            this.regFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regFormLabel.Location = new System.Drawing.Point(338, 40);
            this.regFormLabel.Name = "regFormLabel";
            this.regFormLabel.Size = new System.Drawing.Size(375, 76);
            this.regFormLabel.TabIndex = 28;
            this.regFormLabel.Text = "Реєстрація";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.loginFormLabel);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 139);
            this.panel1.TabIndex = 31;
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
            // loginFormLabel
            // 
            this.loginFormLabel.AutoSize = true;
            this.loginFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginFormLabel.Location = new System.Drawing.Point(270, 31);
            this.loginFormLabel.Name = "loginFormLabel";
            this.loginFormLabel.Size = new System.Drawing.Size(375, 76);
            this.loginFormLabel.TabIndex = 7;
            this.loginFormLabel.Text = "Реєстрація";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(306, 587);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(283, 52);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Створити акаунт";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dating_app_baseDataSet;
            // 
            // dating_app_baseDataSet
            // 
            this.dating_app_baseDataSet.DataSetName = "Dating_app_baseDataSet";
            this.dating_app_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Chat_messageTableAdapter = null;
            this.tableAdapterManager.ChatTableAdapter = null;
            this.tableAdapterManager.Client_chatTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.Dating_historyTableAdapter = null;
            this.tableAdapterManager.InterestTableAdapter = null;
            this.tableAdapterManager.PhotoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dating_app.Dating_app_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(408, 159);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(316, 34);
            this.nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(408, 373);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(316, 34);
            this.emailTextBox.TabIndex = 35;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(408, 428);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(316, 34);
            this.phoneTextBox.TabIndex = 36;
            // 
            // descrTextBox
            // 
            this.descrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descrTextBox.Location = new System.Drawing.Point(408, 483);
            this.descrTextBox.Name = "descrTextBox";
            this.descrTextBox.Size = new System.Drawing.Size(316, 34);
            this.descrTextBox.TabIndex = 37;
            // 
            // maritalCheckBox
            // 
            this.maritalCheckBox.AutoSize = true;
            this.maritalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maritalCheckBox.Location = new System.Drawing.Point(408, 320);
            this.maritalCheckBox.Name = "maritalCheckBox";
            this.maritalCheckBox.Size = new System.Drawing.Size(76, 33);
            this.maritalCheckBox.TabIndex = 38;
            this.maritalCheckBox.Text = "Так";
            this.maritalCheckBox.UseVisualStyleBackColor = true;
            // 
            // pswdTextBox
            // 
            this.pswdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswdTextBox.Location = new System.Drawing.Point(408, 537);
            this.pswdTextBox.Name = "pswdTextBox";
            this.pswdTextBox.Size = new System.Drawing.Size(316, 34);
            this.pswdTextBox.TabIndex = 40;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // sexErrorProvider
            // 
            this.sexErrorProvider.ContainerControl = this;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // pswdErrorProvider
            // 
            this.pswdErrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dating_app.Properties.Resources.Icon2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oSexRadioButton);
            this.groupBox1.Controls.Add(this.mSexRadioButton);
            this.groupBox1.Controls.Add(this.wSexRadioButton);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(401, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 49);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // oSexRadioButton
            // 
            this.oSexRadioButton.AutoSize = true;
            this.oSexRadioButton.Checked = true;
            this.oSexRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oSexRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oSexRadioButton.Location = new System.Drawing.Point(244, 10);
            this.oSexRadioButton.Name = "oSexRadioButton";
            this.oSexRadioButton.Size = new System.Drawing.Size(88, 33);
            this.oSexRadioButton.TabIndex = 62;
            this.oSexRadioButton.TabStop = true;
            this.oSexRadioButton.Text = "Інша";
            this.oSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // mSexRadioButton
            // 
            this.mSexRadioButton.AutoSize = true;
            this.mSexRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mSexRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mSexRadioButton.Location = new System.Drawing.Point(6, 10);
            this.mSexRadioButton.Name = "mSexRadioButton";
            this.mSexRadioButton.Size = new System.Drawing.Size(125, 33);
            this.mSexRadioButton.TabIndex = 60;
            this.mSexRadioButton.Text = "Чоловік";
            this.mSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // wSexRadioButton
            // 
            this.wSexRadioButton.AutoSize = true;
            this.wSexRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wSexRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wSexRadioButton.Location = new System.Drawing.Point(137, 10);
            this.wSexRadioButton.Name = "wSexRadioButton";
            this.wSexRadioButton.Size = new System.Drawing.Size(101, 33);
            this.wSexRadioButton.TabIndex = 61;
            this.wSexRadioButton.Text = "Жінка";
            this.wSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // eyePictureBox
            // 
            this.eyePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyePictureBox.Image = global::Dating_app.Properties.Resources.eye11;
            this.eyePictureBox.Location = new System.Drawing.Point(730, 537);
            this.eyePictureBox.Name = "eyePictureBox";
            this.eyePictureBox.Size = new System.Drawing.Size(44, 34);
            this.eyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyePictureBox.TabIndex = 65;
            this.eyePictureBox.TabStop = false;
            this.eyePictureBox.Click += new System.EventHandler(this.eyePictureBox_Click);
            // 
            // interestTableAdapter
            // 
            this.interestTableAdapter.ClearBeforeFill = true;
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageNumericUpDown.Location = new System.Drawing.Point(408, 265);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            149,
            0,
            0,
            0});
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.ageNumericUpDown.TabIndex = 66;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // photoTableAdapter
            // 
            this.photoTableAdapter.ClearBeforeFill = true;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(896, 667);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.eyePictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pswdTextBox);
            this.Controls.Add(passwLabel);
            this.Controls.Add(this.maritalCheckBox);
            this.Controls.Add(this.descrTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regFormLabel);
            this.Controls.Add(client_nameLabel);
            this.Controls.Add(sexLabel);
            this.Controls.Add(marital_statusLabel);
            this.Controls.Add(description_clientLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(ageLabel);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(914, 714);
            this.MinimumSize = new System.Drawing.Size(914, 714);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dating_app_baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pswdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Dating_app_baseDataSet dating_app_baseDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Dating_app_baseDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private Dating_app_baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label regFormLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loginFormLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox descrTextBox;
        private System.Windows.Forms.CheckBox maritalCheckBox;
        private System.Windows.Forms.TextBox pswdTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider sexErrorProvider;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        private System.Windows.Forms.ErrorProvider pswdErrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton oSexRadioButton;
        private System.Windows.Forms.RadioButton mSexRadioButton;
        private System.Windows.Forms.RadioButton wSexRadioButton;
        private System.Windows.Forms.PictureBox eyePictureBox;
        private Dating_app_baseDataSetTableAdapters.InterestTableAdapter interestTableAdapter;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private Dating_app_baseDataSetTableAdapters.PhotoTableAdapter photoTableAdapter;
    }
}