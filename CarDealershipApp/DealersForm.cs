using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarDealershipApp.Database;

namespace CarDealershipApp
{
    public partial class DealersForm : Form
    {
        DB Database = new DB();
        public DealersForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            dealersDataGrid.DataSource = Database.Dealers.ToList();
        }

        private void addDealerBTN_Click(object sender, EventArgs e)
        {
            Database.Dealers.Add(new Dealer() { Name = nameTextBox.Text, Surname = surnameTextBox.Text, Email = emailTextBox.Text, Tel = phoneTextBox.Text });
            Database.SaveChanges();
            Init();
        }

        private void dealersDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Database.Dealers.Remove(Database.Dealers.Where(i => int.Parse(dealersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()) == i.Id).FirstOrDefault());
            Database.SaveChanges();
            Init();
        }
    }
}
