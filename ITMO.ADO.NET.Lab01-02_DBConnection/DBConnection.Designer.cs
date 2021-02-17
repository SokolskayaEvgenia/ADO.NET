
namespace ITMO.ADO.NET.Lab01.Ex._2_DBConnection
{
    partial class DBConnection
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.WorkWithDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsyncConnectToDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productQnty_button = new System.Windows.Forms.Button();
            this.answer_textBox = new System.Windows.Forms.TextBox();
            this.productQnty_button2 = new System.Windows.Forms.Button();
            this.answer_textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.productList_button = new System.Windows.Forms.Button();
            this.productList_listView = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityPerUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transaction_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkWithDB_ToolStripMenuItem,
            this.connectionList_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // WorkWithDB_ToolStripMenuItem
            // 
            this.WorkWithDB_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToDB_ToolStripMenuItem,
            this.DisconnectDB_ToolStripMenuItem,
            this.AsyncConnectToDB_ToolStripMenuItem});
            this.WorkWithDB_ToolStripMenuItem.Name = "WorkWithDB_ToolStripMenuItem";
            this.WorkWithDB_ToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.WorkWithDB_ToolStripMenuItem.Text = "Работа с базой данных";
            // 
            // ConnectToDB_ToolStripMenuItem
            // 
            this.ConnectToDB_ToolStripMenuItem.Name = "ConnectToDB_ToolStripMenuItem";
            this.ConnectToDB_ToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.ConnectToDB_ToolStripMenuItem.Text = "Подключиться к БД";
            this.ConnectToDB_ToolStripMenuItem.Click += new System.EventHandler(this.ConnectToDB_ToolStripMenuItem_Click);
            // 
            // DisconnectDB_ToolStripMenuItem
            // 
            this.DisconnectDB_ToolStripMenuItem.Name = "DisconnectDB_ToolStripMenuItem";
            this.DisconnectDB_ToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.DisconnectDB_ToolStripMenuItem.Text = "Отключиться от БД";
            this.DisconnectDB_ToolStripMenuItem.Click += new System.EventHandler(this.DisconnectDB_ToolStripMenuItem_Click);
            // 
            // AsyncConnectToDB_ToolStripMenuItem
            // 
            this.AsyncConnectToDB_ToolStripMenuItem.Name = "AsyncConnectToDB_ToolStripMenuItem";
            this.AsyncConnectToDB_ToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.AsyncConnectToDB_ToolStripMenuItem.Text = "Асинхронное подключение к БД";
            this.AsyncConnectToDB_ToolStripMenuItem.Click += new System.EventHandler(this.AsyncConnectToDB_ToolStripMenuItem_Click);
            // 
            // connectionList_ToolStripMenuItem
            // 
            this.connectionList_ToolStripMenuItem.Name = "connectionList_ToolStripMenuItem";
            this.connectionList_ToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.connectionList_ToolStripMenuItem.Text = "Список подключений";
            this.connectionList_ToolStripMenuItem.Click += new System.EventHandler(this.connectionList_ToolStripMenuItem_Click);
            // 
            // productQnty_button
            // 
            this.productQnty_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQnty_button.Location = new System.Drawing.Point(12, 65);
            this.productQnty_button.Name = "productQnty_button";
            this.productQnty_button.Size = new System.Drawing.Size(200, 33);
            this.productQnty_button.TabIndex = 2;
            this.productQnty_button.Text = "Сколько продуктов";
            this.productQnty_button.UseVisualStyleBackColor = true;
            this.productQnty_button.Click += new System.EventHandler(this.productQnty_button_Click);
            // 
            // answer_textBox
            // 
            this.answer_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_textBox.Location = new System.Drawing.Point(238, 68);
            this.answer_textBox.Name = "answer_textBox";
            this.answer_textBox.Size = new System.Drawing.Size(100, 26);
            this.answer_textBox.TabIndex = 4;
            // 
            // productQnty_button2
            // 
            this.productQnty_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQnty_button2.Location = new System.Drawing.Point(381, 65);
            this.productQnty_button2.Name = "productQnty_button2";
            this.productQnty_button2.Size = new System.Drawing.Size(200, 33);
            this.productQnty_button2.TabIndex = 3;
            this.productQnty_button2.Text = "Сколько продуктов 2";
            this.toolTip1.SetToolTip(this.productQnty_button2, "реализация метода в блоке using");
            this.productQnty_button2.UseVisualStyleBackColor = true;
            this.productQnty_button2.Click += new System.EventHandler(this.productQnty_button2_Click);
            // 
            // answer_textBox2
            // 
            this.answer_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_textBox2.Location = new System.Drawing.Point(610, 68);
            this.answer_textBox2.Name = "answer_textBox2";
            this.answer_textBox2.Size = new System.Drawing.Size(100, 26);
            this.answer_textBox2.TabIndex = 5;
            // 
            // productList_button
            // 
            this.productList_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productList_button.Location = new System.Drawing.Point(12, 136);
            this.productList_button.Name = "productList_button";
            this.productList_button.Size = new System.Drawing.Size(200, 33);
            this.productList_button.TabIndex = 3;
            this.productList_button.Text = "Список продуктов";
            this.productList_button.UseVisualStyleBackColor = true;
            this.productList_button.Click += new System.EventHandler(this.productList_button_Click);
            // 
            // productList_listView
            // 
            this.productList_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.UnitPrice,
            this.QuantityPerUnit});
            this.productList_listView.HideSelection = false;
            this.productList_listView.Location = new System.Drawing.Point(238, 136);
            this.productList_listView.Name = "productList_listView";
            this.productList_listView.Size = new System.Drawing.Size(535, 200);
            this.productList_listView.TabIndex = 6;
            this.productList_listView.UseCompatibleStateImageBehavior = false;
            this.productList_listView.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Название продукта";
            this.ProductName.Width = 180;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Цена";
            this.UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPrice.Width = 86;
            // 
            // QuantityPerUnit
            // 
            this.QuantityPerUnit.Text = "Фасовка";
            this.QuantityPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityPerUnit.Width = 150;
            // 
            // transaction_button
            // 
            this.transaction_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transaction_button.Location = new System.Drawing.Point(12, 355);
            this.transaction_button.Name = "transaction_button";
            this.transaction_button.Size = new System.Drawing.Size(200, 33);
            this.transaction_button.TabIndex = 3;
            this.transaction_button.Text = "Транзакция";
            this.transaction_button.UseVisualStyleBackColor = true;
            this.transaction_button.Click += new System.EventHandler(this.transaction_button_Click);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 411);
            this.Controls.Add(this.productList_listView);
            this.Controls.Add(this.answer_textBox2);
            this.Controls.Add(this.answer_textBox);
            this.Controls.Add(this.transaction_button);
            this.Controls.Add(this.productList_button);
            this.Controls.Add(this.productQnty_button2);
            this.Controls.Add(this.productQnty_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBConnection";
            this.Text = "Соединение с БД и выполнение команд";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem WorkWithDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AsyncConnectToDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionList_ToolStripMenuItem;
        private System.Windows.Forms.Button productQnty_button;
        private System.Windows.Forms.TextBox answer_textBox;
        private System.Windows.Forms.Button productQnty_button2;
        private System.Windows.Forms.TextBox answer_textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button productList_button;
        private System.Windows.Forms.ListView productList_listView;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader QuantityPerUnit;
        private System.Windows.Forms.Button transaction_button;
    }
}

