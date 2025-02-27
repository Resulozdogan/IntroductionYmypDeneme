using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            int age = 25;
            bool ehliyet = true;

            if (age >= 18 && ehliyet == true)
            {
                MessageBox.Show("Kullanabilir");
            }
            else
            {
                MessageBox.Show("Kullanamaz");
            }
        }

        private void btnVeya_Click(object sender, EventArgs e)
        {
            decimal sepetTutarı = 2500;
            bool kupon = false;

            if (sepetTutarı > 2000 || kupon == true)
            {
                MessageBox.Show("indirim ver");
            }
            else
            {
                MessageBox.Show("indirim verme");
            }

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);

            if (500<=tutar && tutar<=1000)
            {
                MessageBox.Show("%20 indirim");
            }

            else if (1000<tutar && tutar<=2500)
            {
                MessageBox.Show("%25 indirim");
            }
            
            else if (2500<tutar && tutar<=5000)
            {
                MessageBox.Show("%35 indirim");
            }
            
            else if (tutar>5000)
            {
                MessageBox.Show("%45 indirim");
            }
            





        }
    }
}
