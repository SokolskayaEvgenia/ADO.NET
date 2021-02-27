using System;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_02
{
    public partial class HistorianForm : Form
    {
        public HistorianForm()
        {
            InitializeComponent();
        }
        private void saveChange_button_Click(object sender, EventArgs e)
        {
            shipsDataSet1.EndInit();
            sqlDataAdapter1.Update(shipsDataSet1);
        }

        private void deleteRow_button_Click(object sender, EventArgs e)
        {
            //shipsDataSet1.EndInit();
            var index = Historian_dataGridView.CurrentRow.Index;
            shipsDataSet1.Tables["Ships"].Rows[index].Delete();
        }

        private void HistorianForm_Load(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(shipsDataSet1.Ships);
            Historian_dataGridView.DataSource = shipsDataSet1.Ships;
            Historian_dataGridView.MultiSelect = false;
            Historian_dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Historian_dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }

        private void HistorianForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Context.MainForm = new EnterForm();
            Program.Context.MainForm.Show();
        }
    }
}
