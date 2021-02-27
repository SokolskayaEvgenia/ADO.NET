
namespace ITMO.ADO.NET.Cntrl.Lab_03_EDM
{
    partial class EnterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.historian_button = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.dontKnow_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are YOU?";
            // 
            // historian_button
            // 
            this.historian_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historian_button.Location = new System.Drawing.Point(12, 43);
            this.historian_button.Name = "historian_button";
            this.historian_button.Size = new System.Drawing.Size(130, 38);
            this.historian_button.TabIndex = 0;
            this.historian_button.Text = "Historian";
            this.historian_button.UseVisualStyleBackColor = true;
            this.historian_button.Click += new System.EventHandler(this.historian_button_Click);
            // 
            // student_button
            // 
            this.student_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_button.Location = new System.Drawing.Point(167, 43);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(130, 38);
            this.student_button.TabIndex = 1;
            this.student_button.Text = "Student";
            this.student_button.UseVisualStyleBackColor = true;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            // 
            // dontKnow_button
            // 
            this.dontKnow_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dontKnow_button.Location = new System.Drawing.Point(12, 101);
            this.dontKnow_button.Name = "dontKnow_button";
            this.dontKnow_button.Size = new System.Drawing.Size(130, 38);
            this.dontKnow_button.TabIndex = 2;
            this.dontKnow_button.Text = "Don\'t know";
            this.dontKnow_button.UseVisualStyleBackColor = true;
            this.dontKnow_button.Click += new System.EventHandler(this.dontKnow_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(167, 101);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(130, 38);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 151);
            this.Controls.Add(this.student_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.dontKnow_button);
            this.Controls.Add(this.historian_button);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button historian_button;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Button dontKnow_button;
        private System.Windows.Forms.Button exit_button;
    }
}

