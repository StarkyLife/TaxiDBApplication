namespace TaxiApplication.GUIAdmin
{
    partial class OrdersControlAddDriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersControlAddDriverForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBComboBox = new System.Windows.Forms.ComboBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverId,
            this.DriverName,
            this.CarType});
            this.dataGridView1.Location = new System.Drawing.Point(22, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(250, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // DriverId
            // 
            this.DriverId.HeaderText = "DriverID";
            this.DriverId.Name = "DriverId";
            this.DriverId.ReadOnly = true;
            this.DriverId.Visible = false;
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Имя водителя";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Марка машины";
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            // 
            // DBComboBox
            // 
            this.DBComboBox.FormattingEnabled = true;
            this.DBComboBox.Items.AddRange(new object[] {
            "Company1",
            "Company2"});
            this.DBComboBox.Location = new System.Drawing.Point(142, 16);
            this.DBComboBox.Name = "DBComboBox";
            this.DBComboBox.Size = new System.Drawing.Size(121, 21);
            this.DBComboBox.TabIndex = 1;
            this.DBComboBox.SelectedIndexChanged += new System.EventHandler(this.DBComboBox_SelectedIndexChanged);
            // 
            // BtnSelect
            // 
            this.BtnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSelect.ForeColor = System.Drawing.Color.Green;
            this.BtnSelect.Location = new System.Drawing.Point(102, 268);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 34);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "Выбрать";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбрать компанию";
            // 
            // OrdersControlAddDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.DBComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdersControlAddDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор водителя";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox DBComboBox;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
    }
}