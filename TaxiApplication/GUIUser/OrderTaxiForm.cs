using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiApplication.GUIUser
{
    public partial class OrderTaxiForm : Form
    {
        public OrderTaxiForm()
        {
            InitializeComponent();
        }

        private void OrderTaxiForm_Load(object sender, EventArgs e)
        {
            carTypeComboBox.Items.AddRange(DataBaseHelper.GetCurrentDataBase().GetAllAvailableCarTypes().ToArray());
        }

        #region Move to Start Page
        private void GoToStartPage()
        {
            this.Close();
            var th = new Thread(openRegstrationForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openRegstrationForm()
        {
            Application.Run(new RegistrationForm());
        }
        #endregion

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(fromTextBox.Text))
            {
                var trackingNumber = DataBaseHelper.GetCurrentDataBase().CreateOrder(nameTextBox.Text, fromTextBox.Text, toTextBox.Text,
                    carTypeComboBox.Text, isOnlyCheckBox.Checked);
                if (trackingNumber != 0)
                {
                    MessageBox.Show("Заказ оформлен! Ваш номер для отслеживания: " + trackingNumber);
                    GoToStartPage();
                }
                else
                {
                    MessageBox.Show("Не получилось оформить заказ! Свяжитесь с администратором.");
                }
            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены!");
            }
        }

        private void notNowButton_Click(object sender, EventArgs e)
        {
            GoToStartPage();
        }
    }
}
