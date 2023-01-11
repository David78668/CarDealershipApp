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
    public partial class CarOrdersForm : Form
    {
        DB Database = new DB();

        public CarOrdersForm()
        {
            InitializeComponent();
            ComboBoxInit();
            FormInit();
        }

        public void FormInit()
        {
            ordersPanel.Controls.Clear();
            Point P = new Point(0, 0);

            foreach (CarOrder order in Database.CarOrders.ToList())
            {
                CarOrderControl control = new(order);

                control.Location = P;

                control.OnDelete += Reload;

                ordersPanel.Controls.Add(control);

                P = new Point(0, P.Y + control.Height);
            }
            ordersPanel.AutoScroll = false;
            ordersPanel.HorizontalScroll.Enabled = false;
            ordersPanel.HorizontalScroll.Visible = false;
            ordersPanel.HorizontalScroll.Maximum = 0;
            ordersPanel.AutoScroll = true;
        }

        public void ComboBoxInit()
        {
            customerComboBox.Items.Clear();
            carComboBox.Items.Clear();
            dealerComboBox.Items.Clear();

            foreach (Customer customer in Database.Customers.ToList())
            {
                customerComboBox.Items.Add($"(id:{customer.Id}) {customer.Name} {customer.Surname}");
            }
            foreach (Car car in Database.Cars.ToList().Where(car => car.Status == 1))
            {
                carComboBox.Items.Add($"(id:{car.Id}) {car.Brand} {car.Model} {car.Year}");
            }
            foreach(Dealer dealer in Database.Dealers.ToList())
            {
                dealerComboBox.Items.Add($"(id:{dealer.Id}) {dealer.Name} {dealer.Surname}");
            }
        }

        private void Reload(CarOrderControl sender)
        {
            Database = new DB();
            ComboBoxInit();
            FormInit();
        }

        private void addOrderBTN_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerComboBox.SelectedItem.ToString().Substring(4, 1));
            int carId = Convert.ToInt32(carComboBox.SelectedItem.ToString().Substring(4, 1));
            int dealerId = Convert.ToInt32(dealerComboBox.SelectedItem.ToString().Substring(4, 1));

            Database.CarOrders.Add(new CarOrder() { CustomerId = customerId, CarId = carId, DealerId = dealerId });
            Car selectedCar = Database.Cars.SingleOrDefault(car => carId == car.Id);
            selectedCar.Status = 2;
            Database.SaveChanges();

            FormInit();
            ComboBoxInit();

            customerComboBox.SelectedIndex = -1;
            customerComboBox.Text = "";
            carComboBox.SelectedIndex = -1;
            carComboBox.Text = "";
            dealerComboBox.SelectedIndex = -1;
            dealerComboBox.Text = "";
        }
    }
}
