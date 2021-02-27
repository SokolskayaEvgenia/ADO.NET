using System;
using System.Linq;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_03_EDM
{
    public partial class StudentForm : Form
    {
        private ShipsEntities shipContext;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            shipContext = new ShipsEntities();
            var battles = from b in shipContext.Battles.Include("Outcomes")
                          orderby b.date
                          select b;
            try
            {

                this.battleList.DataSource = battles.ToList();
                this.battleList.DisplayMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void battleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Battle battle = (Battle)this.battleList.SelectedItem;
                date_label.Text = battle.date.ToString("d");
                outcomes_dataGridView.DataSource = battle.Outcomes.ToList();
                outcomes_dataGridView.Columns["Battle"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void info_button_Click(object sender, EventArgs e)
        {
            string cell = outcomes_dataGridView.CurrentCell.Value.ToString();
            var query = from cl in shipContext.Classes
                        join sh in shipContext.Ships on cl.class1 equals sh.@class
                        where sh.name == cell
                        select new { Ship = sh.name, Launched = sh.launched, Class = cl.class1, Type = cl.type, Country = cl.country, Guns = cl.numGuns, Bore = cl.bore, Displacement = cl.displacement };
            try
            {
                ships_dataGridView.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Context.MainForm = new EnterForm();
            Program.Context.MainForm.Show();
        }
    }
}
