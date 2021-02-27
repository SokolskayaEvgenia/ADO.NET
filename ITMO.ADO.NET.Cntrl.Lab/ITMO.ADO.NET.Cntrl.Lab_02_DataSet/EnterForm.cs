using System;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_02
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manager_button_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Visible = true;
        }

        
        private void dontKnow_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void client_button_Click(object sender, EventArgs e)
        {
            ClientForm customerForm = new ClientForm();
            customerForm.Visible = true;
        }
    }
}
