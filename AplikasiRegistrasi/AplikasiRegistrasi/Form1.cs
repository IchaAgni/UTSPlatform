namespace AplikasiRegistrasi
{
    public partial class Form1 : Form
    {
        readonly string Email = "nisaagni@yaho.com";
        readonly string Password = "ciciyahuu";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == Email && txtpassword.Text == Password)
            {
                MessageBox.Show("Selamat anda berhasil login");
            }
            else if (txtemail.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Anda belum memasukkan Email dan Password!");
            }
            else
            {
                MessageBox.Show("Maaf Email dan Fassword anda salah");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            txtpassword.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}