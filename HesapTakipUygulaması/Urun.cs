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
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HesapTakipVeritabanı.accdb");
        OleDbDataAdapter da2;
        DataTable dt;
        OleDbConnection baglanti;
        OleDbCommand komut, komut2;
        OleDbDataAdapter da;
        public string urunId { get; set; }

        private void Urun_Load(object sender, EventArgs e)
        {
            if (urunId != null)
            {


                con.Open();
                da = new OleDbDataAdapter("Select * From Urun WHERE UrunId=" + urunId + "", con);
                DataTable table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {

                        txtad.Text = row.ItemArray[1].ToString();
                        txtdetay.Text = row.ItemArray[2].ToString();
                        txtfiyat.Text = row.ItemArray[3].ToString();
                  
                    }
                }
                con.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                if (urunId == null)
                {
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HesapTakipVeritabanı.accdb");

                    baglanti.Open();
                    string sorgu = "Insert into Urun(UrunAd,UrunDetay,UrunFiyat) " +
                        "values (@ad,@detay,@fiyat)";
                    komut2 = new OleDbCommand(sorgu, baglanti);
                    komut2.Parameters.AddWithValue("@ad", txtad.Text);
                    komut2.Parameters.AddWithValue("@fiyat", txtdetay.Text);
                    komut2.Parameters.AddWithValue("@detay", txtfiyat.Text);

                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    txtad.Text = "";
                    txtfiyat.Text = "";
                    txtdetay.Text = "";
                    MessageBox.Show("Ürün Kaydedildi");
                }
                else if (urunId != null)
                {
                    con.Open();
                    string guncel = "UPDATE Urun SET UrunAd=@UrunAd,  UrunDetay=@UrunDetay,  UrunFiyat=@UrunFiyat  WHERE UrunId=" + urunId;

                    komut = new OleDbCommand(guncel, con);
                    komut.Parameters.AddWithValue("@UrunAd", txtad.Text);
                    komut.Parameters.AddWithValue("@UrunDetay", txtdetay.Text);
                    komut.Parameters.AddWithValue("@UrunFiyat", txtfiyat.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi.");
                    con.Close();
                }



            }
            catch (Exception exp)
            {
                MessageBox.Show("Müşteri Kaydedilirken Hata!" + exp.Message);
            }






       
        }
    }
}
