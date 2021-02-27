using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab_01
{
    public partial class ShipsViewer : Form
    {
        public ShipsViewer()
        {
            InitializeComponent();
        }

        private void loadData_button_Click(object sender, EventArgs e)
        {
            try
            {
                ships_listView.Items.Clear();
                sqlCommand1.Parameters["@fromDate"].Value = from_textBox.Text;
                sqlCommand1.Parameters["@toDate"].Value = to_textBox.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand1.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem newItem = ships_listView.Items.Add(reader["launched"].ToString());
                    newItem.SubItems.Add(reader["name"].ToString());
                    newItem.SubItems.Add(reader["class"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
    }
}
