namespace TaxiApplication
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adminEnterButton = new System.Windows.Forms.Button();
            this.orderTaxiButton = new System.Windows.Forms.Button();
            this.adminEnterLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.trackOrderButton = new System.Windows.Forms.Button();
            this.trackNumberTextBox = new System.Windows.Forms.TextBox();
            this.orderTrackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(30, 264);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(30, 290);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(142, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // adminEnterButton
            // 
            this.adminEnterButton.Enabled = false;
            this.adminEnterButton.Location = new System.Drawing.Point(62, 316);
            this.adminEnterButton.Name = "adminEnterButton";
            this.adminEnterButton.Size = new System.Drawing.Size(75, 23);
            this.adminEnterButton.TabIndex = 4;
            this.adminEnterButton.Text = "Войти";
            this.adminEnterButton.UseVisualStyleBackColor = true;
            this.adminEnterButton.Click += new System.EventHandler(this.adminEnterButton_Click);
            // 
            // orderTaxiButton
            // 
            this.orderTaxiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderTaxiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTaxiButton.Location = new System.Drawing.Point(77, 102);
            this.orderTaxiButton.Name = "orderTaxiButton";
            this.orderTaxiButton.Size = new System.Drawing.Size(249, 41);
            this.orderTaxiButton.TabIndex = 6;
            this.orderTaxiButton.Text = "Хочу заказать такси!";
            this.orderTaxiButton.UseVisualStyleBackColor = true;
            this.orderTaxiButton.Click += new System.EventHandler(this.orderTaxiButton_Click);
            // 
            // adminEnterLabel
            // 
            this.adminEnterLabel.AutoSize = true;
            this.adminEnterLabel.Location = new System.Drawing.Point(27, 232);
            this.adminEnterLabel.Name = "adminEnterLabel";
            this.adminEnterLabel.Size = new System.Drawing.Size(145, 13);
            this.adminEnterLabel.TabIndex = 7;
            this.adminEnterLabel.Text = "Вход для администраторов";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(9, 267);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(15, 13);
            this.ILabel.TabIndex = 8;
            this.ILabel.Text = "Я";
            // 
            // trackOrderButton
            // 
            this.trackOrderButton.Enabled = false;
            this.trackOrderButton.Location = new System.Drawing.Point(245, 316);
            this.trackOrderButton.Name = "trackOrderButton";
            this.trackOrderButton.Size = new System.Drawing.Size(105, 23);
            this.trackOrderButton.TabIndex = 9;
            this.trackOrderButton.Text = "Посмотреть";
            this.trackOrderButton.UseVisualStyleBackColor = true;
            this.trackOrderButton.Click += new System.EventHandler(this.trackOrderButton_Click);
            // 
            // trackNumberTextBox
            // 
            this.trackNumberTextBox.Location = new System.Drawing.Point(214, 264);
            this.trackNumberTextBox.Name = "trackNumberTextBox";
            this.trackNumberTextBox.Size = new System.Drawing.Size(160, 20);
            this.trackNumberTextBox.TabIndex = 10;
            this.trackNumberTextBox.TextChanged += new System.EventHandler(this.trackNumberTextBox_TextChanged);
            // 
            // orderTrackLabel
            // 
            this.orderTrackLabel.AutoSize = true;
            this.orderTrackLabel.Location = new System.Drawing.Point(211, 232);
            this.orderTrackLabel.Name = "orderTrackLabel";
            this.orderTrackLabel.Size = new System.Drawing.Size(163, 13);
            this.orderTrackLabel.TabIndex = 11;
            this.orderTrackLabel.Text = "Отслеживание статуса заказа";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 355);
            this.Controls.Add(this.orderTrackLabel);
            this.Controls.Add(this.trackNumberTextBox);
            this.Controls.Add(this.trackOrderButton);
            this.Controls.Add(this.ILabel);
            this.Controls.Add(this.adminEnterLabel);
            this.Controls.Add(this.orderTaxiButton);
            this.Controls.Add(this.adminEnterButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Такси";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button adminEnterButton;
        private System.Windows.Forms.Button orderTaxiButton;
        private System.Windows.Forms.Label adminEnterLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Button trackOrderButton;
        private System.Windows.Forms.TextBox trackNumberTextBox;
        private System.Windows.Forms.Label orderTrackLabel;
    }
}

