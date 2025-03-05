using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universite_Projesi
{
    public partial class Frm_Dersler : Form
    {
        public Frm_Dersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();


        private void Frm_Dersler_Load(object sender, EventArgs e)
        {
            // dataset kullanımı örneğidir add new item ile dataset oluşturduk
            // dataset ile query build ettik metod isimlendirdik "DersListesi"
            // metod Tbl_Dersler deki tüm verileri alıyor 
            // en son olarak datagrid datasource özelliğini DersListesi metoduna eşitledik
            dataGridView1.DataSource = ds.DersListesi();

        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtDersAd.Text == "")
            {
                MessageBox.Show("Girilen değerleri Kontrol ediniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ds.DersEkle(txtDersAd.Text);

                MessageBox.Show("Yeni ders eklendi, Ders Adı: " + txtDersAd.Text, "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                dataGridView1.DataSource= ds.DersListesi();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtDersAd.Text = "";
            txtDersId.Text = "";

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtDersId.Text == "")
            {
                MessageBox.Show("Id olmadan güncelleme işlemini yapamazsınız, güncellemek istediğiniz dersin üstüne tıklayınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ds.DersGuncelle(txtDersAd.Text, byte.Parse(txtDersId.Text));
                MessageBox.Show("Güncelleme işlemi yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = ds.DersListesi();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtDersId.Text == "")
            {
                MessageBox.Show("Id olmadan silme işlemini yapamazsınız, silmek istediğiniz dersin üstüne tıklayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ds.DersSil(byte.Parse(txtDersId.Text));
                MessageBox.Show("Silme işlemi yapıldı silinen ders: " + txtDersAd.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = ds.DersListesi();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtDersAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtDersId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
