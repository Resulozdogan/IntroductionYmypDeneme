using System.Collections;

namespace Introduction
{
    public partial class _10_KursTakip : Form
    {
        public _10_KursTakip()
        {
            InitializeComponent();
        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            String a = null;
            foreach (var item in grpEgitimler.Controls)
            {
                if (item is CheckBox)
                {
                    if (((CheckBox)item).Checked)
                    {
                        list.Add(((CheckBox)item).Text);
                    }
                }
            }
            a = string.Join(",", list);
            lstListe.Items.Add($"{txtTc.Text} - {txtAdSoyad.Text} ----> {a}");

            foreach (var item in this.Controls)
            {
                if (true)
                {
                    
                }
            }

        }

    }
}
