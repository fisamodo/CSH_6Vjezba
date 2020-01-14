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
    public partial class Greska : UserControl
    {
        public Greska()
        {
            InitializeComponent();
        }
        public void SetLabelText()
        {
            
        }

        public Action<string> UserNotFound { get; internal set; }
    }
}
