using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        // Database connection for student grading system
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");

        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Label click event handler
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // GroupBox enter event handler
        }

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            conn.Open();
            // Count number of passed students (DURUM=1 means passed)
            SqlCommand cmd = new SqlCommand("Select count(*) from TBL_DERS WHERE DURUM=1", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblPassedNumber.Text = dr[0].ToString(); // Display passed student count
            }
            conn.Close();

            // Load data from TBL_DERS table to DataGridView
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView cell content click event handler
        }

        // Update student grades button click
        private void btnGradeUpdate_Click(object sender, EventArgs e)
        {
            double avarage, s1, s2, s3;
            string durum;

            // Convert exam scores to double
            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            // Calculate average of three exams
            avarage = (s1 + s2 + s3) / 3;
            lblAvarage.Text = avarage.ToString("0.00"); // Display average with 2 decimal places

            // Determine pass/fail status based on average
            if (avarage >= 50)
            {
                durum = "True"; // Passed
            }
            else
            {
                durum = "False"; // Failed
            }

            // Update student grades in database
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBL_DERS SET OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4,DURUM=@p6 WHERE OGRNUMARA=@p5", conn);
            cmd.Parameters.AddWithValue("@p1", txtSinav1.Text); // Exam 1 score
            cmd.Parameters.AddWithValue("@p2", txtSinav2.Text); // Exam 2 score
            cmd.Parameters.AddWithValue("@p3", txtSinav3.Text); // Exam 3 score
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(lblAvarage.Text)); // Average
            cmd.Parameters.AddWithValue("@p5", mskTextBoxNumara.Text); // Student number
            cmd.Parameters.AddWithValue("@p6", durum); // Pass/fail status
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi"); // "Student grades updated"

            // Update passed and failed student counts
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select count(*) from TBL_DERS WHERE DURUM=1", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                lblPassedNumber.Text = dr[0].ToString(); // Update passed count
            }
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("Select count(*) from TBL_DERS WHERE DURUM=0", conn);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            while (dr1.Read())
            {
                lblLeftNumber.Text = dr1[0].ToString(); // Update failed count
            }
            dr1.Close();
            conn.Close();

            // Refresh DataGridView with updated data
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
        }

        // Save new student button click
        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            // Insert new student record
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_DERS(OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", conn);
            cmd.Parameters.AddWithValue("@p1", mskTextBoxNumara.Text); // Student number
            cmd.Parameters.AddWithValue("@p2", txtAd.Text); // Student first name
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text); // Student last name
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Öğrenci Sisteme Eklendi"); // "Student added to system"

            // Refresh DataGridView with new student
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
        }

        // DataGridView cell click event (loads selected student data into form fields)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex; // Get selected row index

            // Load data from selected row into form controls
            mskTextBoxNumara.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString(); // Student number
            txtAd.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString(); // First name
            txtSoyad.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString(); // Last name
            txtSinav1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString(); // Exam 1 score
            txtSinav2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString(); // Exam 2 score
            txtSinav3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString(); // Exam 3 score
        }
    }
}