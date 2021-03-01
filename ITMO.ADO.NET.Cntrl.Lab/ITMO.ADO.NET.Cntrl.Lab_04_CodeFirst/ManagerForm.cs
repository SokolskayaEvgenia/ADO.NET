using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static SomeShop.Model;

namespace ITMO.ADO.NET.Cntrl.Lab_04_CodeFirst
{
    public partial class ManagerForm : Form
    {
        SampleContext context = new SampleContext();


        public ManagerForm()
        {
            InitializeComponent();
            Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        private void orderDate_dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (orderDate_dateTimePicker.Value == DateTime.Now)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Выбранная дата не может быть меньше текущей");
            }
        }

        private void birthday_dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (birthday_dateTimePicker.Value < DateTime.Now)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Выбранная дата не может быть больше текущей");
            }
        }

        private void addClient_button_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client
                {
                    FirstName = this.clientFirstName_textBox.Text,
                    LastName = this.clientLastName_textBox.Text,
                    BirthDay = this.birthday_dateTimePicker.Value,
                    Address = this.address_textBox.Text,
                    Email = this.eMail_textBox.Text,
                    Phone = this.phone_textBox.Text,
                };
                context.Clients.Add(client);
                context.SaveChanges();
                clientFirstName_textBox.Text = String.Empty;
                clientLastName_textBox.Text = String.Empty;
                birthday_dateTimePicker.Value = DateTime.Now;
                address_textBox.Text = String.Empty;
                eMail_textBox.Text = String.Empty;
                phone_textBox.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void addOrder_button_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order
                {
                    OrderDate = this.orderDate_dateTimePicker.Value,
                    Client = (Client)this.clientList.SelectedItem,
                    ProductName = this.productList.SelectedItem.ToString(),
                    Quantity = Convert.ToInt32(this.qty_textBox.Text),
                    Delivery = this.deliveryList.SelectedItem.ToString(),
                    Payment = this.paymentList.SelectedItem.ToString()
                };
                context.Orders.Add(order);
                context.SaveChanges();
                orderDate_dateTimePicker.Value = DateTime.Now;
                clientList.Text = String.Empty;
                productList.Text = String.Empty;
                qty_textBox.Text = String.Empty;
                deliveryList.Text = String.Empty;
                paymentList.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void clientList_Enter(object sender, EventArgs e)
        {
            clientList.DataSource = context.Clients.ToList();
        }

        private void Output()
        {
            if (this.clients_radioButton.Checked == true)
                dataGridView.DataSource = context.Clients.ToList();
            else if (this.orders_radioButton.Checked == true)
                dataGridView.DataSource = context.Orders.ToList();
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            this.Output();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.clients_radioButton.Checked == true)
                {
                    dataGridView.DataSource = context.Clients.Local.ToBindingList();
                    int index = dataGridView.CurrentCell.RowIndex;
                    dataGridView.Rows.RemoveAt(index);
                    context.SaveChanges();
                    Refresh();

                }
                else if (this.orders_radioButton.Checked == true)
                {
                    dataGridView.DataSource = context.Orders.Local.ToBindingList();
                    int index = dataGridView.CurrentCell.RowIndex;
                    dataGridView.Rows.RemoveAt(index);
                    context.SaveChanges();
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.clients_radioButton.Checked == true)
                {
                    dataGridView.DataSource = context.Clients.Local.ToBindingList();
                    context.SaveChanges();
                    Refresh();

                }
                else if (this.orders_radioButton.Checked == true)
                {
                    dataGridView.DataSource = context.Orders.Local.ToBindingList();
                    context.SaveChanges();
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }


        }
    }
}
