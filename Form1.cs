using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Universite_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Uni_Projesi;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Ogrenci_Id;
        public string Ogrenci_Ad;

        public string Ogretmen_Id;
        public string Ogretmen_Ad;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select Ogrenci_Id,Ogrenci_Ad From Tbl_Ogrenciler where Ogrenci_Id=@p",baglanti);
            komut.Parameters.AddWithValue("@p",txtOgrenciId.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Ogrenci_Ad = dr[1].ToString();
                Ogrenci_Id = dr[0].ToString();

            }

            if (txtOgrenciAd.Text == Ogrenci_Ad && txtOgrenciId.Text == Ogrenci_Id)
            {

                Frm_Ogrenci_Not fr = new Frm_Ogrenci_Not();
                fr.Id = Ogrenci_Id;
                fr.Ad = Ogrenci_Ad;
                fr.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select Ogretmen_Id,Ogretmen_Ad From Tbl_Ogretmenler where Ogretmen_Id=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txtOgretmenId.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                Ogretmen_Ad = dr[1].ToString();
                Ogretmen_Id = dr[0].ToString();

            }

            if (txtOgretmenAd.Text == Ogretmen_Ad && txtOgretmenId.Text == Ogretmen_Id)
            {
                Frm_Ogretmen fr = new Frm_Ogretmen();
                fr.Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show("Girdiğiniz değerleri lütfen kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            baglanti.Close();


        }
    }
}
