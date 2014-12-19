namespace Mail_Box
{
    partial class Compose
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
            this.subject_TB = new System.Windows.Forms.TextBox();
            this.sendto_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Message_RTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Attach1_B = new System.Windows.Forms.Button();
            this.Attach2_B = new System.Windows.Forms.Button();
            this.Attach3_B = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.des1_TB = new System.Windows.Forms.TextBox();
            this.des2_TB = new System.Windows.Forms.TextBox();
            this.des3_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back_B = new System.Windows.Forms.Button();
            this.Logout_B = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.result1_L = new System.Windows.Forms.Label();
            this.result2_L = new System.Windows.Forms.Label();
            this.result3_L = new System.Windows.Forms.Label();
            this.send_B = new System.Windows.Forms.Button();
            this.exit_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subject_TB
            // 
            this.subject_TB.Location = new System.Drawing.Point(417, 42);
            this.subject_TB.Name = "subject_TB";
            this.subject_TB.Size = new System.Drawing.Size(185, 20);
            this.subject_TB.TabIndex = 1;
            // 
            // sendto_CB
            // 
            this.sendto_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sendto_CB.FormattingEnabled = true;
            this.sendto_CB.Location = new System.Drawing.Point(417, 7);
            this.sendto_CB.Name = "sendto_CB";
            this.sendto_CB.Size = new System.Drawing.Size(185, 21);
            this.sendto_CB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Send to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // Message_RTB
            // 
            this.Message_RTB.Location = new System.Drawing.Point(92, 80);
            this.Message_RTB.Name = "Message_RTB";
            this.Message_RTB.Size = new System.Drawing.Size(510, 156);
            this.Message_RTB.TabIndex = 4;
            this.Message_RTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // Attach1_B
            // 
            this.Attach1_B.Location = new System.Drawing.Point(15, 267);
            this.Attach1_B.Name = "Attach1_B";
            this.Attach1_B.Size = new System.Drawing.Size(75, 23);
            this.Attach1_B.TabIndex = 6;
            this.Attach1_B.Text = "Attachment1";
            this.Attach1_B.UseVisualStyleBackColor = true;
            this.Attach1_B.Click += new System.EventHandler(this.Attach1_B_Click);
            // 
            // Attach2_B
            // 
            this.Attach2_B.Location = new System.Drawing.Point(15, 342);
            this.Attach2_B.Name = "Attach2_B";
            this.Attach2_B.Size = new System.Drawing.Size(75, 23);
            this.Attach2_B.TabIndex = 8;
            this.Attach2_B.Text = "Attachment2";
            this.Attach2_B.UseVisualStyleBackColor = true;
            this.Attach2_B.Click += new System.EventHandler(this.Attach2_B_Click);
            // 
            // Attach3_B
            // 
            this.Attach3_B.Location = new System.Drawing.Point(15, 414);
            this.Attach3_B.Name = "Attach3_B";
            this.Attach3_B.Size = new System.Drawing.Size(75, 23);
            this.Attach3_B.TabIndex = 10;
            this.Attach3_B.Text = "Attachment3";
            this.Attach3_B.UseVisualStyleBackColor = true;
            this.Attach3_B.Click += new System.EventHandler(this.Attach3_B_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Attachments";
            // 
            // des1_TB
            // 
            this.des1_TB.Location = new System.Drawing.Point(116, 269);
            this.des1_TB.Name = "des1_TB";
            this.des1_TB.Size = new System.Drawing.Size(486, 20);
            this.des1_TB.TabIndex = 7;
            // 
            // des2_TB
            // 
            this.des2_TB.Location = new System.Drawing.Point(116, 345);
            this.des2_TB.Name = "des2_TB";
            this.des2_TB.Size = new System.Drawing.Size(486, 20);
            this.des2_TB.TabIndex = 9;
            // 
            // des3_TB
            // 
            this.des3_TB.Location = new System.Drawing.Point(116, 417);
            this.des3_TB.Name = "des3_TB";
            this.des3_TB.Size = new System.Drawing.Size(486, 20);
            this.des3_TB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descriptions";
            // 
            // back_B
            // 
            this.back_B.Location = new System.Drawing.Point(446, 500);
            this.back_B.Name = "back_B";
            this.back_B.Size = new System.Drawing.Size(75, 23);
            this.back_B.TabIndex = 14;
            this.back_B.Text = "back";
            this.back_B.UseVisualStyleBackColor = true;
            this.back_B.Click += new System.EventHandler(this.back_B_Click);
            // 
            // Logout_B
            // 
            this.Logout_B.Location = new System.Drawing.Point(527, 500);
            this.Logout_B.Name = "Logout_B";
            this.Logout_B.Size = new System.Drawing.Size(75, 23);
            this.Logout_B.TabIndex = 15;
            this.Logout_B.Text = "logout";
            this.Logout_B.UseVisualStyleBackColor = true;
            this.Logout_B.Click += new System.EventHandler(this.Logout_B_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog1";
            // 
            // result1_L
            // 
            this.result1_L.AutoSize = true;
            this.result1_L.Location = new System.Drawing.Point(25, 309);
            this.result1_L.Name = "result1_L";
            this.result1_L.Size = new System.Drawing.Size(0, 13);
            this.result1_L.TabIndex = 16;
            // 
            // result2_L
            // 
            this.result2_L.AutoSize = true;
            this.result2_L.Location = new System.Drawing.Point(25, 383);
            this.result2_L.Name = "result2_L";
            this.result2_L.Size = new System.Drawing.Size(0, 13);
            this.result2_L.TabIndex = 17;
            // 
            // result3_L
            // 
            this.result3_L.AutoSize = true;
            this.result3_L.Location = new System.Drawing.Point(25, 459);
            this.result3_L.Name = "result3_L";
            this.result3_L.Size = new System.Drawing.Size(0, 13);
            this.result3_L.TabIndex = 18;
            // 
            // send_B
            // 
            this.send_B.Location = new System.Drawing.Point(92, 35);
            this.send_B.Name = "send_B";
            this.send_B.Size = new System.Drawing.Size(75, 23);
            this.send_B.TabIndex = 19;
            this.send_B.Text = "Send";
            this.send_B.UseVisualStyleBackColor = true;
            this.send_B.Click += new System.EventHandler(this.send_B_Click);
            // 
            // exit_B
            // 
            this.exit_B.Location = new System.Drawing.Point(365, 500);
            this.exit_B.Name = "exit_B";
            this.exit_B.Size = new System.Drawing.Size(75, 23);
            this.exit_B.TabIndex = 20;
            this.exit_B.Text = "Exit";
            this.exit_B.UseVisualStyleBackColor = true;
            this.exit_B.Click += new System.EventHandler(this.exit_B_Click);
            // 
            // Compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 548);
            this.Controls.Add(this.exit_B);
            this.Controls.Add(this.send_B);
            this.Controls.Add(this.result3_L);
            this.Controls.Add(this.result2_L);
            this.Controls.Add(this.result1_L);
            this.Controls.Add(this.Logout_B);
            this.Controls.Add(this.back_B);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.des3_TB);
            this.Controls.Add(this.des2_TB);
            this.Controls.Add(this.des1_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Attach3_B);
            this.Controls.Add(this.Attach2_B);
            this.Controls.Add(this.Attach1_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Message_RTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendto_CB);
            this.Controls.Add(this.subject_TB);
            this.Name = "Compose";
            this.Text = "Compose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subject_TB;
        private System.Windows.Forms.ComboBox sendto_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Message_RTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Attach1_B;
        private System.Windows.Forms.Button Attach2_B;
        private System.Windows.Forms.Button Attach3_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox des1_TB;
        private System.Windows.Forms.TextBox des2_TB;
        private System.Windows.Forms.TextBox des3_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_B;
        private System.Windows.Forms.Button Logout_B;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Label result1_L;
        private System.Windows.Forms.Label result2_L;
        private System.Windows.Forms.Label result3_L;
        private System.Windows.Forms.Button send_B;
        private System.Windows.Forms.Button exit_B;
    }
}