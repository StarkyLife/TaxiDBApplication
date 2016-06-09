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
using TaxiApplication.Entities;

namespace TaxiApplication.GUIUser
{
    public partial class OrderTrackForm : Form
    {
        public OrderTrackForm(OrdersView orderData)
        {
            InitializeComponent();

            dataNumberLabel.Text = orderData.OrderTrackingNumber.ToString();
            
            switch (orderData.OrderStatus)
            {
                case 0:
                    dataStatusLabel.ForeColor = Color.LightCoral;
                    dataStatusLabel.Text = "в ожидании";
                    descCarLabel.Visible = false;
                    dataCarLabel.Visible = false;
                    break;
                case 1:
                    dataStatusLabel.ForeColor = Color.Green;
                    dataStatusLabel.Text = "исполняется";
                    descCarLabel.Visible = true;
                    dataCarLabel.Visible = true;
                    if (orderData.DriverID != 0)
                    {
                        dataCarLabel.Text = string.Format("{0} {1} {2}",
                            orderData.CarTypeName,
                            orderData.CarColor,
                            orderData.CarNumber);
                    }
                    break;
                case 2:
                    dataStatusLabel.ForeColor = Color.Silver;
                    dataStatusLabel.Text = "закрыт";
                    descCarLabel.Visible = true;
                    dataCarLabel.Visible = true;
                    if (orderData.DriverID != 0)
                    {
                        dataCarLabel.Text = string.Format("{0} {1} {2}",
                            orderData.CarTypeName,
                            orderData.CarColor,
                            orderData.CarNumber);
                    }
                    break;
                default:
                    dataStatusLabel.Text = "Что-то не так со статусом!";
                    break;
            }
        }

        public OrderTrackForm()
        {
            InitializeComponent();
        }

        #region Move to Start Page
        private void GoToStartPage()
        {
            this.Close();
            var th = new Thread(x =>
            {
                Application.Run(new RegistrationForm());
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            GoToStartPage();
        }
    }
}
