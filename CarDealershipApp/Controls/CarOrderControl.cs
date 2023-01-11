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

namespace CarDealershipApp.Controls
{
    public partial class CarOrderControl : UserControl
    {
        DB Database = new DB();

        private readonly CarOrder _order;
        private readonly Customer _customer;
        private readonly Car _car;
        private readonly Dealer _dealer;

        public delegate void DeleteReload(CarOrderControl sender);
        public event DeleteReload OnDelete;

        public CarOrderControl(CarOrder order)
        {
            InitializeComponent();

            _order = order;
            _customer = Database.Customers.SingleOrDefault(customer => customer.Id == order.CustomerId);
            _car = Database.Cars.SingleOrDefault(car => car.Id == order.CarId);
            _dealer = Database.Dealers.SingleOrDefault(dealer => dealer.Id == order.DealerId);

            Init();
        }

        public void Init()
        {
            customerNameLB.Items.Add($"{_customer.Name} {_customer.Surname}");
            customerTelLB.Items.Add(_customer.Tel);
            customerEmailLB.Items.Add(_customer.Email);

            carNameLB.Items.Add($"{_car.Brand} {_car.Model} {_car.Year}");
            carPriceLB.Items.Add(_car.Price);

            dealerNameLB.Items.Add($"{_dealer.Name} {_dealer.Surname}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _car.Status = 1;
            Database.CarOrders.Remove(Database.CarOrders.SingleOrDefault(order => order.Id == _order.Id));
            Database.SaveChanges();

            OnDelete?.Invoke(this);
        }
    }
}
