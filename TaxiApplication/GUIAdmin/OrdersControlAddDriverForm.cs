using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiApplication.Entities;

namespace TaxiApplication.GUIAdmin
{
    public partial class OrdersControlAddDriverForm : Form
    {
        public int SelectedDriverId = 0;
        public string SelectedDriverName = "";
        public int SelectedCompanyNumber = 0;

        private readonly List<DriversView> driversTaxi1;
        private readonly List<DriversView> driversTaxi2;

        public OrdersControlAddDriverForm(string preferredCarType, bool onlyThisCarType)
        {
            InitializeComponent();
            driversTaxi1 = DataBaseHelper.GetCurrentDataBase().GetDriversByCompanyNumber(1).Where(x => x.Available).ToList();
            driversTaxi2 = DataBaseHelper.GetCurrentDataBase().GetDriversByCompanyNumber(2).Where(x => x.Available).ToList(); 

            if (!string.IsNullOrEmpty(preferredCarType) && onlyThisCarType)
            {
                if (driversTaxi1.Count > 0)
                {
                    driversTaxi1 = driversTaxi1.Where(x => x.CarTypeName == preferredCarType).ToList();
                }
                if (driversTaxi2.Count > 0)
                {
                    driversTaxi2 = driversTaxi2.Where(x => x.CarTypeName == preferredCarType).ToList();
                }
            }
        }

        private void DBComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            switch (DBComboBox.SelectedIndex)
            {
                case 0:
                    foreach (var driver in driversTaxi1)
                    {
                        dataGridView1.Rows.Add(driver.DriverID, driver.DriverName, driver.CarTypeName);
                    }
                    break;
                case 1:
                    foreach (var driver in driversTaxi2)
                    {
                        dataGridView1.Rows.Add(driver.DriverID, driver.DriverName, driver.CarTypeName);
                    }
                    break;
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SelectedDriverId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                SelectedDriverName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                switch (DBComboBox.SelectedIndex)
                {
                    case 0:
                        SelectedCompanyNumber = 1;
                        break;
                    case 1:
                        SelectedCompanyNumber = 2;
                        break;
                }
            }
        }
    }
}
