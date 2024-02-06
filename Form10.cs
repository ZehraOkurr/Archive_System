using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeOdev
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.Controls.Add(dataGridView1);
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-13;User=NYP23-13;Password=Uludag9512357.;");
        private BindingSource bindingSource1 = new BindingSource();
        private DataTable GetData(string sqlCommand)
        {


            MySqlCommand command = new MySqlCommand(sqlCommand, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            return table;



        }

        void TabloyuDoldur()
        {
            DataTable dt = new DataTable();
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Emanet_islemleri", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Emanet_islemleri WHERE Evrak_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            TabloyuDoldur();
            MessageBox.Show("Emanet evrak başarıyla geri alındı.");
        }


        private void Form10_Load(object sender, EventArgs e)
        {
            TabloyuDoldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form4gecis = new Form2();
            form4gecis.ShowDialog();
            this.Hide();
        }
    }
}
