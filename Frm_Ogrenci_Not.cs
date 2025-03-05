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
    public partial class Frm_Ogrenci_Not : Form
    {
        public Frm_Ogrenci_Not()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Uni_Projesi;Integrated Security=True;");

        public string Id;
        public string Ad;

        private void Frm_Ogrenci_Not_Load(object sender, EventArgs e)
        {
            label1.Text = Id;
            label2.Text = Ad;

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select Ders_Ad,Sinav1,Sinav2,Proje,Ortalama,Durum From Tbl_Notlar\r\ninner join Tbl_Dersler on Tbl_Notlar.Ders_Id = Tbl_Dersler.Ders_Id where Ogrenci_Id=@p", baglanti);
            // inner join kullanarak tablolar arasında verileri birbirine eşitlemiş olduk ÖNEMLİ
            komut.Parameters.AddWithValue("@p",Id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            this.Text = "No: " + Id + " " + Ad;

            baglanti.Close();


        }

        

        
    }
}
