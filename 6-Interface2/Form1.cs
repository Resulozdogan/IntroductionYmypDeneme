using _6_Interface2.Entities;

namespace _6_Interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GarantiBankasi g = new GarantiBankasi();
            g.BankID = 1;
            g.BankName = "Garanti";
                
            ZiraatBankasi z = new ZiraatBankasi();
            z.BankID = 2;
            z.BankName = "Ziraat";

            BankRepository bankRepo = new BankRepository(g);
            BankRepository bankRepo2 = new BankRepository(z);
        }
    }
}
