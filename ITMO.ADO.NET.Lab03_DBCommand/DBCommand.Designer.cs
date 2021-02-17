
namespace ITMO.ADO.NET.Lab03_DBCommand
{
    partial class DBCommand
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dataQuery_button = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.pktQuery_button = new System.Windows.Forms.Button();
            this.procedureCall_button = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.createTable_button = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.paramQuery_button = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.paramProcedure_button = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT CustomerID, CompanyName\r\nFROM     Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // dataQuery_button
            // 
            this.dataQuery_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataQuery_button.Location = new System.Drawing.Point(30, 26);
            this.dataQuery_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataQuery_button.Name = "dataQuery_button";
            this.dataQuery_button.Size = new System.Drawing.Size(128, 49);
            this.dataQuery_button.TabIndex = 0;
            this.dataQuery_button.Text = "Запрос данных";
            this.dataQuery_button.UseVisualStyleBackColor = true;
            this.dataQuery_button.Click += new System.EventHandler(this.dataQuery_button_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(205, 26);
            this.ResultsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(500, 275);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // pktQuery_button
            // 
            this.pktQuery_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pktQuery_button.Location = new System.Drawing.Point(30, 103);
            this.pktQuery_button.Margin = new System.Windows.Forms.Padding(4);
            this.pktQuery_button.Name = "pktQuery_button";
            this.pktQuery_button.Size = new System.Drawing.Size(128, 49);
            this.pktQuery_button.TabIndex = 0;
            this.pktQuery_button.Text = "Пакетный запрос";
            this.pktQuery_button.UseVisualStyleBackColor = true;
            this.pktQuery_button.Click += new System.EventHandler(this.pktQuery_button_Click);
            // 
            // procedureCall_button
            // 
            this.procedureCall_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.procedureCall_button.Location = new System.Drawing.Point(30, 179);
            this.procedureCall_button.Margin = new System.Windows.Forms.Padding(4);
            this.procedureCall_button.Name = "procedureCall_button";
            this.procedureCall_button.Size = new System.Drawing.Size(128, 49);
            this.procedureCall_button.TabIndex = 0;
            this.procedureCall_button.Text = "Вызов процедуры";
            this.procedureCall_button.UseVisualStyleBackColor = true;
            this.procedureCall_button.Click += new System.EventHandler(this.procedureCall_button_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // createTable_button
            // 
            this.createTable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTable_button.Location = new System.Drawing.Point(30, 252);
            this.createTable_button.Margin = new System.Windows.Forms.Padding(4);
            this.createTable_button.Name = "createTable_button";
            this.createTable_button.Size = new System.Drawing.Size(128, 49);
            this.createTable_button.TabIndex = 0;
            this.createTable_button.Text = "Создание таблицы";
            this.createTable_button.UseVisualStyleBackColor = true;
            this.createTable_button.Click += new System.EventHandler(this.createTable_button_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // paramQuery_button
            // 
            this.paramQuery_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramQuery_button.Location = new System.Drawing.Point(30, 324);
            this.paramQuery_button.Margin = new System.Windows.Forms.Padding(4);
            this.paramQuery_button.Name = "paramQuery_button";
            this.paramQuery_button.Size = new System.Drawing.Size(128, 49);
            this.paramQuery_button.TabIndex = 0;
            this.paramQuery_button.Text = "Запрос с параметром";
            this.paramQuery_button.UseVisualStyleBackColor = true;
            this.paramQuery_button.Click += new System.EventHandler(this.paramQuery_button_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(205, 324);
            this.CityTextBox.Multiline = true;
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(500, 49);
            this.CityTextBox.TabIndex = 2;
            this.CityTextBox.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar)});
            // 
            // paramProcedure_button
            // 
            this.paramProcedure_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramProcedure_button.Location = new System.Drawing.Point(30, 396);
            this.paramProcedure_button.Margin = new System.Windows.Forms.Padding(4);
            this.paramProcedure_button.Name = "paramProcedure_button";
            this.paramProcedure_button.Size = new System.Drawing.Size(128, 58);
            this.paramProcedure_button.TabIndex = 0;
            this.paramProcedure_button.Text = "Процедура с параметром";
            this.paramProcedure_button.UseVisualStyleBackColor = true;
            this.paramProcedure_button.Click += new System.EventHandler(this.paramProcedure_button_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(205, 396);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(500, 26);
            this.CategoryNameTextBox.TabIndex = 2;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(205, 428);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(500, 26);
            this.OrdYearTextBox.TabIndex = 2;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // DBCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 485);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.paramProcedure_button);
            this.Controls.Add(this.paramQuery_button);
            this.Controls.Add(this.createTable_button);
            this.Controls.Add(this.procedureCall_button);
            this.Controls.Add(this.pktQuery_button);
            this.Controls.Add(this.dataQuery_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DBCommand";
            this.Text = "Работа с данными с помощью IDE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button dataQuery_button;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button pktQuery_button;
        private System.Windows.Forms.Button procedureCall_button;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button createTable_button;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button paramQuery_button;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button paramProcedure_button;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

