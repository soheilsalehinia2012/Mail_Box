namespace Mail_Box
{
    partial class Attachments
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
            this.Attachments_DGV = new System.Windows.Forms.DataGridView();
            this.back_B = new System.Windows.Forms.Button();
            this.logout_B = new System.Windows.Forms.Button();
            this.exit_B = new System.Windows.Forms.Button();
            this.descriotion_RTB = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Attachments_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Attachments_DGV
            // 
            this.Attachments_DGV.AllowUserToAddRows = false;
            this.Attachments_DGV.AllowUserToDeleteRows = false;
            this.Attachments_DGV.AllowUserToResizeColumns = false;
            this.Attachments_DGV.AllowUserToResizeRows = false;
            this.Attachments_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attachments_DGV.Location = new System.Drawing.Point(12, 12);
            this.Attachments_DGV.Name = "Attachments_DGV";
            this.Attachments_DGV.Size = new System.Drawing.Size(240, 77);
            this.Attachments_DGV.TabIndex = 0;
            this.Attachments_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Attachments_DGV_CellClick);
            // 
            // back_B
            // 
            this.back_B.Location = new System.Drawing.Point(545, 190);
            this.back_B.Name = "back_B";
            this.back_B.Size = new System.Drawing.Size(75, 23);
            this.back_B.TabIndex = 1;
            this.back_B.Text = "Back";
            this.back_B.UseVisualStyleBackColor = true;
            this.back_B.Click += new System.EventHandler(this.back_B_Click);
            // 
            // logout_B
            // 
            this.logout_B.Location = new System.Drawing.Point(545, 219);
            this.logout_B.Name = "logout_B";
            this.logout_B.Size = new System.Drawing.Size(75, 23);
            this.logout_B.TabIndex = 2;
            this.logout_B.Text = "Logout";
            this.logout_B.UseVisualStyleBackColor = true;
            this.logout_B.Click += new System.EventHandler(this.logout_B_Click);
            // 
            // exit_B
            // 
            this.exit_B.Location = new System.Drawing.Point(545, 248);
            this.exit_B.Name = "exit_B";
            this.exit_B.Size = new System.Drawing.Size(75, 23);
            this.exit_B.TabIndex = 3;
            this.exit_B.Text = "Exit";
            this.exit_B.UseVisualStyleBackColor = true;
            this.exit_B.Click += new System.EventHandler(this.exit_B_Click);
            // 
            // descriotion_RTB
            // 
            this.descriotion_RTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.descriotion_RTB.Location = new System.Drawing.Point(12, 190);
            this.descriotion_RTB.Name = "descriotion_RTB";
            this.descriotion_RTB.ReadOnly = true;
            this.descriotion_RTB.Size = new System.Drawing.Size(362, 79);
            this.descriotion_RTB.TabIndex = 4;
            this.descriotion_RTB.Text = "";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(12, 174);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(302, 13);
            this.Description.TabIndex = 5;
            this.Description.Text = "Description (click on description field to see the full description)";
            // 
            // Attachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 298);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.descriotion_RTB);
            this.Controls.Add(this.exit_B);
            this.Controls.Add(this.logout_B);
            this.Controls.Add(this.back_B);
            this.Controls.Add(this.Attachments_DGV);
            this.Name = "Attachments";
            this.Text = "Attachments";
            ((System.ComponentModel.ISupportInitialize)(this.Attachments_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Attachments_DGV;
        private System.Windows.Forms.Button back_B;
        private System.Windows.Forms.Button logout_B;
        private System.Windows.Forms.Button exit_B;
        private System.Windows.Forms.RichTextBox descriotion_RTB;
        private System.Windows.Forms.Label Description;
    }
}