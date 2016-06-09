using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Linq;
using TaxiApplication.Entities;
using TaxiApplication.GUIUser;
using System.Threading;
using TaxiApplication.GUIAdmin;

namespace TaxiApplication
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();            
        }

        #region OrderTaxiForm
        private void orderTaxiButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var th = new Thread(openOrderTaxiForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openOrderTaxiForm()
        {
            Application.Run(new OrderTaxiForm());
        }
        #endregion

        #region OrderTrackForm
        private void trackNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            trackOrderButton.Enabled = true;
        }
        
        private void trackOrderButton_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(trackNumberTextBox.Text, out result))
            {
                var orderData = DataBaseHelper.GetCurrentDataBase().TryGetOrderDataByValidTrackingNumber(result);
                if (orderData != null)
                {
                    this.Close();
                    var th = new Thread(x => {
                        Application.Run(new OrderTrackForm(orderData));
                    });
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Неправильный номер");
                }
            }
            else
            {
                MessageBox.Show("Недопустимые символы!");
            }
        }
        #endregion

        #region AdminForm
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            adminEnterButton.Enabled = true;
        }

        private void adminEnterButton_Click(object sender, EventArgs e)
        {
            if (DataBaseHelper.GetCurrentDataBase().IsAdminPassInfoValid(userNameTextBox.Text, passwordTextBox.Text))
            {
                this.Close();
                var th = new Thread(x =>
                {
                    Application.Run(new SelectForm());
                });
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Неправильный пароль или логин");
            }
        }
        #endregion 
    }
}
