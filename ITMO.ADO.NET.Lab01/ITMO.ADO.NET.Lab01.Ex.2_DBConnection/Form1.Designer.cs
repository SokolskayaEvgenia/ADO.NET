
namespace ITMO.ADO.NET.Lab01.Ex._2_DBConnection
{
    partial class DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.WorkWithDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsyncConnectToDB_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionList_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkWithDB_ToolStripMenuItem,
            this.connectionList_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // WorkWithDB_ToolStripMenuItem
            // 
            this.WorkWithDB_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToDB_ToolStripMenuItem,
            this.DisconnectDB_ToolStripMenuItem,
            this.AsyncConnectToDB_ToolStripMenuItem});
            this.WorkWithDB_ToolStripMenuItem.Name = "WorkWithDB_ToolStripMenuItem";
            this.WorkWithDB_ToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.WorkWithDB_ToolStripMenuItem.Text = "Работа с базой данных";
            // 
            // ConnectToDB_ToolStripMenuItem
            // 
            this.ConnectToDB_ToolStripMenuItem.Name = "ConnectToDB_ToolStripMenuItem";
            this.ConnectToDB_ToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.ConnectToDB_ToolStripMenuItem.Text = "Подключиться к БД";
            this.ConnectToDB_ToolStripMenuItem.Click += new System.EventHandler(this.ConnectToDB_ToolStripMenuItem_Click);
            // 
            // DisconnectDB_ToolStripMenuItem
            // 
            this.DisconnectDB_ToolStripMenuItem.Name = "DisconnectDB_ToolStripMenuItem";
            this.DisconnectDB_ToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.DisconnectDB_ToolStripMenuItem.Text = "Отключиться от БД";
            this.DisconnectDB_ToolStripMenuItem.Click += new System.EventHandler(this.DisconnectDB_ToolStripMenuItem_Click);
            // 
            // AsyncConnectToDB_ToolStripMenuItem
            // 
            this.AsyncConnectToDB_ToolStripMenuItem.Name = "AsyncConnectToDB_ToolStripMenuItem";
            this.AsyncConnectToDB_ToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.AsyncConnectToDB_ToolStripMenuItem.Text = "Асинхронное подключение к БД";
            this.AsyncConnectToDB_ToolStripMenuItem.Click += new System.EventHandler(this.AsyncConnectToDB_ToolStripMenuItem_Click);
            // 
            // connectionList_ToolStripMenuItem
            // 
            this.connectionList_ToolStripMenuItem.Name = "connectionList_ToolStripMenuItem";
            this.connectionList_ToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.connectionList_ToolStripMenuItem.Text = "Список подключений";
            this.connectionList_ToolStripMenuItem.Click += new System.EventHandler(this.connectionList_ToolStripMenuItem_Click);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBConnection";
            this.Text = "Соединение с БД";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem WorkWithDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AsyncConnectToDB_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionList_ToolStripMenuItem;
    }
}

