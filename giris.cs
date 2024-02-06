using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace ProjeOdev
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)

        {

            if (adTxt.Text == "yakup" && sifreTxt.Text == "yakup123")
            {
                Form2 git = new Form2();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre hatali!");
            }




        }

        private void btnGiris2_Click(object sender, EventArgs e)
        {
          if ((adTxt2.Text == "ayben" && sifreTxt2.Text == "ayben123") || (adTxt2.Text == "yunus" && sifreTxt2.Text == "yunus123"))
            {
                Form7 git = new Form7();
                git.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanici adi veya sifre hatali!");
            }

        }
    }
}