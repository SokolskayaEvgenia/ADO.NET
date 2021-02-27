
namespace ITMO.ADO.NET.Lab08._03_LINQsqlSproc
{
    partial class LINQsqlSproc
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
            this.OrderID_label = new System.Windows.Forms.Label();
            this.CustomerID_label = new System.Windows.Forms.Label();
            this.OrderID_textBox = new System.Windows.Forms.TextBox();
            this.CustomerID_textBox = new System.Windows.Forms.TextBox();
            this.OrderDetails_button = new System.Windows.Forms.Button();
            this.OrderHistory_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderID_label
            // 
            this.OrderID_label.AutoSize = true;
            this.OrderID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderID_label.Location = new System.Drawing.Point(29, 20);
            this.OrderID_label.Name = "OrderID_label";
            this.OrderID_label.Size = new System.Drawing.Size(181, 20);
            this.OrderID_label.TabIndex = 0;
            this.OrderID_label.Text = "Введите код заказа";
            // 
            // CustomerID_label
            // 
            this.CustomerID_label.AutoSize = true;
            this.CustomerID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerID_label.Location = new System.Drawing.Point(29, 101);
            this.CustomerID_label.Name = "CustomerID_label";
            this.CustomerID_label.Size = new System.Drawing.Size(193, 20);
            this.CustomerID_label.TabIndex = 0;
            this.CustomerID_label.Text = "Введите код клиента";
            // 
            // OrderID_textBox
            // 
            this.OrderID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderID_textBox.Location = new System.Drawing.Point(33, 52);
            this.OrderID_textBox.Name = "OrderID_textBox";
            this.OrderID_textBox.Size = new System.Drawing.Size(189, 26);
            this.OrderID_textBox.TabIndex = 0;
            // 
            // CustomerID_textBox
            // 
            this.CustomerID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerID_textBox.Location = new System.Drawing.Point(33, 133);
            this.CustomerID_textBox.Name = "CustomerID_textBox";
            this.CustomerID_textBox.Size = new System.Drawing.Size(189, 26);
            this.CustomerID_textBox.TabIndex = 1;
            // 
            // OrderDetails_button
            // 
            this.OrderDetails_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDetails_button.Location = new System.Drawing.Point(33, 187);
            this.OrderDetails_button.Name = "OrderDetails_button";
            this.OrderDetails_button.Size = new System.Drawing.Size(217, 33);
            this.OrderDetails_button.TabIndex = 2;
            this.OrderDetails_button.Text = "Подробности заказа";
            this.OrderDetails_button.UseVisualStyleBackColor = true;
            this.OrderDetails_button.Click += new System.EventHandler(this.OrderDetails_button_Click);
            // 
            // OrderHistory_button
            // 
            this.OrderHistory_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderHistory_button.Location = new System.Drawing.Point(33, 246);
            this.OrderHistory_button.Name = "OrderHistory_button";
            this.OrderHistory_button.Size = new System.Drawing.Size(217, 33);
            this.OrderHistory_button.TabIndex = 3;
            this.OrderHistory_button.Text = "История заказа";
            this.OrderHistory_button.UseVisualStyleBackColor = true;
            this.OrderHistory_button.Click += new System.EventHandler(this.OrderHistory_button_Click);
            // 
            // LINQsqlSproc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 304);
            this.Controls.Add(this.OrderHistory_button);
            this.Controls.Add(this.OrderDetails_button);
            this.Controls.Add(this.CustomerID_textBox);
            this.Controls.Add(this.OrderID_textBox);
            this.Controls.Add(this.CustomerID_label);
            this.Controls.Add(this.OrderID_label);
            this.Name = "LINQsqlSproc";
            this.Text = "Использование хранимых процедур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderID_label;
        private System.Windows.Forms.Label CustomerID_label;
        private System.Windows.Forms.TextBox OrderID_textBox;
        private System.Windows.Forms.TextBox CustomerID_textBox;
        private System.Windows.Forms.Button OrderDetails_button;
        private System.Windows.Forms.Button OrderHistory_button;
    }
}

