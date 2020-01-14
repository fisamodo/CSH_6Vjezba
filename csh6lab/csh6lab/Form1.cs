using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csh6lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Subscribe();
        }


        public void Subscribe()
        {
            logIn1.LoginSuccesful += Login1_LoginSuccesful;
            logIn1.LoginFailed += Login1_LoginFailed;
            greska1.UserNotFound += Greska2_UserNotFound;
            pregledKnjiga1.EndWork += pregledKnjiga1_EndWork;
        }

        private void Login1_LoginFailed(string message)
        {
            greska1.Visible = true;
            logIn1.Visible = false;
            pregledKnjiga1.Visible = false;
        }

        private void Greska2_UserNotFound(string message)
        {
            greska1.Visible = false;
            logIn1.Visible = true;
        }
        private void Login1_LoginSuccesful(string message)
        {
            pregledKnjiga1.Visible = true;
            greska1.Visible = false;
            logIn1.Visible = false;
            
        }

        private void pregledKnjiga1_EndWork(string message)
        {
            pregledKnjiga1.Visible = true;
            logIn1.Visible = true;


        }
    }
}
