namespace Mail_Box
{
    partial class Main
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
            this.Logout_B = new System.Windows.Forms.Button();
            this.Inbox_B = new System.Windows.Forms.Button();
            this.Sent_B = new System.Windows.Forms.Button();
            this.inTrash_B = new System.Windows.Forms.Button();
            this.seTrash_B = new System.Windows.Forms.Button();
            this.Compose_B = new System.Windows.Forms.Button();
            this.Welcome_L = new System.Windows.Forms.Label();
            this.exit_b = new System.Windows.Forms.Button();
            this.allMessages_B = new System.Windows.Forms.Button();
            this.allUsers_B = new System.Windows.Forms.Button();
            this.profile_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logout_B
            // 
            this.Logout_B.Location = new System.Drawing.Point(310, 227);
            this.Logout_B.Name = "Logout_B";
            this.Logout_B.Size = new System.Drawing.Size(75, 23);
            this.Logout_B.TabIndex = 0;
            this.Logout_B.Text = "Logout";
            this.Logout_B.UseVisualStyleBackColor = true;
            this.Logout_B.Click += new System.EventHandler(this.Logout_B_Click);
            // 
            // Inbox_B
            // 
            this.Inbox_B.Location = new System.Drawing.Point(12, 12);
            this.Inbox_B.Name = "Inbox_B";
            this.Inbox_B.Size = new System.Drawing.Size(90, 23);
            this.Inbox_B.TabIndex = 1;
            this.Inbox_B.Text = "Inbox";
            this.Inbox_B.UseVisualStyleBackColor = true;
            this.Inbox_B.Click += new System.EventHandler(this.Inbox_B_Click);
            // 
            // Sent_B
            // 
            this.Sent_B.Location = new System.Drawing.Point(12, 41);
            this.Sent_B.Name = "Sent_B";
            this.Sent_B.Size = new System.Drawing.Size(90, 23);
            this.Sent_B.TabIndex = 2;
            this.Sent_B.Text = "Sent";
            this.Sent_B.UseVisualStyleBackColor = true;
            this.Sent_B.Click += new System.EventHandler(this.Sent_B_Click);
            // 
            // inTrash_B
            // 
            this.inTrash_B.Location = new System.Drawing.Point(12, 70);
            this.inTrash_B.Name = "inTrash_B";
            this.inTrash_B.Size = new System.Drawing.Size(90, 23);
            this.inTrash_B.TabIndex = 3;
            this.inTrash_B.Text = "Inbox Trash";
            this.inTrash_B.UseVisualStyleBackColor = true;
            this.inTrash_B.Click += new System.EventHandler(this.inTrash_B_Click);
            // 
            // seTrash_B
            // 
            this.seTrash_B.Location = new System.Drawing.Point(12, 99);
            this.seTrash_B.Name = "seTrash_B";
            this.seTrash_B.Size = new System.Drawing.Size(90, 23);
            this.seTrash_B.TabIndex = 4;
            this.seTrash_B.Text = "Sent Trash";
            this.seTrash_B.UseVisualStyleBackColor = true;
            this.seTrash_B.Click += new System.EventHandler(this.seTrash_B_Click);
            // 
            // Compose_B
            // 
            this.Compose_B.Location = new System.Drawing.Point(12, 128);
            this.Compose_B.Name = "Compose_B";
            this.Compose_B.Size = new System.Drawing.Size(90, 23);
            this.Compose_B.TabIndex = 5;
            this.Compose_B.Text = "Send Message";
            this.Compose_B.UseVisualStyleBackColor = true;
            this.Compose_B.Click += new System.EventHandler(this.Compose_B_Click);
            // 
            // Welcome_L
            // 
            this.Welcome_L.AutoSize = true;
            this.Welcome_L.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_L.Location = new System.Drawing.Point(146, 22);
            this.Welcome_L.Name = "Welcome_L";
            this.Welcome_L.Size = new System.Drawing.Size(0, 24);
            this.Welcome_L.TabIndex = 6;
            // 
            // exit_b
            // 
            this.exit_b.Location = new System.Drawing.Point(229, 227);
            this.exit_b.Name = "exit_b";
            this.exit_b.Size = new System.Drawing.Size(75, 23);
            this.exit_b.TabIndex = 7;
            this.exit_b.Text = "Exit";
            this.exit_b.UseVisualStyleBackColor = true;
            this.exit_b.Click += new System.EventHandler(this.exit_b_Click);
            // 
            // allMessages_B
            // 
            this.allMessages_B.Location = new System.Drawing.Point(12, 186);
            this.allMessages_B.Name = "allMessages_B";
            this.allMessages_B.Size = new System.Drawing.Size(90, 23);
            this.allMessages_B.TabIndex = 8;
            this.allMessages_B.Text = "All Messages";
            this.allMessages_B.UseVisualStyleBackColor = true;
            this.allMessages_B.Visible = false;
            this.allMessages_B.Click += new System.EventHandler(this.allMessages_B_Click);
            // 
            // allUsers_B
            // 
            this.allUsers_B.Location = new System.Drawing.Point(12, 215);
            this.allUsers_B.Name = "allUsers_B";
            this.allUsers_B.Size = new System.Drawing.Size(90, 23);
            this.allUsers_B.TabIndex = 9;
            this.allUsers_B.Text = "All Users";
            this.allUsers_B.UseVisualStyleBackColor = true;
            this.allUsers_B.Visible = false;
            this.allUsers_B.Click += new System.EventHandler(this.allUsers_B_Click);
            // 
            // profile_B
            // 
            this.profile_B.Location = new System.Drawing.Point(12, 157);
            this.profile_B.Name = "profile_B";
            this.profile_B.Size = new System.Drawing.Size(90, 23);
            this.profile_B.TabIndex = 10;
            this.profile_B.Text = "Edit Profile";
            this.profile_B.UseVisualStyleBackColor = true;
            this.profile_B.Click += new System.EventHandler(this.profile_B_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.profile_B);
            this.Controls.Add(this.allUsers_B);
            this.Controls.Add(this.allMessages_B);
            this.Controls.Add(this.exit_b);
            this.Controls.Add(this.Welcome_L);
            this.Controls.Add(this.Compose_B);
            this.Controls.Add(this.seTrash_B);
            this.Controls.Add(this.inTrash_B);
            this.Controls.Add(this.Sent_B);
            this.Controls.Add(this.Inbox_B);
            this.Controls.Add(this.Logout_B);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_B;
        private System.Windows.Forms.Button Inbox_B;
        private System.Windows.Forms.Button Sent_B;
        private System.Windows.Forms.Button inTrash_B;
        private System.Windows.Forms.Button seTrash_B;
        private System.Windows.Forms.Button Compose_B;
        private System.Windows.Forms.Label Welcome_L;
        private System.Windows.Forms.Button exit_b;
        private System.Windows.Forms.Button allMessages_B;
        private System.Windows.Forms.Button allUsers_B;
        private System.Windows.Forms.Button profile_B;
    }
}