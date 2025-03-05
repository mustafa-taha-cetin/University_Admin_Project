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
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }


        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Uni_Projesi;Integrated Security=True;");

        private void button3_Click(object sender, EventArgs e)
        {
            txtDurum.Text = "";
            txtOgreciAd.Text = "";
            txtOgrenciId.Text = "";
            txtOrtalama.Text = "";
            txtProje.Text = "";
            txtSinav1.Text = "";
            txtSinav2.Text = "";
            cmbDersAd.Text = "";
            lblId.Text = "";
            
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListele();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select Ders_Ad From Tbl_Dersler",baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDersAd.Items.Add(dr[0].ToString());
            }

            baglanti.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            lblId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOgrenciId.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtProje.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtOgreciAd.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            cmbDersAd.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if(txtSinav1.Text == "" || txtSinav2.Text == "" || txtProje.Text == "")
            {
                MessageBox.Show("Tüm değerler girilmeden ortalama hesaplanamaz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int s1, s2, proje;
                float avg, sonuc;

                s1 = Convert.ToInt16(txtSinav1.Text);
                s2 = Convert.ToInt16(txtSinav2.Text);
                proje = Convert.ToInt16(txtProje.Text);
                avg = s1 + s2 + proje;
                sonuc = avg / 3;

                if (s1>100 || s2>100)
                {
                    MessageBox.Show("Sınavlar 100 değerinden büyük girilemez","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (proje > 100)
                {
                    MessageBox.Show("Proje 100 değerinden büyük olamaz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    txtOrtalama.Text = sonuc.ToString();

                    if (sonuc >= 50)
                    {
                        lblKontrol.Text = "Geçti";
                        txtDurum.Text = "True";
                    }
                    else
                    {
                        lblKontrol.Text = "Kaldı";
                        txtDurum.Text = "False";
                    }

                    MessageBox.Show("Ortalama hesaplandı, Öğrencinin ortalaması: " + txtOrtalama.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Update Tbl_Notlar set Sinav1=@s1, Sinav2=@s2,Proje=@p,Ortalama=@o,Durum=@d where Not_Id=@n",baglanti);

            komut.Parameters.AddWithValue("@n",lblId.Text);
            komut.Parameters.AddWithValue("@s1",txtSinav1.Text);
            komut.Parameters.AddWithValue("@s2",txtSinav2.Text);
            komut.Parameters.AddWithValue("@p",txtProje.Text);
            komut.Parameters.AddWithValue("@o",txtOrtalama.Text);
            komut.Parameters.AddWithValue("@d",txtDurum.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            dataGridView1.DataSource = ds.NotListele();

            MessageBox.Show("Güncelleme işlemi yapıldı, güncellenen öğrencinin adı: " + txtOgreciAd.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
