
namespace ITMO.ADO.NET.Cntrl.Lab0._01
{
    partial class WorkWithDB
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
            this.GetData_button = new System.Windows.Forms.Button();
            this.Begin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.End_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BeginDate_label = new System.Windows.Forms.Label();
            this.EndDate_label = new System.Windows.Forms.Label();
            this.Sales_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // GetData_button
            // 
            this.GetData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetData_button.Location = new System.Drawing.Point(12, 74);
            this.GetData_button.Name = "GetData_button";
            this.GetData_button.Size = new System.Drawing.Size(224, 38);
            this.GetData_button.TabIndex = 0;
            this.GetData_button.Text = "Получить данные";
            this.GetData_button.UseVisualStyleBackColor = true;
            this.GetData_button.Click += new System.EventHandler(this.GetData_button_Click);
            // 
            // Begin_dateTimePicker
            // 
            this.Begin_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Begin_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Begin_dateTimePicker.Location = new System.Drawing.Point(12, 42);
            this.Begin_dateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.Begin_dateTimePicker.Name = "Begin_dateTimePicker";
            this.Begin_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.Begin_dateTimePicker.TabIndex = 1;
            this.Begin_dateTimePicker.Value = new System.DateTime(2021, 2, 24, 0, 9, 50, 0);
            // 
            // End_dateTimePicker
            // 
            this.End_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_dateTimePicker.Location = new System.Drawing.Point(237, 42);
            this.End_dateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.End_dateTimePicker.Name = "End_dateTimePicker";
            this.End_dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.End_dateTimePicker.TabIndex = 1;
            this.End_dateTimePicker.Value = new System.DateTime(2021, 2, 24, 0, 9, 50, 0);
            // 
            // BeginDate_label
            // 
            this.BeginDate_label.AutoSize = true;
            this.BeginDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginDate_label.Location = new System.Drawing.Point(8, 18);
            this.BeginDate_label.Name = "BeginDate_label";
            this.BeginDate_label.Size = new System.Drawing.Size(149, 20);
            this.BeginDate_label.TabIndex = 2;
            this.BeginDate_label.Text = "Начало периода";
            // 
            // EndDate_label
            // 
            this.EndDate_label.AutoSize = true;
            this.EndDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDate_label.Location = new System.Drawing.Point(233, 18);
            this.EndDate_label.Name = "EndDate_label";
            this.EndDate_label.Size = new System.Drawing.Size(137, 20);
            this.EndDate_label.TabIndex = 2;
            this.EndDate_label.Text = "Конец периода";
            // 
            // Sales_listView
            // 
            this.Sales_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Sales_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sales_listView.HideSelection = false;
            this.Sales_listView.Location = new System.Drawing.Point(0, 118);
            this.Sales_listView.Name = "Sales_listView";
            this.Sales_listView.Size = new System.Drawing.Size(536, 332);
            this.Sales_listView.TabIndex = 3;
            this.Sales_listView.UseCompatibleStateImageBehavior = false;
            this.Sales_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата отгрузки";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Объем продаж";
            this.columnHeader2.Width = 262;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT ShipDate, TotalDue\r\nFROM     Sales.SalesOrderHeader\r\nWHERE  (ShipDate BETW" +
    "EEN @beginDate AND @endDate)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@beginDate", System.Data.SqlDbType.DateTime, 8, "ShipDate"),
            new System.Data.SqlClient.SqlParameter("@endDate", System.Data.SqlDbType.DateTime, 8, "ShipDate")});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-GM9543R\\SQLEXPRESS;Initial Catalog=AdventureWorks2017;Integra" +
    "ted Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // WorkWithDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.Sales_listView);
            this.Controls.Add(this.EndDate_label);
            this.Controls.Add(this.BeginDate_label);
            this.Controls.Add(this.End_dateTimePicker);
            this.Controls.Add(this.Begin_dateTimePicker);
            this.Controls.Add(this.GetData_button);
            this.Name = "WorkWithDB";
            this.Text = "Work with DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetData_button;
        private System.Windows.Forms.DateTimePicker Begin_dateTimePicker;
        private System.Windows.Forms.DateTimePicker End_dateTimePicker;
        private System.Windows.Forms.Label BeginDate_label;
        private System.Windows.Forms.Label EndDate_label;
        private System.Windows.Forms.ListView Sales_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}

