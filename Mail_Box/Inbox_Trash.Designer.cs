﻿namespace Mail_Box
{
    partial class Inbox_Trash
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
            this.search_B = new System.Windows.Forms.Button();
            this.to_DTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.from_DTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Sword_TB = new System.Windows.Forms.TextBox();
            this.searchBy_CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showall_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Message_RTB = new System.Windows.Forms.RichTextBox();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Logout_B = new System.Windows.Forms.Button();
            this.back_B = new System.Windows.Forms.Button();
            this.InboxTrash_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InboxTrash_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // search_B
            // 
            this.search_B.Location = new System.Drawing.Point(461, 425);
            this.search_B.Name = "search_B";
            this.search_B.Size = new System.Drawing.Size(75, 23);
            this.search_B.TabIndex = 33;
            this.search_B.Text = "Search";
            this.search_B.UseVisualStyleBackColor = true;
            // 
            // to_DTP
            // 
            this.to_DTP.Location = new System.Drawing.Point(313, 508);
            this.to_DTP.Name = "to_DTP";
            this.to_DTP.Size = new System.Drawing.Size(200, 20);
            this.to_DTP.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "From:";
            // 
            // from_DTP
            // 
            this.from_DTP.Location = new System.Drawing.Point(313, 480);
            this.from_DTP.Name = "from_DTP";
            this.from_DTP.Size = new System.Drawing.Size(200, 20);
            this.from_DTP.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Search word : ";
            // 
            // Sword_TB
            // 
            this.Sword_TB.Location = new System.Drawing.Point(313, 454);
            this.Sword_TB.Name = "Sword_TB";
            this.Sword_TB.Size = new System.Drawing.Size(121, 20);
            this.Sword_TB.TabIndex = 27;
            // 
            // searchBy_CB
            // 
            this.searchBy_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBy_CB.FormattingEnabled = true;
            this.searchBy_CB.Items.AddRange(new object[] {
            "Sender",
            "Subject",
            "Message",
            "Sender Name",
            "Sender FName",
            "Date",
            "From..To Date"});
            this.searchBy_CB.Location = new System.Drawing.Point(313, 427);
            this.searchBy_CB.Name = "searchBy_CB";
            this.searchBy_CB.Size = new System.Drawing.Size(121, 21);
            this.searchBy_CB.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Search By :";
            // 
            // showall_B
            // 
            this.showall_B.Location = new System.Drawing.Point(118, 469);
            this.showall_B.Name = "showall_B";
            this.showall_B.Size = new System.Drawing.Size(85, 23);
            this.showall_B.TabIndex = 24;
            this.showall_B.Text = "Show All";
            this.showall_B.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1011, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Message (click on message field to see full message)";
            // 
            // Message_RTB
            // 
            this.Message_RTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Message_RTB.Location = new System.Drawing.Point(1014, 37);
            this.Message_RTB.Name = "Message_RTB";
            this.Message_RTB.ReadOnly = true;
            this.Message_RTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Message_RTB.Size = new System.Drawing.Size(275, 483);
            this.Message_RTB.TabIndex = 21;
            this.Message_RTB.Text = "";
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(14, 505);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(75, 23);
            this.Exit_B.TabIndex = 20;
            this.Exit_B.Text = "Exit";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Logout_B
            // 
            this.Logout_B.Location = new System.Drawing.Point(14, 469);
            this.Logout_B.Name = "Logout_B";
            this.Logout_B.Size = new System.Drawing.Size(75, 23);
            this.Logout_B.TabIndex = 19;
            this.Logout_B.Text = "Logout";
            this.Logout_B.UseVisualStyleBackColor = true;
            this.Logout_B.Click += new System.EventHandler(this.Logout_B_Click);
            // 
            // back_B
            // 
            this.back_B.Location = new System.Drawing.Point(14, 430);
            this.back_B.Name = "back_B";
            this.back_B.Size = new System.Drawing.Size(75, 23);
            this.back_B.TabIndex = 18;
            this.back_B.Text = "Back";
            this.back_B.UseVisualStyleBackColor = true;
            this.back_B.Click += new System.EventHandler(this.back_B_Click);
            // 
            // InboxTrash_DGV
            // 
            this.InboxTrash_DGV.AllowUserToAddRows = false;
            this.InboxTrash_DGV.AllowUserToDeleteRows = false;
            this.InboxTrash_DGV.AllowUserToResizeColumns = false;
            this.InboxTrash_DGV.AllowUserToResizeRows = false;
            this.InboxTrash_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InboxTrash_DGV.Location = new System.Drawing.Point(14, 12);
            this.InboxTrash_DGV.Name = "InboxTrash_DGV";
            this.InboxTrash_DGV.Size = new System.Drawing.Size(512, 403);
            this.InboxTrash_DGV.TabIndex = 17;
            // 
            // Inbox_Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 540);
            this.Controls.Add(this.search_B);
            this.Controls.Add(this.to_DTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.from_DTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sword_TB);
            this.Controls.Add(this.searchBy_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showall_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message_RTB);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Logout_B);
            this.Controls.Add(this.back_B);
            this.Controls.Add(this.InboxTrash_DGV);
            this.Name = "Inbox_Trash";
            this.Text = "Inbox_Trash";
            ((System.ComponentModel.ISupportInitialize)(this.InboxTrash_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_B;
        private System.Windows.Forms.DateTimePicker to_DTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker from_DTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sword_TB;
        private System.Windows.Forms.ComboBox searchBy_CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showall_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Message_RTB;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Button Logout_B;
        private System.Windows.Forms.Button back_B;
        private System.Windows.Forms.DataGridView InboxTrash_DGV;
    }
}