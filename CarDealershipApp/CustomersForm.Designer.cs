namespace CarDealershipApp
{
    partial class CustomersForm
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
            this.customersDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGrid
            // 
            this.customersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.customersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGrid.Location = new System.Drawing.Point(12, 59);
            this.customersDataGrid.Name = "customersDataGrid";
            this.customersDataGrid.RowHeadersWidth = 51;
            this.customersDataGrid.RowTemplate.Height = 29;
            this.customersDataGrid.Size = new System.Drawing.Size(776, 320);
            this.customersDataGrid.TabIndex = 0;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 393);
            this.Controls.Add(this.customersDataGrid);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView customersDataGrid;
    }
}