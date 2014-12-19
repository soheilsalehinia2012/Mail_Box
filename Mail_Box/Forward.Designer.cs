namespace Mail_Box
{
    partial class Forward
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
            this.cancel_B = new System.Windows.Forms.Button();
            this.forwardTo_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forward To : ";
            // 
            // forward_B
            // 
            this.forward_B.Location = new System.Drawing.Point(33, 56);
            this.forward_B.Name = "forward_B";
            this.forward_B.Size = new System.Drawing.Size(75, 23);
            this.forward_B.TabIndex = 1;
            this.forward_B.Text = "Forward";
            this.forward_B.UseVisualStyleBackColor = true;
            this.forward_B.Click += new System.EventHandler(this.forward_B_Click);
            // 
            // cancel_B
            // 
            this.cancel_B.Location = new System.Drawing.Point(155, 56);
            this.cancel_B.Name = "cancel_B";
            this.cancel_B.Size = new System.Drawing.Size(75, 23);
            this.cancel_B.TabIndex = 2;
            this.cancel_B.Text = "Cancel";
            this.cancel_B.UseVisualStyleBackColor = true;
            this.cancel_B.Click += new System.EventHandler(this.cancel_B_Click);
            // 
            // forwardTo_CB
            // 
            this.forwardTo_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.forwardTo_CB.FormattingEnabled = true;
            this.forwardTo_CB.Location = new System.Drawing.Point(128, 20);
            this.forwardTo_CB.Name = "forwardTo_CB";
            this.forwardTo_CB.Size = new System.Drawing.Size(121, 21);
            this.forwardTo_CB.TabIndex = 3;
            // 
            // Forward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.forwardTo_CB);
            this.Controls.Add(this.cancel_B);
            this.Controls.Add(this.forward_B);
            this.Controls.Add(this.label1);
            this.Name = "Forward";
            this.Text = "Forward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button forward_B;
        private System.Windows.Forms.Button cancel_B;
        private System.Windows.Forms.ComboBox forwardTo_CB;
    }
}