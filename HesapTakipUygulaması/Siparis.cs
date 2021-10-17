using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapTakipUygulaması
{
    public partial class Siparis : Form
    {
        public Siparis()
        {


            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HesapTakipVeritabanı.accdb");
        OleDbDataAdapter da2;
        DataTable dt;
        string sql = "SELECT * FROM Musteri";
        OleDbConnection baglanti;
        OleDbCommand komut, komut2;
        OleDbDataAdapter da;

        DataTable table = new DataTable();
        public int sayac = 0;
        public string musteri { get; set; }
        public string urun { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtDetay.Text != "" && txtfiyat.Text != "" && txtMiktar.Text != "")
            {
                double toplamtutarsatir = Convert.ToDouble(txtMiktar.Text) * Convert.ToDouble(txtfiyat.Text);
                table.Rows.Add(comboBox1.Text.ToString(), comboBox2.Text.ToString(), txtMiktar.Text, txtDetay.Text, toplamtutarsatir);
                dataGridView1.DataSource = table;
                comboBox2.Refresh();
                txtDetay.Text = null;
                txtMiktar.Text = null;
                txtfiyat.Text = null;
                toplamtutar();
            }
            else
            {
                MessageBox.Show("Eksik bilgi var!");
            }

            //table.Rows.Add(txtMiktar.Text, txtDetay.Text);
            //dataGridView1.DataSource = table;
            //try
            //{
            //    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HesapTakipVeritabanı.accdb");

            //    baglanti.Open();
            //    string sorgu = "INSERT INTO SiparisUrun(SiparisId,UrunId,Miktar,Detay) " +
            //        "values (@SiparisId,@UrunId,@Miktar,@Detay)";

            //    komut2 = new OleDbCommand(sorgu, baglanti);
            //    komut2.Parameters.AddWithValue("@SiparisId", comboBox1.SelectedValue.ToString());
            //    komut2.Parameters.AddWithValue("@UrunId", comboBox2.SelectedValue.ToString());
            //    komut2.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
            //    komut2.Parameters.AddWithValue("@Detay", txtDetay.Text);

            //    komut2.ExecuteNonQuery();
            //    baglanti.Close();
            //    baglanti.Open();
            //    da = new OleDbDataAdapter("Select * From SiparisUrun", baglanti);
            //    DataTable tablo = new DataTable();
            //    da.Fill(tablo);
            //    dataGridView1.DataSource = tablo;
            //    baglanti.Close();
            //    ArrangeGrid(dataGridView1);

            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Ürün Eklenirken Hata! Detay : " + exp.Message);
            //}
        }

        public static void ArrangeGrid(DataGridView Grid)
        {
            if (Grid.Rows.Count > 0)
            {
                for (int i = 0; i < Grid.Columns.Count; i++)
                {

                    DataGridViewColumn column = Grid.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
            toplamtutar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {

                for (int i = dataGridView1.Rows.Count - 2; i >= 0; i--)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);

                }
            }
            dataGridView1.Refresh();
            comboBox1.Refresh();
            comboBox2.Refresh();
            txtDetay.Text = null;
            txtMiktar.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string siparisid = "";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HesapTakipVeritabanı.accdb");

                baglanti.Open();
                string sorgu = "INSERT INTO Siparis(MusteriId,Tutar,Odenen,Kalan,Tarih) " +
                    "values (@MusteriId,@Tutar,@Odenen,@Kalan,@Tarih)";

                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@MusteriId", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("@Tutar", lbltoplam.Text);
                komut.Parameters.AddWithValue("@Odenen", txtOdenen.Text);
                komut.Parameters.AddWithValue("@Kalan", txtKalan.Text);
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());

                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                da = new OleDbDataAdapter("Select TOP 1 SiparisId From Siparis ORDER BY SiparisId DESC", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    foreach (DataRow row in tablo.Rows)
                    {

                        siparisid = row.ItemArray[0].ToString();
                    }
                }
                baglanti.Close();

                baglanti.Open();
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HesapTakipVeritabanı.accdb");

                baglanti.Open();
                if (dataGridView1.Rows.Count > 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                        {
                            string sorgu2 = "INSERT INTO SiparisUrun(SiparisId,UrunId,Miktar,Detay) " +
                    "values (@SiparisId,@UrunId,@Miktar,@Detay)";

                            komut2 = new OleDbCommand(sorgu2, baglanti);
                            komut2.Parameters.AddWithValue("@SiparisId", siparisid);
                            komut2.Parameters.AddWithValue("@UrunId", row.Cells[1].Value.ToString());
                            komut2.Parameters.AddWithValue("@Miktar", row.Cells[2].Value.ToString());
                            komut2.Parameters.AddWithValue("@Detay", row.Cells[3].Value.ToString());

                            komut2.ExecuteNonQuery();
                        }

                    }
                    MessageBox.Show("Sipariş Başarılı bir şekilde oluşturuldu.");
                }

                baglanti.Close();



            }
            catch (Exception exp)
            {
                MessageBox.Show("Ürün Eklenirken Hata! Detay : " + exp.Message);
            }
        }


        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            da = new OleDbDataAdapter("Select * From Urun WHERE UrunId=" + comboBox2.SelectedValue.ToString() + "", con);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);

            if (tablo2.Rows.Count > 0)
            {
                foreach (DataRow row in tablo2.Rows)
                {

                    txtDetay.Text = row.ItemArray[2].ToString();
                    txtfiyat.Text = row.ItemArray[3].ToString();
                }
            }
        }


        private void toplamtutar()
        {
            double toplam = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                toplam += Convert.ToDouble(row.Cells[4].Value);
            }
            lbltoplam.Text = toplam.ToString();
            txtKalan.Text = toplam.ToString();
        }

        private void txtOdenen_TextChanged(object sender, EventArgs e)
        {
            if (txtOdenen.Text != "")
            {
                double kalan = Convert.ToDouble(lbltoplam.Text) - Convert.ToDouble(txtOdenen.Text);
                txtKalan.Text = kalan.ToString();
            }
            else
            {
                txtKalan.Text = lbltoplam.Text;
            }

        }

        private void txtOdenen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtKalan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void Siparis_Load(object sender, EventArgs e)
        {

            table.Columns.Add("MÜŞTERİ", typeof(string));
            table.Columns.Add("ÜRÜN", typeof(string));
            table.Columns.Add("MİKTAR", typeof(string));
            table.Columns.Add("DETAY", typeof(string));
            table.Columns.Add("TUTAR", typeof(string));
            dataGridView1.DataSource = table;
            ArrangeGrid(dataGridView1);

            con.Open();
            da = new OleDbDataAdapter("Select * From Musteri", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            comboBox1.DataSource = tablo;
            comboBox1.DisplayMember = "MusteriAd";
            comboBox1.ValueMember = "Musterino";
            con.Close();
            con.Open();
            da = new OleDbDataAdapter("Select * From Urun", con);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            comboBox2.DataSource = tablo2;
            comboBox2.DisplayMember = "UrunAd";
            comboBox2.ValueMember = "UrunId";
        }
    }
}
