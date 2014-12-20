namespace Mail_Box
{
    partial class Login
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
            this.username_TB = new System.Windows.Forms.TextBox();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_b = new System.Windows.Forms.Button();
            this.register_b = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fpass_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_TB
            // 
            this.username_TB.Location = new System.Drawing.Point(106, 63);
            this.username_TB.Name = "username_TB";
            this.username_TB.Size = new System.Drawing.Size(166, 20);
            this.username_TB.TabIndex = 0;
            // 
            // password_TB
            // 
            this.password_TB.Location = new System.Drawing.Point(106, 98);
            this.password_TB.Name = "password_TB";
            this.password_TB.PasswordChar = '*';
            this.password_TB.Size = new System.Drawing.Size(166, 20);
            this.password_TB.TabIndex = 1;
            this.password_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_TB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Username and Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // login_b
            // 
            this.login_b.Location = new System.Drawing.Point(176, 141);
            this.login_b.Name = "login_b";
            this.login_b.Size = new System.Drawing.Size(75, 23);
            this.login_b.TabIndex = 5;
            this.login_b.Text = "Login";
            this.login_b.UseVisualStyleBackColor = true;
            this.login_b.Click += new System.EventHandler(this.login_b_Click);
            // 
            // register_b
            // 
            this.register_b.Location = new System.Drawing.Point(176, 187);
            this.register_b.Name = "register_b";
            this.register_b.Size = new System.Drawing.Size(75, 23);
            this.register_b.TabIndex = 6;
            this.register_b.Text = "Register";
            this.register_b.UseVisualStyleBackColor = true;
            this.register_b.Click += new System.EventHandler(this.register_b_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(27, 187);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(75, 23);
            this.Exit_B.TabIndex = 7;
            this.Exit_B.Text = "Exit";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Copyright © 2015 Soheil Salehinia";
            // 
            // fpass_B
            // 
            this.fpass_B.Location = new System.Drawing.Point(95, 141);
            this.fpass_B.Name = "fpass_B";
            this.fpass_B.Size = new System.Drawing.Size(75, 23);
            this.fpass_B.TabIndex = 9;
            this.fpass_B.Text = "Forgot pass";
            this.fpass_B.UseVisualStyleBackColor = true;
            this.fpass_B.Click += new System.EventHandler(this.fpass_B_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.fpass_B);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.register_b);
            this.Controls.Add(this.login_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_TB);
            this.Controls.Add(this.username_TB);
            this.Name = "Login";
            this.Text = "Soli Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_TB;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_b;
        private System.Windows.Forms.Button register_b;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fpass_B;
    }
}

