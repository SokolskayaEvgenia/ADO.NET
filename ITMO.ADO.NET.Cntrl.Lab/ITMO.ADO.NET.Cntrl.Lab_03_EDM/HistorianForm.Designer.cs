
namespace ITMO.ADO.NET.Cntrl.Lab_03_EDM
{
    partial class HistorianForm
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
            this.ships_dataGridView = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.makeChangesList = new System.Windows.Forms.ComboBox();
            this.changes_dataGridView = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.battles_dataGridView = new System.Windows.Forms.DataGridView();
            this.load_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ships_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changes_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ships_dataGridView
            // 
            this.ships_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ships_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ships_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ships_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.ships_dataGridView.Name = "ships_dataGridView";
            this.ships_dataGridView.RowHeadersWidth = 51;
            this.ships_dataGridView.RowTemplate.Height = 24;
            this.ships_dataGridView.Size = new System.Drawing.Size(794, 236);
            this.ships_dataGridView.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(216, 466);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(99, 31);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // makeChangesList
            // 
            this.makeChangesList.FormattingEnabled = true;
            this.makeChangesList.Items.AddRange(new object[] {
            "Ships",
            "Classes",
            "Battles",
            "Outcomes"});
            this.makeChangesList.Location = new System.Drawing.Point(12, 466);
            this.makeChangesList.Name = "makeChangesList";
            this.makeChangesList.Size = new System.Drawing.Size(176, 24);
            this.makeChangesList.TabIndex = 2;
            // 
            // changes_dataGridView
            // 
            this.changes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changes_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.changes_dataGridView.Location = new System.Drawing.Point(0, 503);
            this.changes_dataGridView.Name = "changes_dataGridView";
            this.changes_dataGridView.RowHeadersWidth = 51;
            this.changes_dataGridView.RowTemplate.Height = 24;
            this.changes_dataGridView.Size = new System.Drawing.Size(794, 61);
            this.changes_dataGridView.TabIndex = 3;
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(507, 466);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(126, 31);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // battles_dataGridView
            // 
            this.battles_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.battles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.battles_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.battles_dataGridView.Location = new System.Drawing.Point(0, 242);
            this.battles_dataGridView.Name = "battles_dataGridView";
            this.battles_dataGridView.RowHeadersWidth = 51;
            this.battles_dataGridView.RowTemplate.Height = 24;
            this.battles_dataGridView.Size = new System.Drawing.Size(794, 218);
            this.battles_dataGridView.TabIndex = 4;
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_button.Location = new System.Drawing.Point(656, 466);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(126, 31);
            this.load_button.TabIndex = 1;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // HistorianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 564);
            this.Controls.Add(this.battles_dataGridView);
            this.Controls.Add(this.changes_dataGridView);
            this.Controls.Add(this.makeChangesList);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.ships_dataGridView);
            this.Name = "HistorianForm";
            this.Text = "Historian Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistorianForm_FormClosed);
            this.Load += new System.EventHandler(this.HistorianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ships_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changes_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battles_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ships_dataGridView;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox makeChangesList;
        private System.Windows.Forms.DataGridView changes_dataGridView;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.DataGridView battles_dataGridView;
        private System.Windows.Forms.Button load_button;
    }
}

