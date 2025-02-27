using _3_OOPTemelPrensipler1.Entities;

namespace _3_OOPTemelPrensipler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product urun = new Product();
            urun.ProductID = 1;
            urun.ProductName = "Rode Mikrofon";
            urun.UnitPrice = 5600;
            urun.Description = "Güzel Bir mic";
            urun.UnitsInStock = 450;

            Product p = new Product()
            {
                ProductName = "DELL Laptop",
                Description = "Güzel",
                ProductID = 4,
                UnitPrice = 567,
                UnitsInStock = 67
            };
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
