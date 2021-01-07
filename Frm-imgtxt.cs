using System;
using IronOcr;
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
    public partial class Frm_imgtxt : Form
    {
        public Frm_imgtxt()
        {
            InitializeComponent();
        }
        Bitmap image = new Bitmap("1596978.jpg");
        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                image = new Bitmap(file.FileName);
                pictureBox1.Image = image;
            }
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            var ocr = new AutoOcr();
            txtbox_extracted.Text = ocr.Read(image).ToString();
        }
    }
}
