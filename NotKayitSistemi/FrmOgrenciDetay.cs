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

namespace NotKayitSistemi
{
    public partial class FrmOgrenciDetay: Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");


        //Data Source=ABDULLAH;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            string durum;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBL_DERS WHERE OGRNUMARA=@p1",conn);
            cmd.Parameters.AddWithValue("@p1",lblNumara.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSınav1.Text = dr[4].ToString();
                lblSınav2.Text = dr[5].ToString();
                lblSınav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                if (dr[8].ToString()=="True")
                {
                    lblDurum.Text = "Geçti";
                }
                else
                {
                    lblDurum.Text = "Kaldı";
                }
            }
            conn.Close();
        }
    }
}
