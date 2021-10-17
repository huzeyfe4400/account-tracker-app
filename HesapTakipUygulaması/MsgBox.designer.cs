namespace GinkoSolutions
{
    partial class MsgBox
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlIcon.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 89);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(262, 48);
            this.pnlButtons.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.BackColor = System.Drawing.Color.White;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Location = new System.Drawing.Point(9, 24);
            this.txtText.MaximumSize = new System.Drawing.Size(403, 645);
            this.txtText.MaxLength = 999999999;
            this.txtText.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(184, 20);
            this.txtText.TabIndex = 4;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(21, 22);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(32, 32);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIcon.TabIndex = 5;
            this.picIcon.TabStop = false;
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.picIcon);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(57, 89);
            this.pnlIcon.TabIndex = 6;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtText);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(57, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(205, 89);
            this.pnlMain.TabIndex = 7;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 137);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlIcon);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(278, 175);
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlIcon.ResumeLayout(false);
            this.pnlIcon.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Panel pnlMain;
    }
}