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
    public partial class PregledKnjiga : UserControl
    {
        private XDocument popis;
        public event handler EndWork;
        public PregledKnjiga()
        {
            InitializeComponent();
            popis = XDocument.Load("C:\\Users\\Korisnik\\Desktop\\csh6\\popisKnjiga.xml");
            var k = from x in popis.Descendants("korisnik")
                    select new
                    {
                        autor = x.Descendants("autor").First().Value,
                        naslov = x.Descendants("naslov").First().Value,

                    };
            dataGridView1.DataSource = k.ToList();


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndWork("Thank you for using libary");
        }
    } }
