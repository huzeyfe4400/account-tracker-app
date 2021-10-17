using Effort.Internal.TypeGeneration;
using GinkoSolutions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapTakipUygulaması
{
    public partial class hesaptakipform : Form
    {
        public hesaptakipform()
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

        private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Musteri musteri = new Musteri();
            //musteri.Show();
            //pictureBox1.Visible = false;
            //dataGridView1.Visible = true;
        }

        private void ürünBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Urun urun = new Urun();
            //urun.Show();
            //pictureBox1.Visible = false;
            //dataGridView1.Visible = true;
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Siparis siparis = new Siparis();
            //siparis.Show();
            //pictureBox1.Visible = false;
            //dataGridView1.Visible = true;
        }

        private void hesaptakipform_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            //pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            WindowState = FormWindowState.Maximized;
            panel1.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;




        }

        private void panelpasif()
        {
            panel1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.Visible = false;
            textBox1.Visible = false;
            btnarama.Visible = false;
            //btnindir.Visible = false;
        }
        private void panelaktif()
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            comboBox1.Visible = true;
            textBox1.Visible = true;
            btnarama.Visible = true;
            //btnindir.Visible = true;
        }

        private void urunler()
        {
            con.Open();
            da = new OleDbDataAdapter("Select UrunId AS ÜRÜN_NUMARASI , UrunAd AS ÜRÜN_ADI , UrunDetay AS ÜRÜN_DETAY , UrunFiyat AS ÜRÜN_FİYATI From Urun", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView3.DataSource = tablo;
            con.Close();
            ArrangeGrid(dataGridView3);
        }

        private void musteriler()
        {
            con.Open();
            //da = new OleDbDataAdapter("Select musteri.*,MusteriBorc=(Select Tutar from Siparis where MusteriId=1) From Musteri AS musteri ", con);
            //da = new OleDbDataAdapter("SELECT P.*, SUM(C.Tutar) AS Tutar FROM Musteri P INNER JOIN Siparis C ON P.MusteriNo = C.MusteriId ", con);
            da = new OleDbDataAdapter("SELECT DISTINCT(P.MusteriNo) AS MÜŞTERİ_NUMARASI, P.MusteriAd AS MÜŞTERİ_ADI,P.Soyad AS MÜŞTERİ_SOYADI,P.Telefon AS MÜŞTERİ_TELEFON,P.Adres AS MÜŞTERİ_ADRES,P.Semt AS MÜŞTERİ_SEMT,(select sum(Kalan)  from Siparis where MusteriId=P.MusteriNo) AS MÜŞTERİ_BORC FROM Siparis C INNER JOIN Musteri P ON  C.MusteriId = P.MusteriNo", con);
            DataTable tablo = new DataTable();
            tablo.Columns.Clear();
            //tablo.Columns.Add("MÜŞTERİ NUMARASI", typeof(int));
            //tablo.Columns.Add("MÜŞTERİ ADI", typeof(string));
            //tablo.Columns.Add("MÜŞTERİ SOYADI", typeof(string));
            //tablo.Columns.Add("MÜŞTERİ TELEFON", typeof(string));
            //tablo.Columns.Add("MÜŞTERİ SEMT", typeof(string));
            //tablo.Columns.Add("MÜŞTERİ ADRES", typeof(string));
            //tablo.Columns.Add("MÜŞTERİ BORÇ", typeof(double));
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
            ArrangeGrid(dataGridView1);
        }


        private void siparisler()
        {
            con.Open();
            da = new OleDbDataAdapter("SELECT C.SiparisId AS SİPARİŞ_NUMARASI, P.MusteriAd AS MÜŞTERİ_ADI,C.Tutar AS SİPARİŞ_TUTARI,C.Odenen AS MÜŞTERİNİN_ÖDEDİĞİ,C.Kalan AS KALAN_BORÇ,C.Tarih AS SİPARİŞİN_TARİHİ FROM Musteri P INNER JOIN Siparis C ON P.MusteriNo = C.MusteriId ", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            con.Close();
            ArrangeGrid(dataGridView2);
        }


        private void kayıtlıMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpasif();
            pictureBox1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Visible = true;
            musteriler();
        }

        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
        }

        private void kayıtlıÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpasif();
            pictureBox1.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;

            urunler();

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Show();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.Show();
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelaktif();

            pictureBox1.Visible = false;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            dataGridView2.Visible = true;
            siparisler();

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





        private void btnarama_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "";
                sql += "SELECT C.SiparisId AS SİPARİŞ_NUMARASI, P.MusteriAd AS MÜŞTERİ_ADI,C.Tutar AS SİPARİŞ_TUTARI,C.Odenen AS MÜŞTERİNİN_ÖDEDİĞİ,C.Kalan AS KALAN_BORÇ,C.Tarih AS SİPARİŞİN_TARİHİ FROM Musteri P INNER JOIN Siparis C ON P.MusteriNo = C.MusteriId  Where ";
                if (dateTimePicker1.Value.ToShortDateString() != null && dateTimePicker2.Value.ToShortDateString() != null)
                {
                    sql += " C.Tarih BETWEEN '" + dateTimePicker1.Value.ToShortDateString() + "' AND '" + dateTimePicker2.Value.ToShortDateString() + "'";
                }
                if (comboBox1.SelectedIndex.ToString() == "0")
                {
                    sql += " AND  P.MusteriAd LIKE '%" + textBox1.Text + "%'";
                }
                if (comboBox1.SelectedIndex.ToString() == "1")
                {
                    sql += " AND C.SiparisId = " + textBox1.Text;
                }



                da = new OleDbDataAdapter(sql, con);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = tablo;
                    dataGridView2.Update();
                    dataGridView2.Refresh();
                    con.Close();
                    ArrangeGrid(dataGridView2);
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı!");
                    con.Close();
                }

            }
            catch (Exception exp)
            {
                con.Close();
                MessageBox.Show(exp.Message);
            }

        }

        private void btnindir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Visible == true)
            {
                DokumanIndir(dataGridView1, 1);
            }
            else if (dataGridView2.Rows.Count > 0 && dataGridView2.Visible == true)
            {
                DokumanIndir(dataGridView2, 2);
            }
            else if (dataGridView3.Rows.Count > 0 && dataGridView3.Visible == true)
            {
                DokumanIndir(dataGridView3, 3);
            }
        }

        private void DokumanIndir(DataGridView dataGridView, int dokumankod)
        {

            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel (.xlsx)|  *.xlsx";
                sfd.FileName = "Output.xlsx";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Veriler Yazılamadı!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {


                            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                            Microsoft.Office.Interop.Excel._Workbook workbook = XcelApp.Workbooks.Add(Type.Missing);
                            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                            worksheet = workbook.ActiveSheet;
                            if (dokumankod == 2)
                            {
                                worksheet.Name = "Siparişler";
                            }
                            if (dokumankod == 3)
                            {
                                worksheet.Name = "Müşteriler";

                            }
                            if (dokumankod == 1)
                            {
                                worksheet.Name = "Ürünler";

                            }
                            worksheet.Application.ActiveWindow.SplitRow = 1;
                            worksheet.Application.ActiveWindow.FreezePanes = true;

                            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                            {
                                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                                worksheet.Cells[1, i].Font.NAME = "Calibri";
                                worksheet.Cells[1, i].Font.Bold = true;
                                worksheet.Cells[1, i].Interior.Color = Color.Wheat;
                                worksheet.Cells[1, i].Font.Size = 12;
                            }


                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                                }

                                if (dokumankod == 2)
                                {
                                    var xlSheets = workbook.Sheets as Microsoft.Office.Interop.Excel.Sheets;
                                    var xlNewSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                                    xlNewSheet.Name = "" + dataGridView.Rows[i].Cells[0].Value.ToString() + "";
                                    siparisdetay(dataGridView.Rows[i].Cells[0].Value.ToString());

                                    //con.Open();
                                    //da = new OleDbDataAdapter("SELECT * FROM SiparisUrun Where SiparisId='" + dataGridView.Rows[i].Cells[0].Value.ToString() + "'", con);
                                    //DataTable tablo = new DataTable();
                                    //da.Fill(tablo);
                                    //dataGridView4.DataSource = tablo;
                                    //con.Close();

                                    for (int ik = 1; ik < dataGridView4.Columns.Count + 1; ik++)
                                    {
                                        xlNewSheet.Cells[1, ik] = dataGridView4.Columns[ik - 1].HeaderText;
                                        xlNewSheet.Cells[1, ik].Font.NAME = "Calibri";
                                        xlNewSheet.Cells[1, ik].Font.Bold = true;
                                        xlNewSheet.Cells[1, ik].Interior.Color = Color.Wheat;
                                        xlNewSheet.Cells[1, ik].Font.Size = 12;
                                    }

                                    for (int ikk = 0; ikk < dataGridView4.Rows.Count; ikk++)
                                    {
                                        for (int jkk = 0; jkk < dataGridView4.Columns.Count; jkk++)
                                        {
                                            xlNewSheet.Cells[ikk + 2, jkk + 1] = dataGridView4.Rows[ikk].Cells[jkk].Value.ToString();
                                        }
                                    }


                                }

                            }
                            workbook.Save();
                            //workbook.Sheets.Move(After: workbook.Sheets.Count);


                            if (dokumankod == 2)
                            {
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 4] = "Genel Toplam :";
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 3] = toplamtutar();
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 4].Font.NAME = "Calibri";
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 4].Font.Bold = true;
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 4].Interior.Color = Color.Wheat;
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 4].Font.Size = 12;

                            }
                            else if (dokumankod == 1)
                            {
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 1] = "Genel Toplam :";
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count] = toplamtutarmusteri();

                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 1].Font.NAME = "Calibri";
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 1].Font.Bold = true;
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 1].Interior.Color = Color.Wheat;
                                worksheet.Cells[dataGridView.Rows.Count + 4, dataGridView.Columns.Count - 1].Font.Size = 12;


                            }

                            
                            worksheet.Columns.AutoFit();
                            workbook.SaveAs(sfd.FileName);
                            XcelApp.Quit();

                            ReleaseObject(worksheet);
                            ReleaseObject(workbook);
                            ReleaseObject(XcelApp);

                            MessageBox.Show("Döküman Kaydedildi.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("HATA :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dışa Aktarılacak Kayıt Yok !!!", "Info");
            }
        }


        private void siparisdetay(string siparisid)
        {
            con.Open();
            da = new OleDbDataAdapter("SELECT SiparisUrunId AS ÜRÜN_SİPARİŞ_NUMARASI,UrunId AS ÜRÜN,Miktar AS MİKTAR,Detay AS DETAY FROM SiparisUrun Where SiparisId='" + siparisid + "'", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView4.DataSource = tablo;
            con.Close();
        }


        private Double toplamtutar()
        {
            double toplam = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                toplam += Convert.ToDouble(row.Cells[2].Value);
            }
            return toplam;
        }

        private Double toplamtutarmusteri()
        {
            double toplam = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                toplam += Convert.ToDouble(row.Cells[6].Value);
            }
            return toplam;
        }



        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("HATA " + ex.Message, "Error");
            }
            finally
            {
                GC.Collect();
            }
        }


        private void btnguncel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Visible == true)
            {
                musteriler();
            }
            else if (dataGridView2.Rows.Count > 0 && dataGridView2.Visible == true)
            {
                siparisler();
            }
            else if (dataGridView3.Rows.Count > 0 && dataGridView3.Visible == true)
            {
                urunler();
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.musteriId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            musteri.ShowDialog();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Urun urun = new Urun();
            urun.urunId = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            urun.ShowDialog();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SiparisDetay frm = new SiparisDetay();
            frm.siparis = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
        }



    }

}
