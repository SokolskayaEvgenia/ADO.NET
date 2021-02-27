
namespace ITMO.ADO.NET.Lab04._03_DataAdapterProgram
{
    partial class DataAdapterProgram
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.addRow_button = new System.Windows.Forms.Button();
            this.deleteRow_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(36, 378);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(145, 40);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Обновить";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // addRow_button
            // 
            this.addRow_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRow_button.Location = new System.Drawing.Point(216, 378);
            this.addRow_button.Name = "addRow_button";
            this.addRow_button.Size = new System.Drawing.Size(188, 40);
            this.addRow_button.TabIndex = 1;
            this.addRow_button.Text = "Добавить строку";
            this.addRow_button.UseVisualStyleBackColor = true;
            this.addRow_button.Click += new System.EventHandler(this.addRow_button_Click);
            // 
            // deleteRow_button
            // 
            this.deleteRow_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRow_button.Location = new System.Drawing.Point(437, 378);
            this.deleteRow_button.Name = "deleteRow_button";
            this.deleteRow_button.Size = new System.Drawing.Size(188, 40);
            this.deleteRow_button.TabIndex = 1;
            this.deleteRow_button.Text = "Удалить строку";
            this.deleteRow_button.UseVisualStyleBackColor = true;
            this.deleteRow_button.Click += new System.EventHandler(this.deleteRow_button_Click);
            // 
            // DataAdapterProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.deleteRow_button);
            this.Controls.Add(this.addRow_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataAdapterProgram";
            this.Text = "Программное создание объекта DataAdapter";
            this.Load += new System.EventHandler(this.DataAdapterProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button addRow_button;
        private System.Windows.Forms.Button deleteRow_button;
    }
}

