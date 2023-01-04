using CarDealershipApp.Controls;
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
    public partial class CarOrdersListForm : Form
    {
        DB Database = new DB();

        public CarOrdersListForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            Point P = new Point(0,0);

            foreach (var order in Database.CarOrders.ToList())
            {
                Customer OrderCustomer = Database.Customers.SingleOrDefault(customer => customer.Id == order.CustomerId);
                Car OrderCar = Database.Cars.SingleOrDefault(car => car.Id == order.CarId);
                Dealer OrderDealer = Database.Dealers.SingleOrDefault(dealer => dealer.Id == order.DealerId);
                
                CarOrderControl control = new(OrderCustomer, OrderCar, OrderDealer);
                control.Location = P;
                control.Width = 630;
                control.Height = 184;

                ordersPanel.Controls.Add(control);

                P = new Point(0, P.Y + control.Height);
            }
        }
    }
}
