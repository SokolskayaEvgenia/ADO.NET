using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab08._03_LINQsqlSproc
{
    public partial class LINQsqlSproc : Form
    {
        public LINQsqlSproc()
        {
            InitializeComponent();
        }

        Northwnd db = new Northwnd(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");

        private void OrderDetails_button_Click(object sender, EventArgs e)
        {
            string param = OrderID_textBox.Text;
            var custquery = db.CustOrdersDetail(Convert.ToInt32(param));
            string msg = "";
            foreach (CustOrdersDetailResult custOrdersDetail in custquery)
            {
                msg = msg + custOrdersDetail.ProductName + "\n";
            }
            if (msg == "")
                msg = "No results.";
            MessageBox.Show(msg);
            param = "";
            OrderID_textBox.Text = "";

        }

        private void OrderHistory_button_Click(object sender, EventArgs e)
        {
            string param = CustomerID_textBox.Text;
            var custquery = db.CustOrderHist(param);
            string msg = "";
            foreach (CustOrderHistResult custOrdHist in custquery)
            {
                msg = msg + custOrdHist.ProductName + "\n";
            }
            MessageBox.Show(msg);
            param = "";
            CustomerID_textBox.Text = "";
        }
    }
}
