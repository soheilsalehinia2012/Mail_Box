namespace Mail_Box
{
    partial class Forward_Reply
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
            this.label1 = new System.Windows.Forms.Label();
            this.forward_B = new System.Windows.Forms.Button();
            this.reply_B = new System.Windows.Forms.Button();
            this.cancel_B = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.forward_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to Forward or Reply?";
            // 
            // forward_B
            // 
            this.forward_B.Location = new System.Drawing.Point(96, 46);
            this.forward_B.Name = "forward_B";
            this.forward_B.Size = new System.Drawing.Size(75, 23);
            this.forward_B.TabIndex = 1;
            this.forward_B.Text = "Forward";
            this.forward_B.UseVisualStyleBackColor = true;
            this.forward_B.Click += new System.EventHandler(this.forward_B_Click);
            // 
            // reply_B
            // 
            this.reply_B.Location = new System.Drawing.Point(15, 46);
            this.reply_B.Name = "reply_B";
            this.reply_B.Size = new System.Drawing.Size(75, 23);
            this.reply_B.TabIndex = 2;
            this.reply_B.Text = "Reply";
            this.reply_B.UseVisualStyleBackColor = true;
            this.reply_B.Click += new System.EventHandler(this.reply_B_Click);
            // 
            // cancel_B
            // 
            this.cancel_B.Location = new System.Drawing.Point(177, 46);
            this.cancel_B.Name = "cancel_B";
            this.cancel_B.Size = new System.Drawing.Size(75, 23);
            this.cancel_B.TabIndex = 3;
            this.cancel_B.Text = "Cancel";
            this.cancel_B.UseVisualStyleBackColor = true;
            this.cancel_B.Click += new System.EventHandler(this.cancel_B_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Forward To :";
            // 
            // forward_CB
            // 
            this.forward_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.forward_CB.FormattingEnabled = true;
            this.forward_CB.Location = new System.Drawing.Point(96, 88);
            this.forward_CB.Name = "forward_CB";
            this.forward_CB.Size = new System.Drawing.Size(121, 21);
            this.forward_CB.TabIndex = 5;
            // 
            // Forward_Reply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 126);
            this.Controls.Add(this.forward_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_B);
            this.Controls.Add(this.reply_B);
            this.Controls.Add(this.forward_B);
            this.Controls.Add(this.label1);
            this.Name = "Forward_Reply";
            this.Text = "Reply/Forward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button forward_B;
        private System.Windows.Forms.Button reply_B;
        private System.Windows.Forms.Button cancel_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox forward_CB;
    }
}