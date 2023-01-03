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
        }
    }
}
