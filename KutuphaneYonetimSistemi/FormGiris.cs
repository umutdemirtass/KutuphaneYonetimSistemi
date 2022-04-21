using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        FormKitaplar formKitaplar;
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglati = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Integrated Security=True");

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre ="";

            try
            {
                baglati.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", baglati);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullan�c�Adi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }
                

                if (sifre == textBoxSifre.Text)
                {
                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();

                }
                else
                {
                    MessageBox.Show("Kullan�c� Ad� veya �ifre Hatal� !");
                    textBoxKullan�c�Adi.Text = "";
                    textBoxSifre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� Hatas�"+ ex.Message);
            }
            finally
            {
                baglati.Close();
            }

        }
    }
}