using System;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_02
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void getList_button_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(shipsDataSet1.Ships);
            Student_listBox.Items.Clear();
            foreach (ShipsDataSet.ShipsRow Ship in shipsDataSet1.Ships.Rows)
            {
                Student_listBox.Items.Add(Ship.name);
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Context.MainForm = new EnterForm();
            Program.Context.MainForm.Show();
        }
    }
}
