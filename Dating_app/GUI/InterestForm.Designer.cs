namespace Dating_app
{
    partial class InterestForm
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
            System.Windows.Forms.Label sexLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.interestLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ageMinLabel = new System.Windows.Forms.Label();
            this.ageMaxLabel = new System.Windows.Forms.Label();
            this.ageMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oSexRadioButton = new System.Windows.Forms.RadioButton();
            this.mSexRadioButton = new System.Windows.Forms.RadioButton();
            this.wSexRadioButton = new System.Windows.Forms.RadioButton();
            this.minAgeCheckBox = new System.Windows.Forms.CheckBox();
            this.maxAgeCheckBox = new System.Windows.Forms.CheckBox();
            this.sexСheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.interestTableAdapter = new Dating_app.Dating_app_baseDataSetTableAdapters.InterestTableAdapter();
            this.ageErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            sexLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMaxNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sexLabel.Location = new System.Drawing.Point(150, 287);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(87, 29);
            sexLabel.TabIndex = 64;
            sexLabel.Text = "Стать:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.interestLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 139);
            this.panel1.TabIndex = 33;
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interestLabel.Location = new System.Drawing.Point(235, 31);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(434, 76);
            this.interestLabel.TabIndex = 9;
            this.interestLabel.Text = "Мої інтереси";
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
            // ageMinLabel
            // 
            this.ageMinLabel.AutoSize = true;
            this.ageMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageMinLabel.Location = new System.Drawing.Point(150, 180);
            this.ageMinLabel.Name = "ageMinLabel";
            this.ageMinLabel.Size = new System.Drawing.Size(207, 29);
            this.ageMinLabel.TabIndex = 34;
            this.ageMinLabel.Text = "Мінімальний вік:";
            // 
            // ageMaxLabel
            // 
            this.ageMaxLabel.AutoSize = true;
            this.ageMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageMaxLabel.Location = new System.Drawing.Point(150, 236);
            this.ageMaxLabel.Name = "ageMaxLabel";
            this.ageMaxLabel.Size = new System.Drawing.Size(232, 29);
            this.ageMaxLabel.TabIndex = 35;
            this.ageMaxLabel.Text = "Максимальний вік:";
            // 
            // ageMinNumericUpDown
            // 
            this.ageMinNumericUpDown.Enabled = false;
            this.ageMinNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageMinNumericUpDown.Location = new System.Drawing.Point(388, 181);
            this.ageMinNumericUpDown.Maximum = new decimal(new int[] {
            149,
            0,
            0,
            0});
            this.ageMinNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageMinNumericUpDown.Name = "ageMinNumericUpDown";
            this.ageMinNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.ageMinNumericUpDown.TabIndex = 36;
            this.ageMinNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageMinNumericUpDown.Leave += new System.EventHandler(this.ageMinNumericUpDown_Leave);
            // 
            // ageMaxNumericUpDown
            // 
            this.ageMaxNumericUpDown.Enabled = false;
            this.ageMaxNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageMaxNumericUpDown.Location = new System.Drawing.Point(388, 237);
            this.ageMaxNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageMaxNumericUpDown.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.ageMaxNumericUpDown.Name = "ageMaxNumericUpDown";
            this.ageMaxNumericUpDown.Size = new System.Drawing.Size(120, 30);
            this.ageMaxNumericUpDown.TabIndex = 37;
            this.ageMaxNumericUpDown.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.ageMaxNumericUpDown.Leave += new System.EventHandler(this.ageMaxNumericUpDown_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oSexRadioButton);
            this.groupBox1.Controls.Add(this.mSexRadioButton);
            this.groupBox1.Controls.Add(this.wSexRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(256, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 49);
            this.groupBox1.TabIndex = 65;
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
            // minAgeCheckBox
            // 
            this.minAgeCheckBox.AutoSize = true;
            this.minAgeCheckBox.Checked = true;
            this.minAgeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minAgeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minAgeCheckBox.Location = new System.Drawing.Point(543, 188);
            this.minAgeCheckBox.Name = "minAgeCheckBox";
            this.minAgeCheckBox.Size = new System.Drawing.Size(103, 24);
            this.minAgeCheckBox.TabIndex = 66;
            this.minAgeCheckBox.Text = "байдуже";
            this.minAgeCheckBox.UseVisualStyleBackColor = true;
            this.minAgeCheckBox.CheckedChanged += new System.EventHandler(this.minAgeCheckBox_CheckedChanged);
            // 
            // maxAgeCheckBox
            // 
            this.maxAgeCheckBox.AutoSize = true;
            this.maxAgeCheckBox.Checked = true;
            this.maxAgeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.maxAgeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxAgeCheckBox.Location = new System.Drawing.Point(543, 243);
            this.maxAgeCheckBox.Name = "maxAgeCheckBox";
            this.maxAgeCheckBox.Size = new System.Drawing.Size(103, 24);
            this.maxAgeCheckBox.TabIndex = 67;
            this.maxAgeCheckBox.Text = "байдуже";
            this.maxAgeCheckBox.UseVisualStyleBackColor = true;
            this.maxAgeCheckBox.CheckedChanged += new System.EventHandler(this.maxAgeCheckBox_CheckedChanged);
            // 
            // sexСheckBox
            // 
            this.sexСheckBox.AutoSize = true;
            this.sexСheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexСheckBox.Location = new System.Drawing.Point(594, 291);
            this.sexСheckBox.Name = "sexСheckBox";
            this.sexСheckBox.Size = new System.Drawing.Size(103, 24);
            this.sexСheckBox.TabIndex = 68;
            this.sexСheckBox.Text = "байдуже";
            this.sexСheckBox.UseVisualStyleBackColor = true;
            this.sexСheckBox.CheckedChanged += new System.EventHandler(this.sexСheckBox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(155, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(192, 50);
            this.exitButton.TabIndex = 69;
            this.exitButton.Text = "Повернутися";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(484, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 50);
            this.saveButton.TabIndex = 70;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // interestTableAdapter
            // 
            this.interestTableAdapter.ClearBeforeFill = true;
            // 
            // ageErrorProvider
            // 
            this.ageErrorProvider.ContainerControl = this;
            // 
            // InterestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sexСheckBox);
            this.Controls.Add(this.maxAgeCheckBox);
            this.Controls.Add(this.minAgeCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.ageMaxNumericUpDown);
            this.Controls.Add(this.ageMinNumericUpDown);
            this.Controls.Add(this.ageMaxLabel);
            this.Controls.Add(this.ageMinLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "InterestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мої інтереси";
            this.Load += new System.EventHandler(this.InterestForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMaxNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label ageMinLabel;
        private System.Windows.Forms.Label ageMaxLabel;
        private System.Windows.Forms.NumericUpDown ageMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown ageMaxNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton oSexRadioButton;
        private System.Windows.Forms.RadioButton mSexRadioButton;
        private System.Windows.Forms.RadioButton wSexRadioButton;
        private System.Windows.Forms.CheckBox minAgeCheckBox;
        private System.Windows.Forms.CheckBox maxAgeCheckBox;
        private System.Windows.Forms.CheckBox sexСheckBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private Dating_app_baseDataSetTableAdapters.InterestTableAdapter interestTableAdapter;
        private System.Windows.Forms.ErrorProvider ageErrorProvider;
    }
}