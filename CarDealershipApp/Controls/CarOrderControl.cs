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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarDealershipApp.Controls
{
    public partial class CarOrderControl : UserControl
    {
        private readonly DB Database = new DB();

        private readonly Customer _customer;
        private readonly Car _car;
        private readonly Dealer _dealer;

        public CarOrderControl(Customer customer, Car car, Dealer dealer)
        {
            InitializeComponent();
            _customer = customer;
            _car = car;
            _dealer = dealer;
        }

        private void SetUI()
        {
            customerNameLB.Items.Add($"{_customer.Name} {_customer.Surname}");
            customerPhoneLB.Items.Add(_customer.Tel.ToString());
            customerEmailLB.Items.Add(_customer.Email.ToString());

            carNameLB.Items.Add( $"{_car.Brand} {_car.Model} {_car.Year}");
            carPriceLB.Items.Add(_car.Price.ToString());
            carYearLB.Items.Add(_car.Year.ToString());

            dealerNameLB.Items.Add($"{_dealer.Name} {_dealer.Surname}");
            dealerPhoneLB.Items.Add(_dealer.Tel.ToString());
            dealerEmailLB.Items.Add(_dealer.Email.ToString());
        }

        private void CarOrderControl_Load(object sender, EventArgs e)
        {
            SetUI();
        }
    }
}
