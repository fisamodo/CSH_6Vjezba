using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace csh6lab
{
    public delegate void handler(string message);
    public partial class LogIn : UserControl
    {
        private XDocument korisnici;
        public event handler LoginSuccesful;
        public event handler LoginFailed;
        public LogIn()
        {
            InitializeComponent();
            korisnici = XDocument.Load("C:\\Users\\Korisnik\\Desktop\\csh6\\korisnici.xml");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean loginS = false;
            var k = from x in korisnici.Descendants("korisnik")
                    select new
                    {

                        korisnickoIme = x.Descendants("korisnickoIme").First().Value,
                        lozinka = x.Descendants("lozinka").First().Value,
                    };
            foreach (var x in k)
            {
                if (textBox1.Text.Equals(x.korisnickoIme) &&
                    textBox2.Text.Equals(x.lozinka))
                {
                    loginS = true;

                }
                if (loginS)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    LoginSuccesful(textBox1.Text);
                }
                else
                {
                    LoginFailed("User not found");
                }
            }
        }
    }
}
