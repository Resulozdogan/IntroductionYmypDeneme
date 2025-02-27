using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class _11_RegularExpression : Form
    {
        public _11_RegularExpression()
        {
            InitializeComponent();
        }

        private void _11_RegularExpression_Load(object sender, EventArgs e)
        {
            //regular expression (düzenli ifadeler)




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtDeger.Text, "[^0-9]"))
                {
                    throw new Exception("Lütfen rakamsal");
                }

                int stokMiktari = Convert.ToInt32(txtDeger.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtDeger.Text, "[^A-Z-a-zöÖşŞ ıİüÜğĞ]"))
                {
                    throw new Exception("Alfabetik değer gir");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
