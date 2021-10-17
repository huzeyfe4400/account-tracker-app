using GinkoSolutions;
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
    public partial class Musteri : Form
    {

      
        public Musteri()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=HesapTakipVeritabanı.accdb");
        OleDbDataAdapter da2;
        DataTable dt;
        string sql = "SELECT * FROM Musteri";
        OleDbConnection baglanti;
        OleDbCommand komut, komut2;
        OleDbDataAdapter da;
        public string musteriId { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            if(musteriId!=null)
            {
       

                con.Open();
                da = new OleDbDataAdapter("Select * From Musteri WHERE MusteriNo=" + musteriId + "", con);
                DataTable table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {

                        txtad.Text = row.ItemArray[1].ToString();
                        txtsoyad.Text = row.ItemArray[2].ToString();
                        txttelefon.Text = row.ItemArray[3].ToString();
                        txtSemt.Text = row.ItemArray[5].ToString();
                        txtadres.Text = row.ItemArray[4].ToString();
                    }
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (musteriId == null)
                {
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HesapTakipVeritabanı.accdb");
                    baglanti.Open();
                    string sorgu = "Insert into Musteri(Ad,Soyad,Telefon,Adres,Semt) " +
                        "values (@ad,@soyad,@telefon,@adres,@Semt)";
                    komut2 = new OleDbCommand(sorgu, baglanti);
                    komut2.Parameters.AddWithValue("@ad", txtad.Text);
                    komut2.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                    komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
                    komut2.Parameters.AddWithValue("@adres", txtadres.Text);
                    komut2.Parameters.AddWithValue("@Semt", txtSemt.Text);

                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    txtad.Text = "";
                    txtsoyad.Text = "";
                    txtadres.Text = "";
                    txttelefon.Text = "";
                    txtSemt.Text = "";
                    MessageBox.Show("Müşteri Kaydedildi");
                }
                else if (musteriId != null)
                {
                    con.Open();
                    string guncel = "UPDATE Musteri SET Ad=@Ad,  Soyad=@Soyad,  Telefon=@Telefon,  Adres=@Adres,  Semt=@Semt  WHERE MusteriNo=" + musteriId;

                    komut = new OleDbCommand(guncel, con);
                    komut.Parameters.AddWithValue("@Ad", txtad.Text);
                    komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                    komut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                    komut.Parameters.AddWithValue("@Adres", txtadres.Text);
                    komut.Parameters.AddWithValue("@Semt", txtSemt.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi.");
                    con.Close();
                }
            


            }
            catch (Exception exp)
            {
                MessageBox.Show("Müşteri Kaydedilirken Hata!"+exp.Message);
            }



        }
    }
}
