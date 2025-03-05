using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universite_Projesi
{
    public partial class Frm_Kulup : Form
    {
        public Frm_Kulup()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Uni_Projesi;Integrated Security=True;");


        void listele()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Tbl_Kulupler", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }

        private void Frm_Kulup_Load(object sender, EventArgs e)
        {

            dataGridView1.DefaultCellStyle.Font = new Font("Corbel", 18);

            listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtKulupAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKulupId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnListe_Click(object sender, EventArgs e)
        {

            listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtKulupAd.Text == "" )
            {
                MessageBox.Show("Lütfen Tüm değerleri giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Tbl_Kulupler (Kulup_Ad) values (@k2)", baglanti);

                komut.Parameters.AddWithValue("@k2", txtKulupAd.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Yeni kulüp eklenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            }



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKulupAd.Text=="" || txtKulupId.Text=="")
            {
                MessageBox.Show("Lütfen Tüm değerleri giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                baglanti.Open();

                SqlCommand komut2 = new SqlCommand("Update Tbl_Kulupler set Kulup_Ad=@p1 where Kulup_Id=@p", baglanti);

                komut2.Parameters.AddWithValue("@p", txtKulupId.Text);
                komut2.Parameters.AddWithValue("@p1", txtKulupAd.Text);

                komut2.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kulüp Güncellenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtKulupAd.Text == "" || txtKulupId.Text == "")
            {
                MessageBox.Show("Lütfen Tüm değerleri giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                baglanti.Open();

                SqlCommand komu3 = new SqlCommand("Delete from Tbl_Kulupler where Kulup_Id=@p1 and Kulup_Ad=@p2", baglanti);
                komu3.Parameters.AddWithValue("@p1", txtKulupId.Text);
                komu3.Parameters.AddWithValue("@p2", txtKulupAd.Text);

                komu3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kulüp silinmiştir, silinen kulüp: " + txtKulupAd.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtKulupAd.Text = "";
            txtKulupId.Text = "";

        }
    }
}
