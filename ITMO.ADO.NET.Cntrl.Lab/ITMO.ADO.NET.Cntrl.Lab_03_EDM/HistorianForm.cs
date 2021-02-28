using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_03_EDM
{
    public partial class HistorianForm : Form
    {
        private ShipsEntities shipContext;

        public HistorianForm()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            shipContext = new ShipsEntities();

            var query1 = from o in shipContext.Outcomes
                         join b in shipContext.Battles on o.battle equals b.name
                         select new
                         {
                             Battle = o.battle,
                             Date = b.date,
                             Ship = o.ship,
                             Result = o.result
                         };

            var query = from sh in shipContext.Ships
                        join cl in shipContext.Classes on sh.@class equals cl.class1
                        select new
                        {
                            Ship = sh.name,
                            Launched = sh.launched,
                            Class = cl.class1,
                            Type = cl.type,
                            Country = cl.country,
                            Guns = cl.numGuns,
                            Bore = cl.bore,
                            Displacement = cl.displacement,
                        };

            this.ships_dataGridView.DataSource = query.ToList();
            this.battles_dataGridView.DataSource = query1.ToList();
        }

        private void HistorianForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Context.MainForm = new EnterForm();
            Program.Context.MainForm.Show();
        }



        private void add_button_Click(object sender, EventArgs e)
        {
            if (makeChangesList.Text == "Ships")
            { 
                this.changes_dataGridView.DataSource = shipContext.Ships.Local.ToBindingList(); 
            }

            else if (makeChangesList.Text == "Classes")
            {
                this.changes_dataGridView.DataSource = shipContext.Classes.Local.ToBindingList();
            }
            else if (makeChangesList.Text == "Outcomes")
            {
                this.changes_dataGridView.DataSource = shipContext.Outcomes.Local.ToBindingList();
            }
            else
            {
                this.changes_dataGridView.DataSource = shipContext.Battles.Local.ToBindingList();
            }


        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                shipContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

       
    }
}
