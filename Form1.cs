using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aspose.Pdf;
using Microsoft.VisualBasic;
using Image = System.Drawing.Image;

namespace Tooded_TARpv22
{
    public partial class Form1 : Form
    {

        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|bin\Debug\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlConnection connect = new SqlConnection(@"Data Source=HP-CZC2349HSZ;Initial Catalog=Tooded_DB;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaKategooriad();
        }

        public void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id,Kategooria_nimetus FROM Kategooriatabel", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                if (!Kat_Box.Items.Contains(item["Kategooria_nimetus"]))
                {
                    Kat_Box.Items.Add(item["Kategooria_nimetus"]);
                }
                else
                {
                    command=new SqlCommand("DELETE FROM Kategooriatabel WHERE Id=@id",connect);
                    command.Parameters.AddWithValue("@id", item["Id"]);
                    command.ExecuteNonQuery();
                }
                
            }
            connect.Close();
        }

        private void Lisa_Kat_btn_Click(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in Kat_Box.Items)
            {
                if (item.ToString()==Kat_Box.Text)
                {
                    on = true;
                }
            }
            if (on==false)
            {
                command = new SqlCommand("INSERT INTO Kategooriatabel (Kategooria_nimetus) VALUES (@kat)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@kat", Kat_Box.Text);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
            else
            {
                MessageBox.Show("Selline kategooriat on juba olemas!");
            }
            
        }
        int Id = 0;
        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim()!=string.Empty && Kogus_txt.Text.Trim()!=string.Empty && Hind_txt.Text.Trim()!=string.Empty && Kat_Box.SelectedItem!=null)
            {
                try
                {
                    connect.Open();
                    
                    command =new SqlCommand("SELECT Id FROM Kategooriatabel WHERE Kategooria_nimetus=@kat", connect);
                    command.Parameters.AddWithValue("@kat", Kat_Box.Text);
                    command.ExecuteNonQuery();
                    Id = Convert.ToInt32(command.ExecuteScalar());
                    
                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus,Kogus,Hind,Pilt,KategooriadID) VALUES (@toode,@kogus,@hind,@pilt,@kat)",connect);                   
                    command.Parameters.AddWithValue("@toode",Toode_txt.Text);
                    command.Parameters.AddWithValue("@kogus",Kogus_txt.Text);
                    command.Parameters.AddWithValue("@hind",Hind_txt.Text);
                    command.Parameters.AddWithValue("@pilt",Toode_txt.Text + extension);//jpg-png
                    command.Parameters.AddWithValue("@kat",Id);//Id?
                    command.ExecuteNonQuery();
                    
                    connect.Close();

                    NaitaAndmed();
                }
                catch (Exception)
                {

                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }        
        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            if (Kat_Box.SelectedItem!=null)
            {
                connect.Open();
                string kat_val = Kat_Box.SelectedItem.ToString();
                command = new SqlCommand("DELETE FROM Kategooriatabel WHERE Kategooria_nimetus=@kat ", connect);
                command.Parameters.AddWithValue("@kat", kat_val);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
        }
        string kat;
        SaveFileDialog save;
        OpenFileDialog open;
        string extension=null;
        private void otsi_fail_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\marina.oleinik\Pictures";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            FileInfo open_info = new FileInfo(@"C:\Users\marina.oleinik\Pictures\"+open.FileName);
            if (open.ShowDialog()==DialogResult.OK && Toode_txt.Text!=null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                extension = Path.GetExtension(open.FileName);
                save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName);//extension
                save.Filter="Images"+Path.GetExtension(open.FileName)+"|"+Path.GetExtension(open.FileName);
                if (save.ShowDialog()==DialogResult.OK && Toode_txt.Text != null)
                {
                    
                    File.Copy(open.FileName, save.FileName);//??
                    Toode_pb.Image=Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või oli vajutatud Cancel");
            }
        }

       
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Toode_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Toodenimetus"].Value.ToString();
            Kogus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Kogus"].Value.ToString();
            Hind_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Hind"].Value.ToString();
            try
            {
                Toode_pb.Image= Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Images"), dataGridView1.Rows[e.RowIndex].Cells["Pilt"].Value.ToString()));
            }
            catch (Exception)
            {

                Toode_pb.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Images"), "epood.png"));
                Toode_pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
            Kat_Box.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value;//?
        }

        private void Uuenda_btn_Click(object sender, EventArgs e)
        {
            

            if (Toode_txt.Text != "" && Kogus_txt.Text != "" && Hind_txt.Text != "" && Toode_pb.Image != null)
            {
                command = new SqlCommand("UPDATE Toodetabel  SET Toodenimetus=@toode,Kogus=@kogus,Hind=@hind, Pilt=@pilt WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                command.Parameters.AddWithValue("@hind", Hind_txt.Text.Replace(",", "."));
                
                    string pilt = dataGridView1.SelectedRows[0].Cells["Pilt"].Value.ToString();
                    string file_pilt = Toode_txt.Text + extension;//kontroll
                
                
                command.Parameters.AddWithValue("@pilt", file_pilt);
                command.ExecuteNonQuery();
                connect.Close();
                NaitaAndmed();
                
                MessageBox.Show("Andmed uuendatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void Kust_btn_Click(object sender, DataGridViewCellMouseEventArgs e) //Kustuta toode
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show(Id.ToString());
            if (Id != 0)
            {
                command = new SqlCommand("DELETE Toodetabel WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connect.Close();

                NaitaAndmed();

                MessageBox.Show("Andmed tabelist Tooded on kustutatud");
            }
            else
            {
                MessageBox.Show("Viga Tooded tabelist andmete kustutamisega");
            }
        }
        private void Kust_btn_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            MessageBox.Show(Id.ToString());
            if (Id != 0)
            {
                command = new SqlCommand("DELETE Toodetabel WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connect.Close();

                NaitaAndmed();

                MessageBox.Show("Andmed tabelist Tooded on kustutatud");
            }
            else
            {
                MessageBox.Show("Viga Tooded tabelist andmete kustutamisega");
            }
        }

        private void eemalda_btn_Click(object sender, EventArgs e)
        {
            Toode_txt.Text = "";
            Kogus_txt.Text = "";
            Hind_txt.Text = "";
            Toode_pb.Image = null;
        }

        Document document;
        private void Ostan_btn_Click(object sender, EventArgs e)//arve koostamine
        {
            document = new Document();//using Aspose.Pdf
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode  Hind  Kogus Summa"));
            foreach (var toode in Tooded_list)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));//
            }
            document.Save(@"..\..\Arved\Arve_.pdf");
            document.Dispose();
        }
        List<string> Tooded_list = new List<string>();//tooded listisse
        private void Valik_btn_Click(object sender, EventArgs e)
        {
            Tooded_list.Add("-----------------------");
            Tooded_list.Add((Toode_txt.Text + "  " + Hind_txt.Text + "  " + Kogus_txt.Text + "  " + (Convert.ToInt32(Kogus_txt.Text.ToString()) * Convert.ToInt32(Hind_txt.Text.ToString()))).ToString());
        }

        private void SaadaArve_btn_Click(object sender, EventArgs e)
        {
            string adress = Interaction.InputBox("Sisesta e-mail", "Kuhu saada", "marina.oleinik@tthk.ee");
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    //string password = Interaction.InputBox("Sisesta salasõna");
                    Credentials = new System.Net.NetworkCredential("mvc.programmeerimine@gmail.com", "3.Kuursus"),
                    EnableSsl = true
                };
                mail.From = new MailAddress("mvc.programmeerimine@gmail.com");
                mail.To.Add(adress);
                mail.Subject = "Pilet";
                mail.Body = "Pilet on ostetud ja ta on maanuses";//"Rida: ",rida.ToString()," Koht: ",koht.ToString();

                foreach (var item in arr_pilet)
                {
                    mail.Attachments.Add(new Attachment(item));
                }
                smtpClient.Send(mail);
                MessageBox.Show("Pilet oli saadetud mailile: " + adress);
            }
            catch (Exception)
            {
                MessageBox.Show("Viga");
            }
        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toodetabel.Id,Toodetabel.Toodenimetus,Toodetabel.Kogus,Toodetabel.Hind,Toodetabel.Pilt, Kategooriatabel.Kategooria_nimetus as Kategooria_nimetus  FROM Toodetabel INNER JOIN Kategooriatabel on Toodetabel.KategooriadID=Kategooriatabel.Id ", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;
            DataGridViewComboBoxColumn combo_kat= new DataGridViewComboBoxColumn();
            combo_kat.DataPropertyName = "Kategooria_nimetus";
            HashSet<string> keys = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string kat_n = item["Kategooria_nimetus"].ToString();
                if (!keys.Contains(kat_n))
                {
                    keys.Add(kat_n);
                    combo_kat.Items.Add(kat_n);
                }               
            }
            dataGridView1.Columns.Add(combo_kat);
            Toode_pb.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Images"), "epood.png"));
            Toode_pb.SizeMode = PictureBoxSizeMode.Zoom;
            connect.Close();
        }
    }
}
