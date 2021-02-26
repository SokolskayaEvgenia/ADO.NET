using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Cntrl.Lab0._01
{
    public partial class WorkWithDB : Form
    {
        public WorkWithDB()
        {
            InitializeComponent();
        }

        private void GetData_button_Click(object sender, System.EventArgs e)
        {
            //StringBuilder results = new StringBuilder();
            try
            {
                sqlCommand1.Parameters["@beginDate"].Value = Begin_dateTimePicker.Value;
                sqlCommand1.Parameters["@endDate"].Value = End_dateTimePicker.Value;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand1.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem newItem = Sales_listView.Items.Add(reader["ShipDate"].ToString());
                    newItem.SubItems.Add(reader["TotalDue"].ToString());

                    //    for (int i = 0; i < reader.FieldCount; i++)
                    //    {
                    //        results.Append(reader[i].ToString() + "\t");
                    //    }
                    //    results.Append(Environment.NewLine);
                    //}
                    //Sales_listView.Text = results.ToString();
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
