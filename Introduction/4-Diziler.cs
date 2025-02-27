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
    public partial class _4_Diziler : Form
    {
        public _4_Diziler()
        {
            InitializeComponent();
        }

        private void _4_Diziler_Load(object sender, EventArgs e)
        {
            /*
             Diziler (Arrays):
            */

            //Dizi tanımlama
            string[] liste = new string[3];

            //diziye değer atama:
            liste[0] = "Resul";

            //diziden değer okuma:
            string ad = liste[0];

            //Dizi metodları:
            Array.Sort(liste);
            //Array. ile istediğin diziye istediğin yöntemi uygula
            //parantez içinde koyu mavi 'ref' görürsen mutlaka parantez içine koy
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        string[] studentList = new string[1];
        int a = 0;


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = $"{txtName.Text} {txtSurname.Text}";

            studentList[a] = adSoyad;
            a++;
            Array.Resize(ref studentList, studentList.Length + 1);

        }
    }
}
