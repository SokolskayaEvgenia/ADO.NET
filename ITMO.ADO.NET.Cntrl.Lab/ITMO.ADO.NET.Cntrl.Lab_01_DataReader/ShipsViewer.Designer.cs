
namespace ITMO.ADO.NET.Cntrl.Lab_01
{
    partial class ShipsViewer
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
            this.launch_groupBox = new System.Windows.Forms.GroupBox();
            this.from_label = new System.Windows.Forms.Label();
            this.to_label = new System.Windows.Forms.Label();
            this.ships_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadData_button = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.from_textBox = new System.Windows.Forms.TextBox();
            this.to_textBox = new System.Windows.Forms.TextBox();
            this.launch_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // launch_groupBox
            // 
            this.launch_groupBox.Controls.Add(this.to_textBox);
            this.launch_groupBox.Controls.Add(this.from_textBox);
            this.launch_groupBox.Controls.Add(this.to_label);
            this.launch_groupBox.Controls.Add(this.from_label);
            this.launch_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.launch_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.launch_groupBox.Location = new System.Drawing.Point(0, 0);
            this.launch_groupBox.Name = "launch_groupBox";
            this.launch_groupBox.Size = new System.Drawing.Size(626, 81);
            this.launch_groupBox.TabIndex = 0;
            this.launch_groupBox.TabStop = false;
            this.launch_groupBox.Text = "Launched";
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.Location = new System.Drawing.Point(12, 34);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(43, 20);
            this.from_label.TabIndex = 2;
            this.from_label.Text = "from";
            this.from_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(198, 34);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(23, 20);
            this.to_label.TabIndex = 2;
            this.to_label.Text = "to";
            this.to_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ships_listView
            // 
            this.ships_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ships_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ships_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ships_listView.HideSelection = false;
            this.ships_listView.Location = new System.Drawing.Point(0, 150);
            this.ships_listView.Name = "ships_listView";
            this.ships_listView.Size = new System.Drawing.Size(626, 300);
            this.ships_listView.TabIndex = 1;
            this.ships_listView.UseCompatibleStateImageBehavior = false;
            this.ships_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Launched";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Class";
            this.columnHeader3.Width = 150;
            // 
            // loadData_button
            // 
            this.loadData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadData_button.Location = new System.Drawing.Point(16, 95);
            this.loadData_button.Name = "loadData_button";
            this.loadData_button.Size = new System.Drawing.Size(231, 36);
            this.loadData_button.TabIndex = 2;
            this.loadData_button.Text = "Load Data";
            this.loadData_button.UseVisualStyleBackColor = true;
            this.loadData_button.Click += new System.EventHandler(this.loadData_button_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Ships;Integrated Security=True" +
    "";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT launched, name, class\r\nFROM     Ships\r\nWHERE  (launched BETWEEN @fromDate " +
    "AND @toDate)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fromDate", System.Data.SqlDbType.SmallInt, 2, "launched"),
            new System.Data.SqlClient.SqlParameter("@toDate", System.Data.SqlDbType.SmallInt, 2, "launched")});
            // 
            // from_textBox
            // 
            this.from_textBox.Location = new System.Drawing.Point(61, 34);
            this.from_textBox.Name = "from_textBox";
            this.from_textBox.Size = new System.Drawing.Size(100, 26);
            this.from_textBox.TabIndex = 3;
            // 
            // to_textBox
            // 
            this.to_textBox.Location = new System.Drawing.Point(227, 34);
            this.to_textBox.Name = "to_textBox";
            this.to_textBox.Size = new System.Drawing.Size(100, 26);
            this.to_textBox.TabIndex = 4;
            // 
            // ShipsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.loadData_button);
            this.Controls.Add(this.ships_listView);
            this.Controls.Add(this.launch_groupBox);
            this.Name = "ShipsViewer";
            this.Text = "Ships Viewer";
            this.launch_groupBox.ResumeLayout(false);
            this.launch_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox launch_groupBox;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Label from_label;
        private System.Windows.Forms.ListView ships_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button loadData_button;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox to_textBox;
        private System.Windows.Forms.TextBox from_textBox;
    }
}

