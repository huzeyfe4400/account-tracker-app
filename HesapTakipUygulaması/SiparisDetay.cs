using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapTakipUygulaması
{
    public partial class SiparisDetay : Form
    {
        public SiparisDetay()
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

        public string siparis { get; set; }

        private void SiparisDetay_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new OleDbDataAdapter("Select *From SiparisUrun WHERE SiparisId='"+siparis+"'", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            con.Close();
            ArrangeGrid(dataGridView2);

            con.Open();
            da = new OleDbDataAdapter("Select * From Siparis WHERE SiparisId=" + siparis + "", con);
            DataTable table = new DataTable();
            da.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {

                    txttoplam.Text = row.ItemArray[2].ToString();
                    txtodenen.Text = row.ItemArray[3].ToString();
                    txtkalan.Text = row.ItemArray[4].ToString();
                }
            }
            con.Close();
        }

        private void txtOdenen_TextChanged(object sender, EventArgs e)
        {
           
            if (txtodenen.Text != "")
            {
                double kalan = Convert.ToDouble(txttoplam.Text) - Convert.ToDouble(txtodenen.Text);
                txtkalan.Text = kalan.ToString();
            }
            else
            {
                txtkalan.Text = txttoplam.Text;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string guncel = "UPDATE Siparis SET Odenen=@Odenen,  Kalan=@Kalan WHERE SiparisId=" + siparis;

            komut = new OleDbCommand(guncel, con);
            komut.Parameters.AddWithValue("@Odenen", txtodenen.Text);
            komut.Parameters.AddWithValue("@Kalan", txtkalan.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncellendi.");
            con.Close();

        }

        private void txtodenen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtkalan_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
