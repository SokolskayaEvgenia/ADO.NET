using System;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_02
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void getList_button_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(shipsDataSet1.Ships);
            Customer_listBox.Items.Clear();
            foreach (ShipsDataSet.ShipsRow Ship in shipsDataSet1.Ships.Rows)
            {
                Customer_listBox.Items.Add(Ship.name);
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
