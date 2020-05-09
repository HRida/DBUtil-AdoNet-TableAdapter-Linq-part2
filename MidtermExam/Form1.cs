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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void question1Button_Click(object sender, EventArgs e)
        {
            AddTrip ado = new AddTrip();
            ado.Show();
        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            ViewEdit db = new ViewEdit();
            db.Show();
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            ShipsPort sp = new ShipsPort();
            sp.Show();
        }
    }
}
