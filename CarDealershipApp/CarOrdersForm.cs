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
    public partial class CarOrdersForm : Form
    {
        DB Database = new DB();

        public CarOrdersForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            carOrdersDataGrid.DataSource = Database.CarOrders.ToList();
        }
    }
}
