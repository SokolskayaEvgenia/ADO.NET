
namespace ITMO.ADO.NET.Lab08._04_LINQsql_m
{
    partial class LINQsql_m
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
            this.TOP10_button = new System.Windows.Forms.Button();
            this.TOP10_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TOP10_button
            // 
            this.TOP10_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TOP10_button.Location = new System.Drawing.Point(12, 12);
            this.TOP10_button.Name = "TOP10_button";
            this.TOP10_button.Size = new System.Drawing.Size(106, 40);
            this.TOP10_button.TabIndex = 0;
            this.TOP10_button.Text = "TOP 10";
            this.TOP10_button.UseVisualStyleBackColor = true;
            this.TOP10_button.Click += new System.EventHandler(this.TOP10_button_Click);
            // 
            // TOP10_listView
            // 
            this.TOP10_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TOP10_listView.HideSelection = false;
            this.TOP10_listView.Location = new System.Drawing.Point(12, 67);
            this.TOP10_listView.Name = "TOP10_listView";
            this.TOP10_listView.Size = new System.Drawing.Size(416, 232);
            this.TOP10_listView.TabIndex = 1;
            this.TOP10_listView.UseCompatibleStateImageBehavior = false;
            this.TOP10_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ten Most";
            this.columnHeader1.Width = 203;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit Price";
            this.columnHeader2.Width = 134;
            // 
            // LINQsql_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 346);
            this.Controls.Add(this.TOP10_listView);
            this.Controls.Add(this.TOP10_button);
            this.Name = "LINQsql_m";
            this.Text = "Object Relational Designer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TOP10_button;
        private System.Windows.Forms.ListView TOP10_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

