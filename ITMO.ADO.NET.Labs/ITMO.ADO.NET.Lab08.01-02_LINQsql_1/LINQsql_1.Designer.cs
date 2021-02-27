
namespace ITMO.ADO.NET.Lab08._01_LINQsql_1
{
    partial class LINQsql_1
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
            this.LoadData_button = new System.Windows.Forms.Button();
            this.ClearList_button = new System.Windows.Forms.Button();
            this.AddObj_button = new System.Windows.Forms.Button();
            this.DeleteObj_button = new System.Windows.Forms.Button();
            this.MainListBox = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadRelatedData_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadData_button
            // 
            this.LoadData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadData_button.Location = new System.Drawing.Point(39, 13);
            this.LoadData_button.Name = "LoadData_button";
            this.LoadData_button.Size = new System.Drawing.Size(175, 33);
            this.LoadData_button.TabIndex = 0;
            this.LoadData_button.Text = "Загрузка данных";
            this.LoadData_button.UseVisualStyleBackColor = true;
            this.LoadData_button.Click += new System.EventHandler(this.LoadData_button_Click);
            // 
            // ClearList_button
            // 
            this.ClearList_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearList_button.Location = new System.Drawing.Point(229, 13);
            this.ClearList_button.Name = "ClearList_button";
            this.ClearList_button.Size = new System.Drawing.Size(175, 33);
            this.ClearList_button.TabIndex = 1;
            this.ClearList_button.Text = "Очистить список";
            this.ClearList_button.UseVisualStyleBackColor = true;
            this.ClearList_button.Click += new System.EventHandler(this.ClearList_button_Click);
            // 
            // AddObj_button
            // 
            this.AddObj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddObj_button.Location = new System.Drawing.Point(419, 13);
            this.AddObj_button.Name = "AddObj_button";
            this.AddObj_button.Size = new System.Drawing.Size(175, 33);
            this.AddObj_button.TabIndex = 2;
            this.AddObj_button.Text = "Добавить объект";
            this.AddObj_button.UseVisualStyleBackColor = true;
            this.AddObj_button.Click += new System.EventHandler(this.AddObj_button_Click);
            // 
            // DeleteObj_button
            // 
            this.DeleteObj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteObj_button.Location = new System.Drawing.Point(613, 13);
            this.DeleteObj_button.Name = "DeleteObj_button";
            this.DeleteObj_button.Size = new System.Drawing.Size(175, 33);
            this.DeleteObj_button.TabIndex = 3;
            this.DeleteObj_button.Text = "Удалить объект";
            this.DeleteObj_button.UseVisualStyleBackColor = true;
            this.DeleteObj_button.Click += new System.EventHandler(this.DeleteObj_button_Click);
            // 
            // MainListBox
            // 
            this.MainListBox.FormattingEnabled = true;
            this.MainListBox.ItemHeight = 16;
            this.MainListBox.Location = new System.Drawing.Point(39, 73);
            this.MainListBox.Name = "MainListBox";
            this.MainListBox.Size = new System.Drawing.Size(749, 132);
            this.MainListBox.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 216);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(749, 203);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CustomerID";
            this.columnHeader1.Width = 221;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City";
            this.columnHeader2.Width = 244;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OrdersCount";
            this.columnHeader3.Width = 232;
            // 
            // LoadRelatedData_button
            // 
            this.LoadRelatedData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadRelatedData_button.Location = new System.Drawing.Point(39, 425);
            this.LoadRelatedData_button.Name = "LoadRelatedData_button";
            this.LoadRelatedData_button.Size = new System.Drawing.Size(316, 33);
            this.LoadRelatedData_button.TabIndex = 4;
            this.LoadRelatedData_button.Text = "Загрузка связанных данных";
            this.LoadRelatedData_button.UseVisualStyleBackColor = true;
            this.LoadRelatedData_button.Click += new System.EventHandler(this.LoadRelatedData_button_Click);
            // 
            // LINQsql_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 470);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MainListBox);
            this.Controls.Add(this.DeleteObj_button);
            this.Controls.Add(this.AddObj_button);
            this.Controls.Add(this.ClearList_button);
            this.Controls.Add(this.LoadRelatedData_button);
            this.Controls.Add(this.LoadData_button);
            this.Name = "LINQsql_1";
            this.Text = "Использование LINQ to SQL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadData_button;
        private System.Windows.Forms.Button ClearList_button;
        private System.Windows.Forms.Button AddObj_button;
        private System.Windows.Forms.Button DeleteObj_button;
        private System.Windows.Forms.ListBox MainListBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button LoadRelatedData_button;
    }
}

