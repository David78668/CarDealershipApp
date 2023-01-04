using CarDealershipApp.Database;
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
    public partial class CustomersForm : Form
    {
        DB Database = new DB();

        public CustomersForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            customersDataGrid.DataSource = Database.Customers.ToList();
            customersDataGrid.Columns["CarOrders"].Visible = false;
        }

        private void addCustomerBTN_Click(object sender, EventArgs e)
        {
            Database.Customers.Add(new Customer() { Name = nameTextBox.Text, Surname = surnameTextBox.Text, Email = emailTextBox.Text, Tel = phoneTextBox.Text  });
            Database.SaveChanges();
            Init();
        }

        private void customersDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Database.Customers.Remove(Database.Customers.Where(i => int.Parse(customersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()) == i.Id).FirstOrDefault());
            Database.SaveChanges();
            Init();
        }
    }
}
