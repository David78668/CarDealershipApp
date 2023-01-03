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
            this.carOrdersDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // carOrdersDataGrid
            // 
            this.carOrdersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.carOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carOrdersDataGrid.Location = new System.Drawing.Point(12, 59);
            this.carOrdersDataGrid.Name = "carOrdersDataGrid";
            this.carOrdersDataGrid.RowHeadersWidth = 51;
            this.carOrdersDataGrid.RowTemplate.Height = 29;
            this.carOrdersDataGrid.Size = new System.Drawing.Size(776, 320);
            this.carOrdersDataGrid.TabIndex = 0;
            // 
            // CarOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 393);
            this.Controls.Add(this.carOrdersDataGrid);
            this.Name = "CarOrdersForm";
            this.Text = "CarOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView carOrdersDataGrid;
    }
}