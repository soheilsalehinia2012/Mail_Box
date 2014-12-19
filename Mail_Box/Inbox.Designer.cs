namespace Mail_Box
{
    partial class Inbox
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
            this.Inbox_DGV = new System.Windows.Forms.DataGridView();
            this.back_B = new System.Windows.Forms.Button();
            this.Logout_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Message_RTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SUnread_B = new System.Windows.Forms.Button();
            this.showall_B = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBy_CB = new System.Windows.Forms.ComboBox();
            this.Sword_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.from_DTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.to_DTP = new System.Windows.Forms.DateTimePicker();
            this.search_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Inbox_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Inbox_DGV
            // 
            this.Inbox_DGV.AllowUserToAddRows = false;
            this.Inbox_DGV.AllowUserToDeleteRows = false;
            this.Inbox_DGV.AllowUserToResizeColumns = false;
            this.Inbox_DGV.AllowUserToResizeRows = false;
            this.Inbox_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inbox_DGV.Location = new System.Drawing.Point(12, 12);
            this.Inbox_DGV.Name = "Inbox_DGV";
            this.Inbox_DGV.Size = new System.Drawing.Size(512, 403);
            this.Inbox_DGV.TabIndex = 0;
            this.Inbox_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inbox_DGV_CellClick);
            // 
            // back_B
            // 
            this.back_B.Location = new System.Drawing.Point(12, 430);
            this.back_B.Name = "back_B";
            this.back_B.Size = new System.Drawing.Size(75, 23);
            this.back_B.TabIndex = 1;
            this.back_B.Text = "Back";
            this.back_B.UseVisualStyleBackColor = true;
            this.back_B.Click += new System.EventHandler(this.back_B_Click);
            // 
            // Logout_B
            // 
            this.Logout_B.Location = new System.Drawing.Point(12, 469);
            this.Logout_B.Name = "Logout_B";
            this.Logout_B.Size = new System.Drawing.Size(75, 23);
            this.Logout_B.TabIndex = 2;
            this.Logout_B.Text = "Logout";
            this.Logout_B.UseVisualStyleBackColor = true;
            this.Logout_B.Click += new System.EventHandler(this.Logout_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(12, 505);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(75, 23);
            this.Exit_B.TabIndex = 3;
            this.Exit_B.Text = "Exit";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Message_RTB
            // 
            this.Message_RTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Message_RTB.Location = new System.Drawing.Point(1012, 37);
            this.Message_RTB.Name = "Message_RTB";
            this.Message_RTB.ReadOnly = true;
            this.Message_RTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Message_RTB.Size = new System.Drawing.Size(275, 483);
            this.Message_RTB.TabIndex = 4;
            this.Message_RTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1009, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message (click on message field to see full message)";
            // 
            // SUnread_B
            // 
            this.SUnread_B.Location = new System.Drawing.Point(116, 430);
            this.SUnread_B.Name = "SUnread_B";
            this.SUnread_B.Size = new System.Drawing.Size(85, 23);
            this.SUnread_B.TabIndex = 6;
            this.SUnread_B.Text = "Show Unreads";
            this.SUnread_B.UseVisualStyleBackColor = true;
            this.SUnread_B.Click += new System.EventHandler(this.SUnread_B_Click);
            // 
            // showall_B
            // 
            this.showall_B.Location = new System.Drawing.Point(116, 469);
            this.showall_B.Name = "showall_B";
            this.showall_B.Size = new System.Drawing.Size(85, 23);
            this.showall_B.TabIndex = 7;
            this.showall_B.Text = "Show All";
            this.showall_B.UseVisualStyleBackColor = true;
            this.showall_B.Click += new System.EventHandler(this.showall_B_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search By :";
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
            this.searchBy_CB.Location = new System.Drawing.Point(311, 427);
            this.searchBy_CB.Name = "searchBy_CB";
            this.searchBy_CB.Size = new System.Drawing.Size(121, 21);
            this.searchBy_CB.TabIndex = 9;
            this.searchBy_CB.SelectedIndexChanged += new System.EventHandler(this.searchBy_CB_SelectedIndexChanged);
            // 
            // Sword_TB
            // 
            this.Sword_TB.Location = new System.Drawing.Point(311, 454);
            this.Sword_TB.Name = "Sword_TB";
            this.Sword_TB.Size = new System.Drawing.Size(121, 20);
            this.Sword_TB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search word : ";
            // 
            // from_DTP
            // 
            this.from_DTP.Location = new System.Drawing.Point(311, 480);
            this.from_DTP.Name = "from_DTP";
            this.from_DTP.Size = new System.Drawing.Size(200, 20);
            this.from_DTP.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "To:";
            // 
            // to_DTP
            // 
            this.to_DTP.Location = new System.Drawing.Point(311, 508);
            this.to_DTP.Name = "to_DTP";
            this.to_DTP.Size = new System.Drawing.Size(200, 20);
            this.to_DTP.TabIndex = 15;
            // 
            // search_B
            // 
            this.search_B.Location = new System.Drawing.Point(459, 425);
            this.search_B.Name = "search_B";
            this.search_B.Size = new System.Drawing.Size(75, 23);
            this.search_B.TabIndex = 16;
            this.search_B.Text = "Search";
            this.search_B.UseVisualStyleBackColor = true;
            this.search_B.Click += new System.EventHandler(this.search_B_Click);
            // 
            // Inbox
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
            this.Controls.Add(this.SUnread_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message_RTB);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Logout_B);
            this.Controls.Add(this.back_B);
            this.Controls.Add(this.Inbox_DGV);
            this.Name = "Inbox";
            this.Text = "Inbox";
            ((System.ComponentModel.ISupportInitialize)(this.Inbox_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Inbox_DGV;
        private System.Windows.Forms.Button back_B;
        private System.Windows.Forms.Button Logout_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.RichTextBox Message_RTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SUnread_B;
        private System.Windows.Forms.Button showall_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchBy_CB;
        private System.Windows.Forms.TextBox Sword_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker from_DTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker to_DTP;
        private System.Windows.Forms.Button search_B;


    }
}