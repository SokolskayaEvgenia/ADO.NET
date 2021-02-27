using System;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_02
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(shipsDataSet1.Ships);
            Manager_dataGridView.DataSource = shipsDataSet1.Ships;
            Manager_dataGridView.MultiSelect = false;
            Manager_dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Manager_dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }

        private void saveChange_button_Click(object sender, EventArgs e)
        {
            shipsDataSet1.EndInit();
            sqlDataAdapter1.Update(shipsDataSet1);
        }

        private void deleteRow_button_Click(object sender, EventArgs e)
        {
            //shipsDataSet1.EndInit();
            var index = Manager_dataGridView.CurrentRow.Index;
            shipsDataSet1.Tables["Ships"].Rows[index].Delete();
        }

      

       
    }
}
