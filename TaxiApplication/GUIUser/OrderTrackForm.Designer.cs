namespace TaxiApplication.GUIUser
{
    partial class OrderTrackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTrackForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.descNumberLabel = new System.Windows.Forms.Label();
            this.descStatusLabel = new System.Windows.Forms.Label();
            this.dataCarLabel = new System.Windows.Forms.Label();
            this.dataNumberLabel = new System.Windows.Forms.Label();
            this.dataStatusLabel = new System.Windows.Forms.Label();
            this.descCarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(317, 13);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // descNumberLabel
            // 
            this.descNumberLabel.AutoSize = true;
            this.descNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descNumberLabel.Location = new System.Drawing.Point(86, 58);
            this.descNumberLabel.Name = "descNumberLabel";
            this.descNumberLabel.Size = new System.Drawing.Size(79, 24);
            this.descNumberLabel.TabIndex = 1;
            this.descNumberLabel.Text = "Номер: ";
            // 
            // descStatusLabel
            // 
            this.descStatusLabel.AutoSize = true;
            this.descStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descStatusLabel.Location = new System.Drawing.Point(85, 133);
            this.descStatusLabel.Name = "descStatusLabel";
            this.descStatusLabel.Size = new System.Drawing.Size(70, 20);
            this.descStatusLabel.TabIndex = 2;
            this.descStatusLabel.Text = "Статус: ";
            // 
            // dataCarLabel
            // 
            this.dataCarLabel.AutoSize = true;
            this.dataCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataCarLabel.Location = new System.Drawing.Point(172, 216);
            this.dataCarLabel.Name = "dataCarLabel";
            this.dataCarLabel.Size = new System.Drawing.Size(84, 17);
            this.dataCarLabel.TabIndex = 3;
            this.dataCarLabel.Text = "неизвестно";
            // 
            // dataNumberLabel
            // 
            this.dataNumberLabel.AutoSize = true;
            this.dataNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataNumberLabel.Location = new System.Drawing.Point(171, 58);
            this.dataNumberLabel.Name = "dataNumberLabel";
            this.dataNumberLabel.Size = new System.Drawing.Size(114, 24);
            this.dataNumberLabel.TabIndex = 6;
            this.dataNumberLabel.Text = "нет номера";
            // 
            // dataStatusLabel
            // 
            this.dataStatusLabel.AutoSize = true;
            this.dataStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataStatusLabel.Location = new System.Drawing.Point(170, 133);
            this.dataStatusLabel.Name = "dataStatusLabel";
            this.dataStatusLabel.Size = new System.Drawing.Size(115, 20);
            this.dataStatusLabel.TabIndex = 7;
            this.dataStatusLabel.Text = "не определен";
            // 
            // descCarLabel
            // 
            this.descCarLabel.AutoSize = true;
            this.descCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCarLabel.Location = new System.Drawing.Point(86, 216);
            this.descCarLabel.Name = "descCarLabel";
            this.descCarLabel.Size = new System.Drawing.Size(70, 17);
            this.descCarLabel.TabIndex = 8;
            this.descCarLabel.Text = "Машина :";
            // 
            // OrderTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 355);
            this.Controls.Add(this.descCarLabel);
            this.Controls.Add(this.dataStatusLabel);
            this.Controls.Add(this.dataNumberLabel);
            this.Controls.Add(this.dataCarLabel);
            this.Controls.Add(this.descStatusLabel);
            this.Controls.Add(this.descNumberLabel);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderTrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отслеживание заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label descNumberLabel;
        private System.Windows.Forms.Label descStatusLabel;
        private System.Windows.Forms.Label dataCarLabel;
        private System.Windows.Forms.Label dataNumberLabel;
        private System.Windows.Forms.Label dataStatusLabel;
        private System.Windows.Forms.Label descCarLabel;
    }
}