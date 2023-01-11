using System.DirectoryServices.ActiveDirectory;

namespace CarDealershipApp
{
    public partial class Form1 : Form
    {
        List<Form> FormList = new();
        DealersForm dealersForm = new();
        CarsForm carsForm = new();
        CustomersForm customersForm = new();
        CarOrdersForm carOrdersForm = new();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            FormList.Add(dealersForm);
            FormList.Add(carsForm);
            FormList.Add(customersForm);
            FormList.Add(carOrdersForm);

            foreach (var form in FormList)
            {
                form.TopLevel = false;
                form.AutoScroll = true;
                form.FormBorderStyle = FormBorderStyle.None;
                formsPanel.Controls.Add(form);
                formsSelectBox.Items.Add(form.Text);
            }
            formsSelectBox.SelectedIndex = 0;
        }

        private void formsSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           foreach(var form in FormList)
            {
                if (formsSelectBox.SelectedItem.ToString() == form.Text)
                {
                    form.Show();
                }
                else
                {
                    form.Hide();
                }
            }

        }
    }
}