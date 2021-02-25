
namespace ITMO.ADO.NET.Lab09._01_CourseManager
{
    partial class CourseViewer
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
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.closeForm = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewOffices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(12, 12);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(383, 24);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(12, 42);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.RowHeadersWidth = 51;
            this.courseGridView.RowTemplate.Height = 24;
            this.courseGridView.Size = new System.Drawing.Size(383, 182);
            this.courseGridView.TabIndex = 1;
            // 
            // closeForm
            // 
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeForm.Location = new System.Drawing.Point(287, 403);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(108, 35);
            this.closeForm.TabIndex = 2;
            this.closeForm.Text = "Закрыть";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.Location = new System.Drawing.Point(12, 403);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(107, 35);
            this.saveChanges.TabIndex = 2;
            this.saveChanges.Text = "Обновить";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 167);
            this.dataGridView1.TabIndex = 3;
            // 
            // viewOffices
            // 
            this.viewOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewOffices.Location = new System.Drawing.Point(125, 403);
            this.viewOffices.Name = "viewOffices";
            this.viewOffices.Size = new System.Drawing.Size(156, 35);
            this.viewOffices.TabIndex = 2;
            this.viewOffices.Text = "View Offices";
            this.viewOffices.UseVisualStyleBackColor = true;
            this.viewOffices.Click += new System.EventHandler(this.viewOffices_Click);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewOffices);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.departmentList);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewOffices;
    }
}

