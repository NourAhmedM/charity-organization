namespace WindowsFormsApp2
{
    partial class resumeSignUp
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
            this.userName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(156, 59);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(36, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "User Name";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(154, 120);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 30;
            this.password.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(36, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resumeSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.goodone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label11);
            this.Name = "resumeSignUp";
            this.Text = "resumeSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;

    }
}