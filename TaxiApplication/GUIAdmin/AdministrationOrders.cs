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
using NHibernate;
using TaxiApplication.Entities;

namespace TaxiApplication.GUIAdmin
{
    public partial class AdministrationOrders : Form
    {
        public AdministrationOrders()
        {
            InitializeComponent();

            UpdateGridInformation();
        }

        private void UpdateGridInformation()
        {
            dataGridView1.Rows.Clear();
            List<OrdersView> orders = DataBaseHelper.GetCurrentDataBase().GetAllOrdersData();
            foreach (var order in orders)
            {
                int row = dataGridView1.Rows.Add(
                    /*0*/order.OrderID, 
                    /*1*/order.CompanyID, 
                    /*2*/order.ClientName, 
                    /*3*/order.Destination_From,
                    /*4*/order.Destination_To, 
                    /*5*/order.PreferredCarTypeName, 
                    /*6*/order.DriverID, 
                    /*7*/order.CompanyID, 
                    /*8*/order.DriverName,
                    /*9*/order.OnlyThisCarType);
                switch (order.OrderStatus)
                {
                    case 0:
                        dataGridView1.Rows[row].DefaultCellStyle.BackColor = Color.LightCoral;
                        dataGridView1.Rows[row].DefaultCellStyle.SelectionBackColor = Color.LightCoral;
                        break;
                    case 1:
                        dataGridView1.Rows[row].DefaultCellStyle.BackColor = Color.Green;
                        dataGridView1.Rows[row].DefaultCellStyle.SelectionBackColor = Color.Green;
                        break;
                    case 2:
                        dataGridView1.Rows[row].DefaultCellStyle.BackColor = Color.Silver;
                        dataGridView1.Rows[row].DefaultCellStyle.SelectionBackColor = Color.Silver;
                        break;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var th = new Thread(x =>
            {
                Application.Run(new SelectForm());
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void SelectDriverBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var frm = new OrdersControlAddDriverForm(dataGridView1.SelectedRows[0].Cells[5].Value.ToString(), 
                    Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[9].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //driverID
                    dataGridView1.SelectedRows[0].Cells[6].Value = frm.SelectedDriverId;

                    //CompanyNumber
                    dataGridView1.SelectedRows[0].Cells[7].Value = frm.SelectedCompanyNumber;

                    //driverName
                    dataGridView1.SelectedRows[0].Cells[8].Value = frm.SelectedDriverName;

                    BtnExecuted.Enabled = true;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor == Color.LightCoral)
                {
                    BtnNotExecuted.Enabled = false;
                    BtnClosed.Enabled = false;
                    SelectDriverBtn.Enabled = true;
                    if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() != "0")
                        BtnExecuted.Enabled = true;
                    else BtnExecuted.Enabled = false;
                }

                if (dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor == Color.Green)
                {
                    BtnNotExecuted.Enabled = true;
                    BtnClosed.Enabled = true;
                    SelectDriverBtn.Enabled = false;
                    BtnExecuted.Enabled = false;
                }

                if (dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor == Color.Silver)
                {
                    BtnNotExecuted.Enabled = false;
                    BtnClosed.Enabled = false;
                    SelectDriverBtn.Enabled = false;
                    BtnExecuted.Enabled = false;
                }
            }
        }

        private void ChangeOrderStatus(int orderStatus)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                var order = new OrdersView
                {
                    OrderID = Convert.ToInt32(row.Cells[0].Value),
                    CompanyID = Convert.ToInt32(row.Cells[1].Value),
                    DriverID = Convert.ToInt32(row.Cells[6].Value),
                    OrderStatus = orderStatus
                };
                int driverCompanyId = Convert.ToInt32(row.Cells[7].Value);

                if (DataBaseHelper.GetCurrentDataBase().UpdateOrderInformation(order, driverCompanyId))
                {
                    UpdateGridInformation();
                }
            }
        }

        private void BtnNotExecuted_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus(0);
        }

        private void BtnExecuted_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus(1);
        }

        private void BtnClosed_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus(2);
        }
    }
}
