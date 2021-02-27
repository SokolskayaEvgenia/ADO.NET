
namespace ITMO.ADO.NET.Cntrl.Lab_03_EDM
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.battleList = new System.Windows.Forms.ComboBox();
            this.ships_dataGridView = new System.Windows.Forms.DataGridView();
            this.outcomes_dataGridView = new System.Windows.Forms.DataGridView();
            this.date_label = new System.Windows.Forms.Label();
            this.info_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ships_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outcomes_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // battleList
            // 
            this.battleList.FormattingEnabled = true;
            this.battleList.Location = new System.Drawing.Point(12, 12);
            this.battleList.Name = "battleList";
            this.battleList.Size = new System.Drawing.Size(554, 24);
            this.battleList.TabIndex = 0;
            this.battleList.SelectedIndexChanged += new System.EventHandler(this.battleList_SelectedIndexChanged);
            // 
            // ships_dataGridView
            // 
            this.ships_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ships_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ships_dataGridView.Location = new System.Drawing.Point(12, 280);
            this.ships_dataGridView.Name = "ships_dataGridView";
            this.ships_dataGridView.RowHeadersWidth = 51;
            this.ships_dataGridView.RowTemplate.Height = 24;
            this.ships_dataGridView.Size = new System.Drawing.Size(554, 265);
            this.ships_dataGridView.TabIndex = 1;
            // 
            // outcomes_dataGridView
            // 
            this.outcomes_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outcomes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outcomes_dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.outcomes_dataGridView.Location = new System.Drawing.Point(12, 81);
            this.outcomes_dataGridView.Name = "outcomes_dataGridView";
            this.outcomes_dataGridView.RowHeadersWidth = 51;
            this.outcomes_dataGridView.RowTemplate.Height = 24;
            this.outcomes_dataGridView.Size = new System.Drawing.Size(554, 150);
            this.outcomes_dataGridView.TabIndex = 1;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_label.Location = new System.Drawing.Point(12, 51);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 20);
            this.date_label.TabIndex = 2;
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_button.Location = new System.Drawing.Point(16, 237);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(117, 37);
            this.info_button.TabIndex = 3;
            this.info_button.Text = "Load info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 557);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.outcomes_dataGridView);
            this.Controls.Add(this.ships_dataGridView);
            this.Controls.Add(this.battleList);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ships_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outcomes_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox battleList;
        private System.Windows.Forms.DataGridView ships_dataGridView;
        private System.Windows.Forms.DataGridView outcomes_dataGridView;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button info_button;
    }
}