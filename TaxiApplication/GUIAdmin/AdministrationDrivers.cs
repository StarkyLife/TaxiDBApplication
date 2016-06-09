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

namespace TaxiApplication.GUIAdmin
{
    public partial class AdministrationDrivers : Form
    {
        private List<DriversView> _drivers1 = new List<DriversView>();
        private List<DriversView> _drivers2 = new List<DriversView>(); 

        public AdministrationDrivers()
        {
            InitializeComponent();
            dataGridViewCompanies.Rows.Add(1, "Company1");
            dataGridViewCompanies.Rows.Add(2, "Company2");
            UpdateDriversList();
        }

        private void UpdateDriversList()
        {
            _drivers1 = DataBaseHelper.GetCurrentDataBase().GetDriversByCompanyNumber(1);
            _drivers2 = DataBaseHelper.GetCurrentDataBase().GetDriversByCompanyNumber(2);
        }

        private void UpdateDriversGrid(int companyNumber)
        {
            dataGridViewDrivers.Rows.Clear();

            List<DriversView> drivers;
            switch (companyNumber)
            {
                case 1:
                    drivers = _drivers1;
                    break;
                case 2:
                    drivers = _drivers2;
                    break;
                default:
                    drivers = new List<DriversView>();
                    break;
            }

            foreach (var driver in drivers)
            {
                dataGridViewDrivers.Rows.Add(
                    /*0*/driver.DriverID,
                    /*1*/driver.DriverName,
                    /*2*/driver.CarTypeName,
                    /*3*/driver.CarColor,
                    /*4*/driver.CarNumber,
                    /*5*/(driver.Available) ? "Да" : "Нет");
            }
        }

        private void MoveBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var th = new Thread(x =>
            {
                Application.Run(new SelectForm());
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void dataGridViewCompanies_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count > 0)
            {
                UpdateDriversGrid(Convert.ToInt32(dataGridViewCompanies.SelectedRows[0].Cells[0].Value));
            }
        }

        private void BtnAddDriver_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count > 0)
            {
                var frm = new AddNewDriverForm(Convert.ToInt32(dataGridViewCompanies.SelectedRows[0].Cells[0].Value));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    UpdateDriversList();
                    UpdateDriversGrid(Convert.ToInt32(dataGridViewCompanies.SelectedRows[0].Cells[0].Value));
                }
            }
        }

        private void BtnFireDriver_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count > 0 && dataGridViewDrivers.SelectedRows.Count > 0)
            {
                if (DataBaseHelper.GetCurrentDataBase().DeleteDriver(Convert.ToInt32(dataGridViewDrivers.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(dataGridViewCompanies.SelectedRows[0].Cells[0].Value)))
                {
                    UpdateDriversList();
                    UpdateDriversGrid(Convert.ToInt32(dataGridViewCompanies.SelectedRows[0].Cells[0].Value));
                }
            }
        }
    }
}
