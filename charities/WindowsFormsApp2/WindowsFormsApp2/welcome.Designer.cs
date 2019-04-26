namespace WindowsFormsApp2
{
    partial class welcome
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
            this.signUpAsVolunteer = new System.Windows.Forms.Button();
            this.signUpAsDonor = new System.Windows.Forms.Button();
            this.signUpAsSponsor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "sign in ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signUpAsVolunteer
            // 
            this.signUpAsVolunteer.Location = new System.Drawing.Point(75, 148);
            this.signUpAsVolunteer.Name = "signUpAsVolunteer";
            this.signUpAsVolunteer.Size = new System.Drawing.Size(125, 23);
            this.signUpAsVolunteer.TabIndex = 1;
            this.signUpAsVolunteer.Text = "Sign Up As Volunteer";
            this.signUpAsVolunteer.UseVisualStyleBackColor = true;
            this.signUpAsVolunteer.Click += new System.EventHandler(this.button2_Click);
            // 
            // signUpAsDonor
            // 
            this.signUpAsDonor.Location = new System.Drawing.Point(75, 106);
            this.signUpAsDonor.Name = "signUpAsDonor";
            this.signUpAsDonor.Size = new System.Drawing.Size(125, 23);
            this.signUpAsDonor.TabIndex = 2;
            this.signUpAsDonor.Text = "Sign Up As Donor";
            this.signUpAsDonor.UseVisualStyleBackColor = true;
            this.signUpAsDonor.Click += new System.EventHandler(this.button3_Click);
            // 
            // signUpAsSponsor
            // 
            this.signUpAsSponsor.Location = new System.Drawing.Point(75, 194);
            this.signUpAsSponsor.Name = "signUpAsSponsor";
            this.signUpAsSponsor.Size = new System.Drawing.Size(125, 23);
            this.signUpAsSponsor.TabIndex = 3;
            this.signUpAsSponsor.Text = "Sign Up As Sponsor";
            this.signUpAsSponsor.UseVisualStyleBackColor = true;
            this.signUpAsSponsor.Click += new System.EventHandler(this.signUpAsSponsor_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.goodone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.signUpAsSponsor);
            this.Controls.Add(this.signUpAsDonor);
            this.Controls.Add(this.signUpAsVolunteer);
            this.Controls.Add(this.button1);
            this.Name = "welcome";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button signUpAsVolunteer;
        private System.Windows.Forms.Button signUpAsDonor;
        private System.Windows.Forms.Button signUpAsSponsor;
    }
}