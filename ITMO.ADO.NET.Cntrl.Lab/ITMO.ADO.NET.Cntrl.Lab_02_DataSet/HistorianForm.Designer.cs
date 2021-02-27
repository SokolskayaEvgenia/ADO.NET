
namespace ITMO.ADO.NET.Cntrl.Lab_02
{
    partial class HistorianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorianForm));
            this.Historian_dataGridView = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.shipsDataSet1 = new ITMO.ADO.NET.Cntrl.Lab_02.ShipsDataSet();
            this.saveChange_button = new System.Windows.Forms.Button();
            this.deleteRow_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Historian_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Historian_dataGridView
            // 
            this.Historian_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historian_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Historian_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Historian_dataGridView.Name = "Historian_dataGridView";
            this.Historian_dataGridView.RowHeadersWidth = 51;
            this.Historian_dataGridView.RowTemplate.Height = 24;
            this.Historian_dataGridView.Size = new System.Drawing.Size(497, 382);
            this.Historian_dataGridView.TabIndex = 0;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT * FROM Ships";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Ships;Integrated Security=True" +
    "";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Ships] ([name], [class], [launched]) VALUES (@name, @class, @launche" +
    "d);\r\nSELECT name, class, launched FROM Ships WHERE (name = @name)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 0, "name"),
            new System.Data.SqlClient.SqlParameter("@class", System.Data.SqlDbType.VarChar, 0, "class"),
            new System.Data.SqlClient.SqlParameter("@launched", System.Data.SqlDbType.SmallInt, 0, "launched")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 0, "name"),
            new System.Data.SqlClient.SqlParameter("@class", System.Data.SqlDbType.VarChar, 0, "class"),
            new System.Data.SqlClient.SqlParameter("@launched", System.Data.SqlDbType.SmallInt, 0, "launched"),
            new System.Data.SqlClient.SqlParameter("@Original_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_class", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "class", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_launched", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "launched", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_launched", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "launched", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Ships] WHERE (([name] = @Original_name) AND ([class] = @Original_cla" +
    "ss) AND ((@IsNull_launched = 1 AND [launched] IS NULL) OR ([launched] = @Origina" +
    "l_launched)))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_class", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "class", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_launched", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "launched", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_launched", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "launched", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Ships", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("class", "class"),
                        new System.Data.Common.DataColumnMapping("launched", "launched")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // shipsDataSet1
            // 
            this.shipsDataSet1.DataSetName = "ShipsDataSet";
            this.shipsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveChange_button
            // 
            this.saveChange_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChange_button.Location = new System.Drawing.Point(339, 404);
            this.saveChange_button.Name = "saveChange_button";
            this.saveChange_button.Size = new System.Drawing.Size(146, 34);
            this.saveChange_button.TabIndex = 1;
            this.saveChange_button.Text = "Update";
            this.saveChange_button.UseVisualStyleBackColor = true;
            this.saveChange_button.Click += new System.EventHandler(this.saveChange_button_Click);
            // 
            // deleteRow_button
            // 
            this.deleteRow_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRow_button.Location = new System.Drawing.Point(12, 404);
            this.deleteRow_button.Name = "deleteRow_button";
            this.deleteRow_button.Size = new System.Drawing.Size(146, 34);
            this.deleteRow_button.TabIndex = 1;
            this.deleteRow_button.Text = "Delete";
            this.deleteRow_button.UseVisualStyleBackColor = true;
            this.deleteRow_button.Click += new System.EventHandler(this.deleteRow_button_Click);
            // 
            // HistorianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.deleteRow_button);
            this.Controls.Add(this.saveChange_button);
            this.Controls.Add(this.Historian_dataGridView);
            this.Name = "HistorianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historian Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistorianForm_FormClosed);
            this.Load += new System.EventHandler(this.HistorianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Historian_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Historian_dataGridView;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private ShipsDataSet shipsDataSet1;
        private System.Windows.Forms.Button saveChange_button;
        private System.Windows.Forms.Button deleteRow_button;
    }
}