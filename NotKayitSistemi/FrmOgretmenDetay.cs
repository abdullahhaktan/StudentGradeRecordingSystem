using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotKayitSistemi
{
    public partial class FrmOgretmenDetay: Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");

        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from TBL_DERS WHERE DURUM=1",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblPassedNumber.Text = dr[0].ToString();
            }
            conn.Close();
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBL_DERS' table. You can move, or remove it, as needed.
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGradeUpdate_Click(object sender, EventArgs e)
        {
            double avarage, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            avarage = (s1 + s2 + s3) / 3;
            lblAvarage.Text = avarage.ToString("0.00");

            if(avarage >=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBL_DERS SET OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4,DURUM=@p6 WHERE OGRNUMARA=@p5", conn);
            cmd.Parameters.AddWithValue("@p1", txtSinav1.Text);
            cmd.Parameters.AddWithValue("@p2", txtSinav2.Text);
            cmd.Parameters.AddWithValue("@p3", txtSinav3.Text);
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(lblAvarage.Text));
            cmd.Parameters.AddWithValue("@p5", mskTextBoxNumara.Text);
            cmd.Parameters.AddWithValue("@p6", durum);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select count(*) from TBL_DERS WHERE DURUM=1", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                lblPassedNumber.Text = dr[0].ToString();
            }
            dr.Close();
            SqlCommand cmd2 = new SqlCommand("Select count(*) from TBL_DERS WHERE DURUM=0", conn);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            while (dr1.Read())
            {
                lblLeftNumber.Text = dr1[0].ToString();
            }
            dr1.Close();
            conn.Close();
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_DERS(OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)",conn);
            cmd.Parameters.AddWithValue("@p1", mskTextBoxNumara.Text);
            cmd.Parameters.AddWithValue("@p2", txtAd.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            mskTextBoxNumara.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

        }
    }
}
