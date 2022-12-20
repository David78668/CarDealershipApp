namespace CarDealershipApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formsPanel = new System.Windows.Forms.Panel();
            this.formsSelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formsPanel
            // 
            this.formsPanel.Location = new System.Drawing.Point(12, 57);
            this.formsPanel.Name = "formsPanel";
            this.formsPanel.Size = new System.Drawing.Size(816, 392);
            this.formsPanel.TabIndex = 0;
            // 
            // formsSelectBox
            // 
            this.formsSelectBox.FormattingEnabled = true;
            this.formsSelectBox.Location = new System.Drawing.Point(12, 12);
            this.formsSelectBox.Name = "formsSelectBox";
            this.formsSelectBox.Size = new System.Drawing.Size(204, 28);
            this.formsSelectBox.TabIndex = 1;
            this.formsSelectBox.SelectedIndexChanged += new System.EventHandler(this.formsSelectBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(840, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formsSelectBox);
            this.Controls.Add(this.formsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel formsPanel;
        private ComboBox formsSelectBox;
        private Label label1;
    }
}