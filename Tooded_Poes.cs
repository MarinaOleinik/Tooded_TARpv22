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
using System.Xml.Linq;

namespace Tooded_TARpv22
{
    public partial class Tooded_Poes : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marina.oleinik\source\repos\DB_TARpv21\DB_TARpv21\AppData\Tooded_DB.mdf;Integrated Security=True");
        //
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat, failinimi_adap;
        TabControl kategooriad;
        PictureBox pictureBox;
        public Tooded_Poes()
        {
            this.Size = new System.Drawing.Size(600, 300);
            Kategooriad();
        }
        int kat_Id;
        List<string> fail_list;
        public List<string> Failid_KatId(int kat_Id) //Failide loetelu igas kategoorijas 
        {
            fail_list = new List<string>();
            failinimi_adap = new SqlDataAdapter("SELECT Pilt FROM Toodetable WHERE Kategooria_Id=" + kat_Id, connect);
            DataTable failid = new DataTable();
            failinimi_adap.Fill(failid);
            foreach (DataRow fail in failid.Rows)
            {
                fail_list.Add(fail["Pilt"].ToString()); //liisame pildi nimetus listisse
            }
            return fail_list;
        }
        public void Kategooriad()
        {
            kategooriad = new TabControl(); //loome kaardid
            kategooriad.Name = "Kategooriad";
            kategooriad.Dock = DockStyle.Left;
            kategooriad.Width = this.Width; //kaartide suurus võrdus vormi suurusega
            kategooriad.Height = this.Height;

            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);

            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            ImageList iconsList = new ImageList();//
            iconsList.ColorDepth = ColorDepth.Depth32Bit;//
            iconsList.ImageSize = new Size(25, 25);//

            int i = 0;//
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                kategooriad.TabPages.Add((string)nimetus["Kategooria_nimetus"]);
                iconsList.Images.Add(Image.FromFile(@"..\..\Kat_pildid\" + (string)nimetus["Kategooria_nimetus"] + ".jpg"));//
                kategooriad.TabPages[i].ImageIndex = i;//
                i++;//
                kat_Id = (int)nimetus["Id"]; //Kategooria Id mis kaart loodakse
                fail_list = Failid_KatId(kat_Id);//Failide loetelu
                int r = 0;
                int c = 0;
                foreach (var fail in fail_list)
                {
                    //MessageBox.Show(fail);
                    pictureBox = new PictureBox(); //loob pildi kast
                    pictureBox.Image = Image.FromFile(@"..\..\Images\" + fail);
                    pictureBox.Width = pictureBox.Height = 100; //kasti suurus
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Location = new Point(c, r); //kasti asukoht
                    c = c + 100 + 2; //järgmise kasti positsion(liigume paremale)
                    kategooriad.TabPages[i - 1].Controls.Add(pictureBox); //lisame pilt kaardile

                }
            }
            kategooriad.ImageList = iconsList;//
            connect.Close();
            this.Controls.Add(kategooriad);
        }


        //List<string> Tooded_list = new List<string>();
        //private void Arve_btn_Click(object sender, EventArgs e)
        //{
        //    Tooded_list.Add("-----------------------");
        //    Tooded_list.Add((Toode_txt.Text + "  " + Hind_txt.Text + "  " + Kogus_txt.Text + "  " + (Convert.ToInt32(Kogus_txt.Text.ToString()) * Convert.ToInt32(Hind_txt.Text.ToString()))).ToString());

        //}
        //Document document;
        //private void Ost_btn_Click(object sender, EventArgs e)
        //{
        //    document = new Document();//using Aspose.Pdf
        //    var page = document.Pages.Add();
        //    page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode  Hind  Kogus Summa"));
        //    foreach (var toode in Tooded_list)
        //    {
        //        page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));
        //    }
        //    document.Save(@"..\..\Arved\Arve_.pdf");
        //    document.Dispose();
        //}

        //public void N_Arve_btn_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start(@"..\..\Arved\Arve_.pdf");
        //}
        //List<string> Tooded_list = new List<string>();
        //private void Arve_btn_Click(object sender, EventArgs e)
        //{
        //    Tooded_list.Add("-----------------------");
        //    Tooded_list.Add((Toode_txt.Text + "  " + Hind_txt.Text + "  " + Kogus_txt.Text + "  " + (Convert.ToInt32(Kogus_txt.Text.ToString()) * Convert.ToInt32(Hind_txt.Text.ToString()))).ToString());

        //}
        //Document document;
        //private void Ost_btn_Click(object sender, EventArgs e)
        //{
        //    document = new Document();//using Aspose.Pdf
        //    var page = document.Pages.Add();
        //    page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode  Hind  Kogus Summa"));
        //    foreach (var toode in Tooded_list)
        //    {
        //        page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));
        //    }
        //    document.Save(@"..\..\Arved\Arve_.pdf");
        //    document.Dispose();
        //}

        //public void N_Arve_btn_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start(@"..\..\Arved\Arve_.pdf");
        //}
    }
}
