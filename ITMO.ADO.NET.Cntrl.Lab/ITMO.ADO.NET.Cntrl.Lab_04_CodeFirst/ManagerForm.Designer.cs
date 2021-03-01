
namespace ITMO.ADO.NET.Cntrl.Lab_04_CodeFirst
{
    partial class ManagerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.addClient_button = new System.Windows.Forms.Button();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.eMail_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.clientLastName_textBox = new System.Windows.Forms.TextBox();
            this.clientFirstName_textBox = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMail_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.clientLastName_label = new System.Windows.Forms.Label();
            this.clientFirstName_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.orderInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.addOrder_button = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.ComboBox();
            this.productList = new System.Windows.Forms.ComboBox();
            this.paymentList = new System.Windows.Forms.ComboBox();
            this.deliveryList = new System.Windows.Forms.ComboBox();
            this.qty_textBox = new System.Windows.Forms.TextBox();
            this.qty_label = new System.Windows.Forms.Label();
            this.orderDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_label = new System.Windows.Forms.Label();
            this.delivery_label = new System.Windows.Forms.Label();
            this.client_label = new System.Windows.Forms.Label();
            this.product_label = new System.Windows.Forms.Label();
            this.orderDate_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.selection_groupBox = new System.Windows.Forms.GroupBox();
            this.orders_radioButton = new System.Windows.Forms.RadioButton();
            this.clients_radioButton = new System.Windows.Forms.RadioButton();
            this.view_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.clientInfo_groupBox.SuspendLayout();
            this.orderInfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.selection_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientInfo_groupBox
            // 
            this.clientInfo_groupBox.Controls.Add(this.addClient_button);
            this.clientInfo_groupBox.Controls.Add(this.phone_textBox);
            this.clientInfo_groupBox.Controls.Add(this.eMail_textBox);
            this.clientInfo_groupBox.Controls.Add(this.address_textBox);
            this.clientInfo_groupBox.Controls.Add(this.clientLastName_textBox);
            this.clientInfo_groupBox.Controls.Add(this.clientFirstName_textBox);
            this.clientInfo_groupBox.Controls.Add(this.phone_label);
            this.clientInfo_groupBox.Controls.Add(this.birthday_dateTimePicker);
            this.clientInfo_groupBox.Controls.Add(this.eMail_label);
            this.clientInfo_groupBox.Controls.Add(this.address_label);
            this.clientInfo_groupBox.Controls.Add(this.clientLastName_label);
            this.clientInfo_groupBox.Controls.Add(this.clientFirstName_label);
            this.clientInfo_groupBox.Controls.Add(this.birthday_label);
            this.clientInfo_groupBox.Location = new System.Drawing.Point(12, 12);
            this.clientInfo_groupBox.Name = "clientInfo_groupBox";
            this.clientInfo_groupBox.Size = new System.Drawing.Size(847, 160);
            this.clientInfo_groupBox.TabIndex = 0;
            this.clientInfo_groupBox.TabStop = false;
            this.clientInfo_groupBox.Text = "Client info";
            // 
            // addClient_button
            // 
            this.addClient_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClient_button.Location = new System.Drawing.Point(6, 111);
            this.addClient_button.Name = "addClient_button";
            this.addClient_button.Size = new System.Drawing.Size(142, 31);
            this.addClient_button.TabIndex = 7;
            this.addClient_button.Text = "Add New Client";
            this.addClient_button.UseVisualStyleBackColor = true;
            this.addClient_button.Click += new System.EventHandler(this.addClient_button_Click);
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(576, 83);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(255, 22);
            this.phone_textBox.TabIndex = 6;
            // 
            // eMail_textBox
            // 
            this.eMail_textBox.Location = new System.Drawing.Point(292, 83);
            this.eMail_textBox.Name = "eMail_textBox";
            this.eMail_textBox.Size = new System.Drawing.Size(255, 22);
            this.eMail_textBox.TabIndex = 5;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(6, 83);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(255, 22);
            this.address_textBox.TabIndex = 4;
            // 
            // clientLastName_textBox
            // 
            this.clientLastName_textBox.Location = new System.Drawing.Point(292, 38);
            this.clientLastName_textBox.Name = "clientLastName_textBox";
            this.clientLastName_textBox.Size = new System.Drawing.Size(255, 22);
            this.clientLastName_textBox.TabIndex = 2;
            // 
            // clientFirstName_textBox
            // 
            this.clientFirstName_textBox.Location = new System.Drawing.Point(6, 38);
            this.clientFirstName_textBox.Name = "clientFirstName_textBox";
            this.clientFirstName_textBox.Size = new System.Drawing.Size(255, 22);
            this.clientFirstName_textBox.TabIndex = 1;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(573, 63);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(49, 17);
            this.phone_label.TabIndex = 2;
            this.phone_label.Text = "Phone";
            // 
            // birthday_dateTimePicker
            // 
            this.birthday_dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.birthday_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthday_dateTimePicker.Location = new System.Drawing.Point(576, 38);
            this.birthday_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            this.birthday_dateTimePicker.Size = new System.Drawing.Size(150, 22);
            this.birthday_dateTimePicker.TabIndex = 3;
            this.birthday_dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.birthday_dateTimePicker_Validating);
            // 
            // eMail_label
            // 
            this.eMail_label.AutoSize = true;
            this.eMail_label.Location = new System.Drawing.Point(289, 63);
            this.eMail_label.Name = "eMail_label";
            this.eMail_label.Size = new System.Drawing.Size(46, 17);
            this.eMail_label.TabIndex = 2;
            this.eMail_label.Text = "e-mail";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(3, 63);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 17);
            this.address_label.TabIndex = 2;
            this.address_label.Text = "Address";
            // 
            // clientLastName_label
            // 
            this.clientLastName_label.AutoSize = true;
            this.clientLastName_label.Location = new System.Drawing.Point(289, 18);
            this.clientLastName_label.Name = "clientLastName_label";
            this.clientLastName_label.Size = new System.Drawing.Size(76, 17);
            this.clientLastName_label.TabIndex = 1;
            this.clientLastName_label.Text = "Last Name";
            // 
            // clientFirstName_label
            // 
            this.clientFirstName_label.AutoSize = true;
            this.clientFirstName_label.Location = new System.Drawing.Point(3, 18);
            this.clientFirstName_label.Name = "clientFirstName_label";
            this.clientFirstName_label.Size = new System.Drawing.Size(76, 17);
            this.clientFirstName_label.TabIndex = 0;
            this.clientFirstName_label.Text = "First Name";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Location = new System.Drawing.Point(573, 18);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(62, 17);
            this.birthday_label.TabIndex = 0;
            this.birthday_label.Text = "BirthDay";
            // 
            // orderInfo_groupBox
            // 
            this.orderInfo_groupBox.Controls.Add(this.addOrder_button);
            this.orderInfo_groupBox.Controls.Add(this.clientList);
            this.orderInfo_groupBox.Controls.Add(this.productList);
            this.orderInfo_groupBox.Controls.Add(this.paymentList);
            this.orderInfo_groupBox.Controls.Add(this.deliveryList);
            this.orderInfo_groupBox.Controls.Add(this.qty_textBox);
            this.orderInfo_groupBox.Controls.Add(this.qty_label);
            this.orderInfo_groupBox.Controls.Add(this.orderDate_dateTimePicker);
            this.orderInfo_groupBox.Controls.Add(this.payment_label);
            this.orderInfo_groupBox.Controls.Add(this.delivery_label);
            this.orderInfo_groupBox.Controls.Add(this.client_label);
            this.orderInfo_groupBox.Controls.Add(this.product_label);
            this.orderInfo_groupBox.Controls.Add(this.orderDate_label);
            this.orderInfo_groupBox.Location = new System.Drawing.Point(12, 178);
            this.orderInfo_groupBox.Name = "orderInfo_groupBox";
            this.orderInfo_groupBox.Size = new System.Drawing.Size(847, 154);
            this.orderInfo_groupBox.TabIndex = 8;
            this.orderInfo_groupBox.TabStop = false;
            this.orderInfo_groupBox.Text = "Order info";
            // 
            // addOrder_button
            // 
            this.addOrder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrder_button.Location = new System.Drawing.Point(9, 113);
            this.addOrder_button.Name = "addOrder_button";
            this.addOrder_button.Size = new System.Drawing.Size(142, 31);
            this.addOrder_button.TabIndex = 15;
            this.addOrder_button.Text = "Add Order";
            this.addOrder_button.UseVisualStyleBackColor = true;
            this.addOrder_button.Click += new System.EventHandler(this.addOrder_button_Click);
            // 
            // clientList
            // 
            this.clientList.FormattingEnabled = true;
            this.clientList.Items.AddRange(new object[] {
            "Твикс",
            "Марс",
            "Сникерс",
            "Баунти",
            "Плитки шоколадные",
            "Конфеты шоколадные",
            "Карамели",
            "Карамельные леденцы",
            "Мармелад",
            "Вафли",
            "Пряники",
            "Пряники к чаю",
            "Печенье \"Эсмеральда\"",
            "Печенье ювелирное",
            "Печенье овсяное",
            "Печенье утреннее",
            "Печенье \"Юбилейное\"",
            "Кексы",
            "Мини рулеты",
            "Рулеты",
            "Коржи бисквитные",
            "Сухари \"Киевские\"",
            "Сушки",
            "Орбит",
            "Дирол",
            "Холлс"});
            this.clientList.Location = new System.Drawing.Point(257, 38);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(220, 24);
            this.clientList.TabIndex = 10;
            this.clientList.Enter += new System.EventHandler(this.clientList_Enter);
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Items.AddRange(new object[] {
            "Твикс",
            "Марс",
            "Сникерс",
            "Баунти",
            "Плитки шоколадные",
            "Конфеты шоколадные",
            "Карамели",
            "Карамельные леденцы",
            "Мармелад",
            "Вафли",
            "Пряники",
            "Пряники к чаю",
            "Печенье \"Эсмеральда\"",
            "Печенье ювелирное",
            "Печенье овсяное",
            "Печенье утреннее",
            "Печенье \"Юбилейное\"",
            "Кексы",
            "Мини рулеты",
            "Рулеты",
            "Коржи бисквитные",
            "Сухари \"Киевские\"",
            "Сушки",
            "Орбит",
            "Дирол",
            "Холлс"});
            this.productList.Location = new System.Drawing.Point(9, 83);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(220, 24);
            this.productList.TabIndex = 11;
            // 
            // paymentList
            // 
            this.paymentList.FormattingEnabled = true;
            this.paymentList.Items.AddRange(new object[] {
            "Нал",
            "Б/н"});
            this.paymentList.Location = new System.Drawing.Point(544, 83);
            this.paymentList.Name = "paymentList";
            this.paymentList.Size = new System.Drawing.Size(78, 24);
            this.paymentList.TabIndex = 14;
            // 
            // deliveryList
            // 
            this.deliveryList.FormattingEnabled = true;
            this.deliveryList.Items.AddRange(new object[] {
            "Курьер",
            "Почта",
            "Самовывоз"});
            this.deliveryList.Location = new System.Drawing.Point(369, 83);
            this.deliveryList.Name = "deliveryList";
            this.deliveryList.Size = new System.Drawing.Size(139, 24);
            this.deliveryList.TabIndex = 13;
            // 
            // qty_textBox
            // 
            this.qty_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qty_textBox.Location = new System.Drawing.Point(257, 83);
            this.qty_textBox.Name = "qty_textBox";
            this.qty_textBox.Size = new System.Drawing.Size(78, 24);
            this.qty_textBox.TabIndex = 12;
            // 
            // qty_label
            // 
            this.qty_label.AutoSize = true;
            this.qty_label.Location = new System.Drawing.Point(254, 63);
            this.qty_label.Name = "qty_label";
            this.qty_label.Size = new System.Drawing.Size(30, 17);
            this.qty_label.TabIndex = 0;
            this.qty_label.Text = "Qty";
            // 
            // orderDate_dateTimePicker
            // 
            this.orderDate_dateTimePicker.Location = new System.Drawing.Point(6, 38);
            this.orderDate_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.orderDate_dateTimePicker.Name = "orderDate_dateTimePicker";
            this.orderDate_dateTimePicker.Size = new System.Drawing.Size(150, 22);
            this.orderDate_dateTimePicker.TabIndex = 9;
            this.orderDate_dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.orderDate_dateTimePicker_Validating);
            // 
            // payment_label
            // 
            this.payment_label.AutoSize = true;
            this.payment_label.Location = new System.Drawing.Point(541, 63);
            this.payment_label.Name = "payment_label";
            this.payment_label.Size = new System.Drawing.Size(63, 17);
            this.payment_label.TabIndex = 0;
            this.payment_label.Text = "Payment";
            // 
            // delivery_label
            // 
            this.delivery_label.AutoSize = true;
            this.delivery_label.Location = new System.Drawing.Point(366, 63);
            this.delivery_label.Name = "delivery_label";
            this.delivery_label.Size = new System.Drawing.Size(59, 17);
            this.delivery_label.TabIndex = 0;
            this.delivery_label.Text = "Delivery";
            // 
            // client_label
            // 
            this.client_label.AutoSize = true;
            this.client_label.Location = new System.Drawing.Point(254, 18);
            this.client_label.Name = "client_label";
            this.client_label.Size = new System.Drawing.Size(43, 17);
            this.client_label.TabIndex = 0;
            this.client_label.Text = "Client";
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Location = new System.Drawing.Point(6, 63);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(57, 17);
            this.product_label.TabIndex = 0;
            this.product_label.Text = "Product";
            // 
            // orderDate_label
            // 
            this.orderDate_label.AutoSize = true;
            this.orderDate_label.Location = new System.Drawing.Point(3, 18);
            this.orderDate_label.Name = "orderDate_label";
            this.orderDate_label.Size = new System.Drawing.Size(38, 17);
            this.orderDate_label.TabIndex = 0;
            this.orderDate_label.Text = "Date";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 396);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(847, 194);
            this.dataGridView.TabIndex = 4;
            // 
            // selection_groupBox
            // 
            this.selection_groupBox.Controls.Add(this.orders_radioButton);
            this.selection_groupBox.Controls.Add(this.clients_radioButton);
            this.selection_groupBox.Location = new System.Drawing.Point(12, 338);
            this.selection_groupBox.Name = "selection_groupBox";
            this.selection_groupBox.Size = new System.Drawing.Size(189, 52);
            this.selection_groupBox.TabIndex = 16;
            this.selection_groupBox.TabStop = false;
            this.selection_groupBox.Text = "Data Selection";
            // 
            // orders_radioButton
            // 
            this.orders_radioButton.AutoSize = true;
            this.orders_radioButton.Location = new System.Drawing.Point(107, 21);
            this.orders_radioButton.Name = "orders_radioButton";
            this.orders_radioButton.Size = new System.Drawing.Size(73, 21);
            this.orders_radioButton.TabIndex = 18;
            this.orders_radioButton.TabStop = true;
            this.orders_radioButton.Text = "Orders";
            this.orders_radioButton.UseVisualStyleBackColor = true;
            // 
            // clients_radioButton
            // 
            this.clients_radioButton.AutoSize = true;
            this.clients_radioButton.Location = new System.Drawing.Point(9, 21);
            this.clients_radioButton.Name = "clients_radioButton";
            this.clients_radioButton.Size = new System.Drawing.Size(71, 21);
            this.clients_radioButton.TabIndex = 17;
            this.clients_radioButton.TabStop = true;
            this.clients_radioButton.Text = "Clients";
            this.clients_radioButton.UseVisualStyleBackColor = true;
            // 
            // view_button
            // 
            this.view_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view_button.Location = new System.Drawing.Point(244, 359);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(142, 31);
            this.view_button.TabIndex = 19;
            this.view_button.Text = "View";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(407, 359);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(142, 31);
            this.delete_button.TabIndex = 20;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(568, 359);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(142, 31);
            this.edit_button.TabIndex = 21;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 602);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.selection_groupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.orderInfo_groupBox);
            this.Controls.Add(this.clientInfo_groupBox);
            this.Name = "ManagerForm";
            this.Text = "Manager Form";
            this.clientInfo_groupBox.ResumeLayout(false);
            this.clientInfo_groupBox.PerformLayout();
            this.orderInfo_groupBox.ResumeLayout(false);
            this.orderInfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.selection_groupBox.ResumeLayout(false);
            this.selection_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientInfo_groupBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox eMail_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox clientLastName_textBox;
        private System.Windows.Forms.TextBox clientFirstName_textBox;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label eMail_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label clientLastName_label;
        private System.Windows.Forms.Label clientFirstName_label;
        private System.Windows.Forms.GroupBox orderInfo_groupBox;
        private System.Windows.Forms.ComboBox deliveryList;
        private System.Windows.Forms.TextBox qty_textBox;
        private System.Windows.Forms.Label qty_label;
        private System.Windows.Forms.DateTimePicker orderDate_dateTimePicker;
        private System.Windows.Forms.Label delivery_label;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.Label orderDate_label;
        private System.Windows.Forms.ComboBox productList;
        private System.Windows.Forms.ComboBox paymentList;
        private System.Windows.Forms.Label payment_label;
        private System.Windows.Forms.Button addClient_button;
        private System.Windows.Forms.Button addOrder_button;
        private System.Windows.Forms.ComboBox clientList;
        private System.Windows.Forms.Label client_label;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox selection_groupBox;
        private System.Windows.Forms.RadioButton orders_radioButton;
        private System.Windows.Forms.RadioButton clients_radioButton;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.DateTimePicker birthday_dateTimePicker;
        private System.Windows.Forms.Label birthday_label;
    }
}

