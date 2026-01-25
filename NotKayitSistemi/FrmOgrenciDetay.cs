using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara; // Student number passed from login form

        // Database connection for student detail system
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara; // Display student number in label
            string durum;

            conn.Open();
            // Query student details from database using student number
            SqlCommand cmd = new SqlCommand("Select * from TBL_DERS WHERE OGRNUMARA=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", lblNumara.Text); // Use student number as parameter
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // Display student full name (concatenate first and last name)
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString(); // Index 2: First name, Index 3: Last name

                // Display exam scores
                lblSınav1.Text = dr[4].ToString(); // Exam 1 score (index 4)
                lblSınav2.Text = dr[5].ToString(); // Exam 2 score (index 5)
                lblSınav3.Text = dr[6].ToString(); // Exam 3 score (index 6)

                // Display calculated average
                lblOrtalama.Text = dr[7].ToString(); // Average score (index 7)

                // Determine and display pass/fail status
                if (dr[8].ToString() == "True") // Index 8: Status (True = Pass, False = Fail)
                {
                    lblDurum.Text = "Geçti"; // "Passed"
                }
                else
                {
                    lblDurum.Text = "Kaldı"; // "Failed"
                }
            }
            conn.Close();
        }
    }
}