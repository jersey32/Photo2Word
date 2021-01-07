using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;
using Data.Models;

namespace OCR_PROYEKTO
{
    public partial class Form1 : Form
    {
        MicronDbContext micron = new MicronDbContext();
        public static string SetValueForText1 = "";
        public Form1()
        {
            InitializeComponent();

            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(Signin_tab);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2); 
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_toggle_Click(object sender, EventArgs e)
        {
            Signup_tab.SetPage(0);
        }

        private void register_toggle_Click(object sender, EventArgs e)
        {
            Signup_tab.SetPage(1);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            SetValueForText1 = txtemail.Text; 
            //check db
            if (txtemail.Text == "0" & txtpass.Text == "0")
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid !!");
            }
        }
    }
}
 