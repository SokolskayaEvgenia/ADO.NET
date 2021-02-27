
namespace ITMO.ADO.NET.Lab04_CreatingDataTable
{
    partial class CreatingDataTable
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
            this.FillChildTable_button = new System.Windows.Forms.Button();
            this.FillChildTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.FillParentTable_button = new System.Windows.Forms.Button();
            this.FillParentTable_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FillChildTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillParentTable_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FillChildTable_button
            // 
            this.FillChildTable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillChildTable_button.Location = new System.Drawing.Point(97, 12);
            this.FillChildTable_button.Name = "FillChildTable_button";
            this.FillChildTable_button.Size = new System.Drawing.Size(165, 60);
            this.FillChildTable_button.TabIndex = 0;
            this.FillChildTable_button.Text = "Заполнить дочернюю таблицу";
            this.FillChildTable_button.UseVisualStyleBackColor = true;
            this.FillChildTable_button.Click += new System.EventHandler(this.FillChildTable_button_Click);
            // 
            // FillChildTable_dataGridView
            // 
            this.FillChildTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FillChildTable_dataGridView.Location = new System.Drawing.Point(12, 101);
            this.FillChildTable_dataGridView.Name = "FillChildTable_dataGridView";
            this.FillChildTable_dataGridView.RowHeadersWidth = 51;
            this.FillChildTable_dataGridView.RowTemplate.Height = 24;
            this.FillChildTable_dataGridView.Size = new System.Drawing.Size(320, 260);
            this.FillChildTable_dataGridView.TabIndex = 1;
            // 
            // FillParentTable_button
            // 
            this.FillParentTable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillParentTable_button.Location = new System.Drawing.Point(508, 12);
            this.FillParentTable_button.Name = "FillParentTable_button";
            this.FillParentTable_button.Size = new System.Drawing.Size(160, 60);
            this.FillParentTable_button.TabIndex = 2;
            this.FillParentTable_button.Text = "Заполнить основную таблицу";
            this.FillParentTable_button.UseVisualStyleBackColor = true;
            this.FillParentTable_button.Click += new System.EventHandler(this.FillParentTable_button_Click);
            // 
            // FillParentTable_dataGridView
            // 
            this.FillParentTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FillParentTable_dataGridView.Location = new System.Drawing.Point(429, 101);
            this.FillParentTable_dataGridView.Name = "FillParentTable_dataGridView";
            this.FillParentTable_dataGridView.RowHeadersWidth = 51;
            this.FillParentTable_dataGridView.RowTemplate.Height = 24;
            this.FillParentTable_dataGridView.Size = new System.Drawing.Size(320, 260);
            this.FillParentTable_dataGridView.TabIndex = 3;
            // 
            // CreatingDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FillParentTable_dataGridView);
            this.Controls.Add(this.FillChildTable_dataGridView);
            this.Controls.Add(this.FillParentTable_button);
            this.Controls.Add(this.FillChildTable_button);
            this.Name = "CreatingDataTable";
            this.Text = "Создание объектов DataTable";
            ((System.ComponentModel.ISupportInitialize)(this.FillChildTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillParentTable_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FillChildTable_button;
        private System.Windows.Forms.DataGridView FillChildTable_dataGridView;
        private System.Windows.Forms.Button FillParentTable_button;
        private System.Windows.Forms.DataGridView FillParentTable_dataGridView;
    }
}

