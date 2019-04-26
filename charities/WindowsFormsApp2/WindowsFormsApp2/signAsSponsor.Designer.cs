namespace WindowsFormsApp2
{
    partial class signAsSponsor
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
            this.button1 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.TextBox();
            this.studyStage = new System.Windows.Forms.ComboBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.address = new System.Windows.Forms.TextBox();
            this.ssn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.maleradioButton = new System.Windows.Forms.RadioButton();
            this.marriageStatus = new System.Windows.Forms.ComboBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.orgName = new System.Windows.Forms.TextBox();
            this.logoCode = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(396, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(135, 331);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 47;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(135, 297);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(100, 20);
            this.phoneNumber.TabIndex = 45;
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(135, 267);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(100, 20);
            this.job.TabIndex = 44;
            // 
            // studyStage
            // 
            this.studyStage.FormattingEnabled = true;
            this.studyStage.Location = new System.Drawing.Point(135, 234);
            this.studyStage.Name = "studyStage";
            this.studyStage.Size = new System.Drawing.Size(121, 21);
            this.studyStage.TabIndex = 43;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(135, 197);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 42;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(135, 157);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 41;
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(135, 129);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(100, 20);
            this.ssn.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.maleradioButton);
            this.groupBox1.Location = new System.Drawing.Point(315, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 48);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // maleradioButton
            // 
            this.maleradioButton.AutoSize = true;
            this.maleradioButton.Location = new System.Drawing.Point(6, 19);
            this.maleradioButton.Name = "maleradioButton";
            this.maleradioButton.Size = new System.Drawing.Size(48, 17);
            this.maleradioButton.TabIndex = 0;
            this.maleradioButton.TabStop = true;
            this.maleradioButton.Text = "Male";
            this.maleradioButton.UseVisualStyleBackColor = true;
            // 
            // marriageStatus
            // 
            this.marriageStatus.FormattingEnabled = true;
            this.marriageStatus.Location = new System.Drawing.Point(135, 93);
            this.marriageStatus.Name = "marriageStatus";
            this.marriageStatus.Size = new System.Drawing.Size(121, 21);
            this.marriageStatus.TabIndex = 38;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(135, 56);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 37;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(135, 26);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(12, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Study Stage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(12, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Marriage Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(13, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Job";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "E_Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Social Security Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(16, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Organization Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(18, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Logo Code";
            // 
            // orgName
            // 
            this.orgName.Location = new System.Drawing.Point(135, 391);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(100, 20);
            this.orgName.TabIndex = 51;
            // 
            // logoCode
            // 
            this.logoCode.Location = new System.Drawing.Point(135, 419);
            this.logoCode.Name = "logoCode";
            this.logoCode.Size = new System.Drawing.Size(100, 20);
            this.logoCode.TabIndex = 52;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(135, 365);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(16, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "age";
            // 
            // signAsSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.goodone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.logoCode);
            this.Controls.Add(this.orgName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.job);
            this.Controls.Add(this.studyStage);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.address);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.marriageStatus);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signAsSponsor";
            this.Text = "v";
            this.Load += new System.EventHandler(this.signAsSponsor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.ComboBox studyStage;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton maleradioButton;
        private System.Windows.Forms.ComboBox marriageStatus;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox orgName;
        private System.Windows.Forms.TextBox logoCode;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label12;
    }
}