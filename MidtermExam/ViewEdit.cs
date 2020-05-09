using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExam
{
    public partial class ViewEdit : Form
    {
        public ViewEdit()
        {
            InitializeComponent();
        }

        private void tripBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tripBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shipmentDataSet);

        }

        private void ViewEdit_Load(object sender, EventArgs e)
        {

            //NOTE: All scheduled trips will be shown, it lists all the trips scheduled ** (today --> use DateTime.Today) ** is between ( ) so I listed all trips in case of all trips today 
            // use --> this.tripTableAdapter.FillByDate(this.shipmentDataSet.Trip,DateTime.Today.Date.ToString());
            
            tripDateTimePicker.MinDate = DateTime.Today.AddDays(7);
            this.tripTableAdapter.Fill(this.shipmentDataSet.Trip);

        }

        private void tripDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.tripTableAdapter.FillByDate(this.shipmentDataSet.Trip, tripDateTimePicker.Value.Date.ToString());
        }
    }
}
