namespace CarDealershipApp
{
    partial class CarsForm
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
            this.carsDataGrid = new System.Windows.Forms.DataGridView();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addCarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGrid
            // 
            this.carsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.carsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.carsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGrid.Location = new System.Drawing.Point(12, 59);
            this.carsDataGrid.Name = "carsDataGrid";
            this.carsDataGrid.RowHeadersWidth = 51;
            this.carsDataGrid.RowTemplate.Height = 29;
            this.carsDataGrid.Size = new System.Drawing.Size(776, 320);
            this.carsDataGrid.TabIndex = 0;
            this.carsDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carsDataGrid_RowHeaderMouseClick);
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(170, 26);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(125, 27);
            this.brandTextBox.TabIndex = 1;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(301, 26);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(125, 27);
            this.modelTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(432, 26);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(125, 27);
            this.yearTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(563, 26);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(125, 27);
            this.priceTextBox.TabIndex = 4;
            // 
            // addCarBTN
            // 
            this.addCarBTN.BackColor = System.Drawing.Color.White;
            this.addCarBTN.Location = new System.Drawing.Point(694, 24);
            this.addCarBTN.Name = "addCarBTN";
            this.addCarBTN.Size = new System.Drawing.Size(94, 29);
            this.addCarBTN.TabIndex = 5;
            this.addCarBTN.Text = "Add Car";
            this.addCarBTN.UseVisualStyleBackColor = false;
            this.addCarBTN.Click += new System.EventHandler(this.addCarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(436, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(566, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCarBTN);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.carsDataGrid);
            this.Name = "CarsForm";
            this.Text = "CarsForm";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView carsDataGrid;
        private TextBox brandTextBox;
        private TextBox modelTextBox;
        private TextBox yearTextBox;
        private TextBox priceTextBox;
        private Button addCarBTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}