using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR_PROYEKTO
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            lblemail.Text = Form1.SetValueForText1;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void lblemail_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_image2txt_Click(object sender, EventArgs e)
        {
            
            Frm_imgtxt frm_Imgtxt = new Frm_imgtxt();
            frm_Imgtxt.Show();
            this.Hide();
        }
    }
}
