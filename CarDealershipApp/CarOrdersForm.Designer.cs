namespace CarDealershipApp
{
    partial class CarOrdersForm
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
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.addOrderBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dealerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(239, 30);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(202, 28);
            this.carComboBox.TabIndex = 0;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(61, 31);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(162, 28);
            this.customerComboBox.TabIndex = 1;
            // 
            // addOrderBTN
            // 
            this.addOrderBTN.Location = new System.Drawing.Point(633, 29);
            this.addOrderBTN.Name = "addOrderBTN";
            this.addOrderBTN.Size = new System.Drawing.Size(99, 29);
            this.addOrderBTN.TabIndex = 2;
            this.addOrderBTN.Text = "Add Order";
            this.addOrderBTN.UseVisualStyleBackColor = true;
            this.addOrderBTN.Click += new System.EventHandler(this.addOrderBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Car";
            // 
            // formPanel
            // 
            this.formPanel.Location = new System.Drawing.Point(82, 75);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(630, 320);
            this.formPanel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(457, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dealer";
            // 
            // dealerComboBox
            // 
            this.dealerComboBox.FormattingEnabled = true;
            this.dealerComboBox.Location = new System.Drawing.Point(456, 30);
            this.dealerComboBox.Name = "dealerComboBox";
            this.dealerComboBox.Size = new System.Drawing.Size(162, 28);
            this.dealerComboBox.TabIndex = 12;
            // 
            // CarOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.dealerComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addOrderBTN);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.carComboBox);
            this.Name = "CarOrdersForm";
            this.Text = "CarOrdersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox carComboBox;
        private ComboBox customerComboBox;
        private Button addOrderBTN;
        private Label label2;
        private Label label1;
        private Panel formPanel;
        private Label label3;
        private ComboBox dealerComboBox;
    }
}