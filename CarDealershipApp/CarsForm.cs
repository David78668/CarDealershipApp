using CarDealershipApp.Database;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class CarsForm : Form
    {
        DB Database = new DB();
        public CarsForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            carsDataGrid.DataSource = Database.Cars.ToList();
            carsDataGrid.Columns["CarOrders"].Visible = false;

            List<int> prices = new List<int>();
            List<int> years = new List<int>();
            foreach (Car car in Database.Cars) 
            { 
                prices.Add(Convert.ToInt32(car.Price));
                years.Add(Convert.ToInt32(car.Year));
            }

            averagePriceLB.Text = $"Average car price: {(int)prices.Average()}";
            averageCarYearLB.Text = $"Average car year: {(int)years.Average()}";
        }

        private void addCarBTN_Click(object sender, EventArgs e)
        {
            Database.Cars.Add(new Car() { Brand = brandTextBox.Text, Model = modelTextBox.Text, Year = yearTextBox.Text, Price = priceTextBox.Text, Status = 1 });
            Database.SaveChanges();
            Init();
        }

        private void carsDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Database.Cars.Remove(Database.Cars.Where(i => int.Parse(carsDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()) == i.Id).FirstOrDefault());
            Database.SaveChanges();
            Init();
        }
    }
}
