namespace Mail_Box
{
    partial class Register
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
            this.password2_TB = new System.Windows.Forms.TextBox();
            this.name_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fname_TB = new System.Windows.Forms.TextBox();
            this.register_b = new System.Windows.Forms.Button();
            this.back_b = new System.Windows.Forms.Button();
            this.exir_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_TB
            // 
            this.username_TB.Location = new System.Drawing.Point(151, 41);
            this.username_TB.Name = "username_TB";
            this.username_TB.Size = new System.Drawing.Size(174, 20);
            this.username_TB.TabIndex = 0;
            // 
            // password_TB
            // 
            this.password_TB.Location = new System.Drawing.Point(151, 87);
            this.password_TB.Name = "password_TB";
            this.password_TB.PasswordChar = '*';
            this.password_TB.Size = new System.Drawing.Size(174, 20);
            this.password_TB.TabIndex = 1;
            // 
            // password2_TB
            // 
            this.password2_TB.Location = new System.Drawing.Point(151, 130);
            this.password2_TB.Name = "password2_TB";
            this.password2_TB.PasswordChar = '*';
            this.password2_TB.Size = new System.Drawing.Size(174, 20);
            this.password2_TB.TabIndex = 2;
            // 
            // name_TB
            // 
            this.name_TB.Location = new System.Drawing.Point(151, 178);
            this.name_TB.Name = "name_TB";
            this.name_TB.Size = new System.Drawing.Size(174, 20);
            this.name_TB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your registration info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "*Password Confirmation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "*Family Name:";
            // 
            // fname_TB
            // 
            this.fname_TB.Location = new System.Drawing.Point(151, 221);
            this.fname_TB.Name = "fname_TB";
            this.fname_TB.Size = new System.Drawing.Size(174, 20);
            this.fname_TB.TabIndex = 10;
            // 
            // register_b
            // 
            this.register_b.Location = new System.Drawing.Point(265, 274);
            this.register_b.Name = "register_b";
            this.register_b.Size = new System.Drawing.Size(75, 23);
            this.register_b.TabIndex = 11;
            this.register_b.Text = "Register";
            this.register_b.UseVisualStyleBackColor = true;
            this.register_b.Click += new System.EventHandler(this.register_b_Click);
            // 
            // back_b
            // 
            this.back_b.Location = new System.Drawing.Point(120, 274);
            this.back_b.Name = "back_b";
            this.back_b.Size = new System.Drawing.Size(75, 23);
            this.back_b.TabIndex = 12;
            this.back_b.Text = "back";
            this.back_b.UseVisualStyleBackColor = true;
            this.back_b.Click += new System.EventHandler(this.back_b_Click);
            // 
            // exir_B
            // 
            this.exir_B.Location = new System.Drawing.Point(39, 274);
            this.exir_B.Name = "exir_B";
            this.exir_B.Size = new System.Drawing.Size(75, 23);
            this.exir_B.TabIndex = 13;
            this.exir_B.Text = "Exit";
            this.exir_B.UseVisualStyleBackColor = true;
            this.exir_B.Click += new System.EventHandler(this.exir_B_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 324);
            this.Controls.Add(this.exir_B);
            this.Controls.Add(this.back_b);
            this.Controls.Add(this.register_b);
            this.Controls.Add(this.fname_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_TB);
            this.Controls.Add(this.password2_TB);
            this.Controls.Add(this.password_TB);
            this.Controls.Add(this.username_TB);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_TB;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.TextBox password2_TB;
        private System.Windows.Forms.TextBox name_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fname_TB;
        private System.Windows.Forms.Button register_b;
        private System.Windows.Forms.Button back_b;
        private System.Windows.Forms.Button exir_B;
    }
}