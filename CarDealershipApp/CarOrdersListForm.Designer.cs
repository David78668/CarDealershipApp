namespace CarDealershipApp
{
    partial class CarOrdersListForm
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
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ordersPanel
            // 
            this.ordersPanel.AutoSize = true;
            this.ordersPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ordersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersPanel.Location = new System.Drawing.Point(0, 0);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(612, 273);
            this.ordersPanel.TabIndex = 0;
            // 
            // CarOrdersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(612, 273);
            this.Controls.Add(this.ordersPanel);
            this.Name = "CarOrdersListForm";
            this.Text = "CarOrdersList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel ordersPanel;
    }
}