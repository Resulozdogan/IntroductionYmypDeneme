using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace _2_Ado.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string? CategoryID = null;
        string? ProductID = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbSqlConnection"].ConnectionString);
                SqlCommand cmdCategoryAdd = new SqlCommand("Select CategoryID, CategoryName from Categories", con);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategoryAdd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCategories.DisplayMember = "CategoryName";
                cmbCategories.ValueMember = "CategoryID";
                cmbCategories.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedValue != null)
            {
                CategoryID = cmbCategories.SelectedValue?.ToString();
                try
                {
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbSqlConnection"].ConnectionString);
                    SqlCommand cmdProduct = new SqlCommand($"Select ProductName, ProductID From Products Where CategoryID = {CategoryID}", con);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmdProduct);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    lstProductList.DisplayMember = "ProductName";
                    lstProductList.ValueMember = "ProductID";
                    lstProductList.DataSource = dt1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                lblUrunAdedi.Text = lstProductList.Items.Count.ToString();


            }
        }
        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedValue != null)
            {
                ProductID = lstProductList.SelectedValue?.ToString();
                try
                {
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbSqlConnection"].ConnectionString);
                    SqlCommand cmdOD = new SqlCommand($"Select * From [Order Details] Where ProductID = {ProductID}", con);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmdOD);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dgwDetay.DataSource = dt2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
