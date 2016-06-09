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
    public partial class AddNewDriverForm : Form
    {
        private int _companyNumber;

        public AddNewDriverForm(int companyNumber)
        {
            InitializeComponent();
            _companyNumber = companyNumber;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int result;
            DriversView newDriver = new DriversView
            {
                DriverName = textBoxName.Text,
                CarTypeName = textBoxCarType.Text,
                CarColor = textBoxCarColor.Text,
                CarNumber = (int.TryParse(textBoxCarNumber.Text, out result)) ? result : 0
            };
            DataBaseHelper.GetCurrentDataBase().AddNewDriver(newDriver, _companyNumber);
        }
    }
}
