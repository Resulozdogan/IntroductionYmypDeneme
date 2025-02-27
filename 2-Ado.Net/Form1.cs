using System.Data;
using Microsoft.Data.SqlClient;

namespace _2_Ado.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cn = @"Data Source=DESKTOP-NE6Q9OF\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True; Trust Server Certificate=True";
        SqlConnection con;
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cn);
                con.Open();
                //MessageBox.Show("Baðlantý Açýldý");
                SqlCommand cmd = new SqlCommand("Select * from Products", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string urunAdi = dr["ProductName"].ToString() ?? "--";
                    int id = Convert.ToInt32(dr["ProductID"]);
                    double birimFiyat = Convert.ToDouble(dr["UnitPrice"]);
                    lstListe.Items.Add($"{id}--{urunAdi}--{birimFiyat}");
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cn);
                SqlCommand cmd = new SqlCommand("Select CategoryID,CategoryName,Description from Categories", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lstListe.DisplayMember = "CategoryName";
                lstListe.ValueMember = "CategoryID";
                lstListe.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string urunAdi = txtPrdName.Text;
                con = new SqlConnection(cn);
                con.Open();
                SqlCommand cmdEkle = new SqlCommand("Insert into Products (ProductName,UnitPrice,Discontinued) values (@name,@price,@disc)", con);
                cmdEkle.Parameters.AddWithValue("@name", urunAdi);
                cmdEkle.Parameters.AddWithValue("@price", 10);
                cmdEkle.Parameters.AddWithValue("@disc", true);

                int sonuc = cmdEkle.ExecuteNonQuery();

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
        string id;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedValue != null)
            {
                id = lstListe.SelectedValue.ToString();
                txtPrdName.Text = lstListe.Text;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cn);
                con.Open();
                SqlCommand cmdUpdate = new SqlCommand("update Categories set CategoryName = @cname where CategoryID = @id", con);
                cmdUpdate.Parameters.AddWithValue("@cname", txtPrdName.Text);
                cmdUpdate.Parameters.AddWithValue("@id", id);

                int sonuc = cmdUpdate.ExecuteNonQuery();

                string mesaj = sonuc > 0 ? "Güncelleme Ýþlemi Baþarýlý" : "Bir Hata Oluþtu";
                MessageBox.Show(mesaj);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cn);
                con.Open();
                SqlCommand cmdsil = new SqlCommand("Delete from Categories where CategoryID = @id", con);
                cmdsil.Parameters.AddWithValue("@id", id);
                int sonuc = cmdsil.ExecuteNonQuery();
                string mesaj = sonuc > 0 ? "Silme Ýþlemi Baþarýlý" : "Bir Hata oluþtu";
                MessageBox.Show(mesaj);


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
