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
    public partial class ShipsPort : Form
    {
        ShipmentDataContext db = new ShipmentDataContext();

        public ShipsPort()
        {
            InitializeComponent();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            string portcode = codeTextBox.Text.ToString();

            if (codeTextBox.Equals(null))
            {
                MessageBox.Show("No Port is Entered");
            }
            else
            {
                var ship = (from s in db.Ships
                           join t in db.Trips
                           on s.ShipCode equals t.ShipCode 
                           where t.PortCode == portcode
                           select s.ShipCode).ToList();
                shipsListBox.DataSource = ship;
            }
        }
    }
}
