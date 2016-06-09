namespace TaxiApplication.GUIAdmin
{
    partial class AdministrationDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationDrivers));
            this.MoveBackButton = new System.Windows.Forms.Button();
            this.dataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCompanies = new System.Windows.Forms.DataGridView();
            this.DBNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAddDriver = new System.Windows.Forms.Button();
            this.BtnFireDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBackButton
            // 
            this.MoveBackButton.Location = new System.Drawing.Point(757, 12);
            this.MoveBackButton.Name = "MoveBackButton";
            this.MoveBackButton.Size = new System.Drawing.Size(105, 23);
            this.MoveBackButton.TabIndex = 0;
            this.MoveBackButton.Text = "Идем назад";
            this.MoveBackButton.UseVisualStyleBackColor = true;
            this.MoveBackButton.Click += new System.EventHandler(this.MoveBackButton_Click);
            // 
            // dataGridViewDrivers
            // 
            this.dataGridViewDrivers.AllowUserToAddRows = false;
            this.dataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverID,
            this.DriverName,
            this.CarType,
            this.CarColor,
            this.CarNumber,
            this.Availability});
            this.dataGridViewDrivers.Location = new System.Drawing.Point(217, 98);
            this.dataGridViewDrivers.MultiSelect = false;
            this.dataGridViewDrivers.Name = "dataGridViewDrivers";
            this.dataGridViewDrivers.ReadOnly = true;
            this.dataGridViewDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrivers.Size = new System.Drawing.Size(645, 269);
            this.dataGridViewDrivers.TabIndex = 1;
            // 
            // DriverID
            // 
            this.DriverID.HeaderText = "№ водителя";
            this.DriverID.Name = "DriverID";
            this.DriverID.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Имя";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Марка машины";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            // 
            // CarColor
            // 
            this.CarColor.HeaderText = "Цвет";
            this.CarColor.Name = "CarColor";
            this.CarColor.ReadOnly = true;
            // 
            // CarNumber
            // 
            this.CarNumber.HeaderText = "Номер";
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.ReadOnly = true;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Доступен";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            // 
            // dataGridViewCompanies
            // 
            this.dataGridViewCompanies.AllowUserToAddRows = false;
            this.dataGridViewCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DBNumber,
            this.CompanyName});
            this.dataGridViewCompanies.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewCompanies.MultiSelect = false;
            this.dataGridViewCompanies.Name = "dataGridViewCompanies";
            this.dataGridViewCompanies.ReadOnly = true;
            this.dataGridViewCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompanies.Size = new System.Drawing.Size(184, 269);
            this.dataGridViewCompanies.TabIndex = 2;
            this.dataGridViewCompanies.SelectionChanged += new System.EventHandler(this.dataGridViewCompanies_SelectionChanged);
            // 
            // DBNumber
            // 
            this.DBNumber.HeaderText = "DbNumber";
            this.DBNumber.Name = "DBNumber";
            this.DBNumber.ReadOnly = true;
            this.DBNumber.Visible = false;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Название компании";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 140;
            // 
            // BtnAddDriver
            // 
            this.BtnAddDriver.ForeColor = System.Drawing.Color.Green;
            this.BtnAddDriver.Location = new System.Drawing.Point(217, 28);
            this.BtnAddDriver.Name = "BtnAddDriver";
            this.BtnAddDriver.Size = new System.Drawing.Size(141, 39);
            this.BtnAddDriver.TabIndex = 3;
            this.BtnAddDriver.Text = "Добавить нового водителя";
            this.BtnAddDriver.UseVisualStyleBackColor = true;
            this.BtnAddDriver.Click += new System.EventHandler(this.BtnAddDriver_Click);
            // 
            // BtnFireDriver
            // 
            this.BtnFireDriver.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnFireDriver.Location = new System.Drawing.Point(420, 28);
            this.BtnFireDriver.Name = "BtnFireDriver";
            this.BtnFireDriver.Size = new System.Drawing.Size(141, 39);
            this.BtnFireDriver.TabIndex = 4;
            this.BtnFireDriver.Text = "Уволить водителя";
            this.BtnFireDriver.UseVisualStyleBackColor = true;
            this.BtnFireDriver.Click += new System.EventHandler(this.BtnFireDriver_Click);
            // 
            // AdministrationDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 379);
            this.Controls.Add(this.BtnFireDriver);
            this.Controls.Add(this.BtnAddDriver);
            this.Controls.Add(this.dataGridViewCompanies);
            this.Controls.Add(this.dataGridViewDrivers);
            this.Controls.Add(this.MoveBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrationDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление кадрами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoveBackButton;
        private System.Windows.Forms.DataGridView dataGridViewDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumber;
        private System.Windows.Forms.DataGridView dataGridViewCompanies;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.Button BtnAddDriver;
        private System.Windows.Forms.Button BtnFireDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
    }
}