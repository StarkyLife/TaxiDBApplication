namespace TaxiApplication.GUIUser
{
    partial class OrderTaxiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTaxiForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.isOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.orderMainLabel = new System.Windows.Forms.Label();
            this.notNowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(172, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(172, 116);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(220, 20);
            this.fromTextBox.TabIndex = 1;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(172, 160);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(220, 20);
            this.toTextBox.TabIndex = 2;
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Location = new System.Drawing.Point(172, 200);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.carTypeComboBox.TabIndex = 3;
            // 
            // isOnlyCheckBox
            // 
            this.isOnlyCheckBox.AutoSize = true;
            this.isOnlyCheckBox.Location = new System.Drawing.Point(299, 202);
            this.isOnlyCheckBox.Name = "isOnlyCheckBox";
            this.isOnlyCheckBox.Size = new System.Drawing.Size(93, 17);
            this.isOnlyCheckBox.TabIndex = 4;
            this.isOnlyCheckBox.Text = "Обязательно";
            this.isOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.ForeColor = System.Drawing.Color.Green;
            this.orderButton.Location = new System.Drawing.Point(118, 248);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(140, 39);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Заказать";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Ваше имя *";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(12, 119);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(90, 13);
            this.FromLabel.TabIndex = 7;
            this.FromLabel.Text = "Откуда (Адрес) *";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(12, 163);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(71, 13);
            this.ToLabel.TabIndex = 8;
            this.ToLabel.Text = "Куда (Адрес)";
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(12, 203);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(85, 13);
            this.carTypeLabel.TabIndex = 9;
            this.carTypeLabel.Text = "Марка машины";
            // 
            // orderMainLabel
            // 
            this.orderMainLabel.AutoSize = true;
            this.orderMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderMainLabel.Location = new System.Drawing.Point(101, 24);
            this.orderMainLabel.Name = "orderMainLabel";
            this.orderMainLabel.Size = new System.Drawing.Size(192, 24);
            this.orderMainLabel.TabIndex = 10;
            this.orderMainLabel.Text = "Оформление заказа";
            // 
            // notNowButton
            // 
            this.notNowButton.ForeColor = System.Drawing.Color.DarkRed;
            this.notNowButton.Location = new System.Drawing.Point(221, 320);
            this.notNowButton.Name = "notNowButton";
            this.notNowButton.Size = new System.Drawing.Size(171, 23);
            this.notNowButton.TabIndex = 11;
            this.notNowButton.Text = "Не хочу сейчас заказывать";
            this.notNowButton.UseVisualStyleBackColor = true;
            this.notNowButton.Click += new System.EventHandler(this.notNowButton_Click);
            // 
            // OrderTaxiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 355);
            this.Controls.Add(this.notNowButton);
            this.Controls.Add(this.orderMainLabel);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.isOnlyCheckBox);
            this.Controls.Add(this.carTypeComboBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderTaxiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ такси";
            this.Load += new System.EventHandler(this.OrderTaxiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.CheckBox isOnlyCheckBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.Label orderMainLabel;
        private System.Windows.Forms.Button notNowButton;
    }
}