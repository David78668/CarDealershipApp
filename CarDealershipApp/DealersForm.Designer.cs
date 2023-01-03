namespace CarDealershipApp
{
    partial class DealersForm
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
            this.dealersDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addDealerBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dealersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dealersDataGrid
            // 
            this.dealersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dealersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dealersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealersDataGrid.Location = new System.Drawing.Point(12, 59);
            this.dealersDataGrid.Name = "dealersDataGrid";
            this.dealersDataGrid.RowHeadersWidth = 51;
            this.dealersDataGrid.RowTemplate.Height = 29;
            this.dealersDataGrid.Size = new System.Drawing.Size(776, 320);
            this.dealersDataGrid.TabIndex = 0;
            this.dealersDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dealersDataGrid_RowHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(564, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(434, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(561, 26);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(125, 27);
            this.phoneTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(430, 26);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(125, 27);
            this.emailTextBox.TabIndex = 12;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(299, 26);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(125, 27);
            this.surnameTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(168, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 27);
            this.nameTextBox.TabIndex = 10;
            // 
            // addDealerBTN
            // 
            this.addDealerBTN.BackColor = System.Drawing.Color.White;
            this.addDealerBTN.Location = new System.Drawing.Point(692, 26);
            this.addDealerBTN.Name = "addDealerBTN";
            this.addDealerBTN.Size = new System.Drawing.Size(94, 29);
            this.addDealerBTN.TabIndex = 19;
            this.addDealerBTN.Text = "Add Dealer";
            this.addDealerBTN.UseVisualStyleBackColor = false;
            this.addDealerBTN.Click += new System.EventHandler(this.addDealerBTN_Click);
            // 
            // DealersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 393);
            this.Controls.Add(this.addDealerBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dealersDataGrid);
            this.Name = "DealersForm";
            this.Text = "DealersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dealersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dealersDataGrid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Button addDealerBTN;
    }
}