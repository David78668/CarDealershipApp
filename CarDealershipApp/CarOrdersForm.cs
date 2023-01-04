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
        CarOrdersListForm carOrderListForm = new();

        public CarOrdersForm()
        {
            InitializeComponent();
            ComboBoxInit();
            DataInit();
            FormInit();
        }

        public void ComboBoxInit()
        {
            foreach (var customer in Database.Customers.ToList())
            {
                customerComboBox.Items.Add($"(id:{customer.Id}) {customer.Name} {customer.Surname}");
            }

            foreach (var car in Database.Cars.ToList())
            {
                carComboBox.Items.Add($"(id:{car.Id}) {car.Brand} {car.Model} {car.Year}");
            }
            foreach(var dealer in Database.Dealers.ToList())
            {
                dealerComboBox.Items.Add($"(id:{dealer.Id}) {dealer.Name} {dealer.Surname}");
            }
        }

        public void DataInit()
        {
            foreach (var order in Database.CarOrders.ToList())
            {
                Customer OrderCustomer = Database.Customers.SingleOrDefault(customer => customer.Id == order.CustomerId);
                Car OrderCar = Database.Cars.SingleOrDefault(car => car.Id == order.CarId);
                Dealer OrderDealer = Database.Dealers.SingleOrDefault(dealer => dealer.Id == order.DealerId);

            }
        }

        public void FormInit()
        {
            carOrderListForm.TopLevel = false;
            carOrderListForm.AutoScroll = true;
            carOrderListForm.FormBorderStyle = FormBorderStyle.None;

            formPanel.Controls.Add(carOrderListForm);
            formPanel.AutoScroll = false;
            formPanel.HorizontalScroll.Enabled = false;
            formPanel.HorizontalScroll.Visible = false;
            formPanel.HorizontalScroll.Maximum = 0;
            formPanel.AutoScroll = true;
            carOrderListForm.Show();
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
        }
    }
}
