using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealershipApp.Database;

namespace CarDealershipApp
{
    public partial class DealersForm : Form
    {
        DB Database = new DB();
        public DealersForm()
        {
            Database = new DB();
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            dealersDataGrid.DataSource = Database.Dealers.ToList();
            dealersDataGrid.Columns["CarOrders"].Visible = false;

            DataTable carSalesTable = new DataTable();

            carSalesTable.Columns.Add("Car Sales");

            List<int> carSalesList = new List<int>();
            int carSales;
            foreach(Dealer dealer in Database.Dealers.ToList()) 
            {
                carSales = 0;
                foreach(CarOrder order in Database.CarOrders.ToList())
                {
                    if(order.DealerId == dealer.Id) { carSales++; }
                }
                carSalesTable.Rows.Add(new object[] { carSales });
                carSalesList.Add(carSales);
            }

            carSalesDatagrid.DataSource = carSalesTable;
            carSalesAvgLB.Text = $"Average car sales: {carSalesList.Average().ToString()}";
        }
        private void addDealerBTN_Click(object sender, EventArgs e)
        {
            Database.Dealers.Add(new Dealer() { Name = nameTextBox.Text, Surname = surnameTextBox.Text, Email = emailTextBox.Text, Tel = phoneTextBox.Text });
            Database.SaveChanges();
            Init();
        }

        private void dealersDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Database.Dealers.Remove(Database.Dealers.SingleOrDefault(i => int.Parse(dealersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()) == i.Id));
            Database.SaveChanges();
            Init();
        }
    }
}