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
    public partial class Frm_Ogrenci : Form
    {
        public Frm_Ogrenci()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Uni_Projesi;Integrated Security=True;");


        DataSet1TableAdapters.Tbl_OgrencilerTableAdapter ds = new DataSet1TableAdapters.Tbl_OgrencilerTableAdapter();


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbKulup.Text = "";
            txtOgrenciAd.Text = "";
            txtOgrenciId.Text = "";
            txtOgrenciSoyad.Text = "";
            rdbErkek.Checked = false;
            rdbKiz.Checked = false;
            lblKontrol.Text = "Null";

        }

        private void rdbKiz_CheckedChanged(object sender, EventArgs e)
        {
            lblKontrol.Text = "Kız";
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            lblKontrol.Text = "Erkek";
        }

        private void Frm_Ogrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Corbel", 16);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 16, FontStyle.Bold);
            dataGridView1.DataSource = ds.OgrenciListesi();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * From Tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulup.DisplayMember = "Kulup_Ad";
            cmbKulup.ValueMember = "Kulup_Id";
            cmbKulup.DataSource = dt;

            baglanti.Close();

        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtOgrenciAd.Text == "" || txtOgrenciSoyad.Text == "" || cmbKulup.Text=="" || lblKontrol.Text == "Null")
            {
                MessageBox.Show("Tüm değerleri girmeden öğrenci kayıt işlemi yapamazsınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ds.OgrenciEkle(txtOgrenciAd.Text, txtOgrenciSoyad.Text, byte.Parse(cmbKulup.SelectedValue.ToString()), lblKontrol.Text);
                MessageBox.Show("Yeni öğrenci kaydı yapılıd, Öğrenci adı: " + txtOgrenciAd.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information );
                dataGridView1.DataSource = ds.OgrenciListesi();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtOgrenciId.Text == "")
            {
                MessageBox.Show("Öğrenci Id olmadan silme işlemi yapamazsınız, silmek istediğiniz öğrencinin üstüne tıklayın","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ds.OgrenciSil(Convert.ToInt32(txtOgrenciId.Text));
                MessageBox.Show("Öğrenci silinmiştir, Silinen Öğrenci: " + txtOgrenciAd.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = ds.OgrenciListesi();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtOgrenciAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtOgrenciId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOgrenciSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbKulup.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblKontrol.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            if(lblKontrol.Text == "Erkek")
            {
                rdbErkek.Checked = true;
            }
            else
            {
                rdbKiz.Checked = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtOgrenciId.Text == "")
            {
                MessageBox.Show("Id olmadan öğrenciyi güncelleyemezsiniz, lütfen güncellemek istediğiniz öğrencinin üzerine tıklayın","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ds.OgrenciGuncelle(txtOgrenciAd.Text, txtOgrenciSoyad.Text, byte.Parse(cmbKulup.SelectedValue.ToString()), lblKontrol.Text, Convert.ToInt32(txtOgrenciId.Text));
                MessageBox.Show("Güncelleme işlemi yapılmıştır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = ds.OgrenciListesi();
            }
        }
    }
}
