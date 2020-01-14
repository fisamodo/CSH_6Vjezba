using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csh6lab
{
    public partial class Kraj : UserControl
    {
        public event handler UserNotFound;
        public Kraj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserNotFound("Greska");
        }
    }
}
