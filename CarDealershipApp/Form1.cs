using System.DirectoryServices.ActiveDirectory;

namespace CarDealershipApp
{
    public partial class Form1 : Form
    {
        List<Form> FormList = new();
        DealersForm dealersForm = new();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            FormList.Add(dealersForm);

            foreach (var form in FormList)
            {
                form.TopLevel = false;
                form.AutoScroll = true;
                form.FormBorderStyle = FormBorderStyle.None;
                formsPanel.Controls.Add(form);
                formsSelectBox.Items.Add(form.Text);
            }
        }

        private void formsSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           foreach(var form in FormList)
            {
                if (formsSelectBox.SelectedItem == form.Text)
                {
                    form.Show();
                }
            }

        }
    }
}