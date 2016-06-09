namespace TaxiApplication.GUIAdmin
{
    partial class AdministrationOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationOrders));
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlyThis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectDriverBtn = new System.Windows.Forms.Button();
            this.BtnNotExecuted = new System.Windows.Forms.Button();
            this.BtnExecuted = new System.Windows.Forms.Button();
            this.BtnClosed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(519, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(106, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Идем назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderDB,
            this.ClientName,
            this.DestFrom,
            this.DestTo,
            this.CarType,
            this.driverId,
            this.DriverDB,
            this.DriverName,
            this.onlyThis});
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(613, 269);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "orderId";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Visible = false;
            // 
            // OrderDB
            // 
            this.OrderDB.HeaderText = "OrderDB";
            this.OrderDB.Name = "OrderDB";
            this.OrderDB.ReadOnly = true;
            this.OrderDB.Visible = false;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Имя клиента";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // DestFrom
            // 
            this.DestFrom.HeaderText = "Откуда";
            this.DestFrom.Name = "DestFrom";
            this.DestFrom.ReadOnly = true;
            this.DestFrom.Width = 130;
            // 
            // DestTo
            // 
            this.DestTo.HeaderText = "Куда";
            this.DestTo.Name = "DestTo";
            this.DestTo.ReadOnly = true;
            this.DestTo.Width = 130;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Марка машины";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            // 
            // driverId
            // 
            this.driverId.HeaderText = "DriverId";
            this.driverId.Name = "driverId";
            this.driverId.ReadOnly = true;
            this.driverId.Visible = false;
            // 
            // DriverDB
            // 
            this.DriverDB.HeaderText = "DriverDB";
            this.DriverDB.Name = "DriverDB";
            this.DriverDB.ReadOnly = true;
            this.DriverDB.Visible = false;
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Имя водителя";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // onlyThis
            // 
            this.onlyThis.HeaderText = "Только этот";
            this.onlyThis.Name = "onlyThis";
            this.onlyThis.ReadOnly = true;
            this.onlyThis.Visible = false;
            // 
            // SelectDriverBtn
            // 
            this.SelectDriverBtn.Enabled = false;
            this.SelectDriverBtn.Location = new System.Drawing.Point(80, 59);
            this.SelectDriverBtn.Name = "SelectDriverBtn";
            this.SelectDriverBtn.Size = new System.Drawing.Size(113, 33);
            this.SelectDriverBtn.TabIndex = 2;
            this.SelectDriverBtn.Text = "Выбрать водителя";
            this.SelectDriverBtn.UseVisualStyleBackColor = true;
            this.SelectDriverBtn.Click += new System.EventHandler(this.SelectDriverBtn_Click);
            // 
            // BtnNotExecuted
            // 
            this.BtnNotExecuted.BackColor = System.Drawing.Color.LightCoral;
            this.BtnNotExecuted.Enabled = false;
            this.BtnNotExecuted.Location = new System.Drawing.Point(261, 59);
            this.BtnNotExecuted.Name = "BtnNotExecuted";
            this.BtnNotExecuted.Size = new System.Drawing.Size(101, 33);
            this.BtnNotExecuted.TabIndex = 3;
            this.BtnNotExecuted.Text = "Не обработано";
            this.BtnNotExecuted.UseVisualStyleBackColor = false;
            this.BtnNotExecuted.Click += new System.EventHandler(this.BtnNotExecuted_Click);
            // 
            // BtnExecuted
            // 
            this.BtnExecuted.BackColor = System.Drawing.Color.LightGreen;
            this.BtnExecuted.Enabled = false;
            this.BtnExecuted.Location = new System.Drawing.Point(368, 59);
            this.BtnExecuted.Name = "BtnExecuted";
            this.BtnExecuted.Size = new System.Drawing.Size(101, 33);
            this.BtnExecuted.TabIndex = 4;
            this.BtnExecuted.Text = "Отправлено";
            this.BtnExecuted.UseVisualStyleBackColor = false;
            this.BtnExecuted.Click += new System.EventHandler(this.BtnExecuted_Click);
            // 
            // BtnClosed
            // 
            this.BtnClosed.BackColor = System.Drawing.Color.Silver;
            this.BtnClosed.Enabled = false;
            this.BtnClosed.Location = new System.Drawing.Point(475, 59);
            this.BtnClosed.Name = "BtnClosed";
            this.BtnClosed.Size = new System.Drawing.Size(101, 33);
            this.BtnClosed.TabIndex = 5;
            this.BtnClosed.Text = "Закрыто";
            this.BtnClosed.UseVisualStyleBackColor = false;
            this.BtnClosed.Click += new System.EventHandler(this.BtnClosed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Установить статус";
            // 
            // AdministrationOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClosed);
            this.Controls.Add(this.BtnExecuted);
            this.Controls.Add(this.BtnNotExecuted);
            this.Controls.Add(this.SelectDriverBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrationOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление заказами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SelectDriverBtn;
        private System.Windows.Forms.Button BtnNotExecuted;
        private System.Windows.Forms.Button BtnExecuted;
        private System.Windows.Forms.Button BtnClosed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlyThis;
    }
}