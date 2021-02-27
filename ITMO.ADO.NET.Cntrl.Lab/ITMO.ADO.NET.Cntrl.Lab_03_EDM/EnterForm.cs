using System;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_03_EDM
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
        
        private void dontKnow_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void student_button_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new StudentForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void historian_button_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new HistorianForm();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}
