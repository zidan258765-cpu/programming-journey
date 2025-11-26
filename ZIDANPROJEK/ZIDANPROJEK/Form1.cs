using System.Windows.Forms;

namespace ZIDANPROJEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView2.Rows.Add("Semarang", "300.000");
            dataGridView2.Rows.Add("Tegal", "150.000");
            dataGridView2.Rows.Add("Malang", "300.000");
            dataGridView2.Rows.Add("Jakarta", "200.000");
            dataGridView2.Rows.Add("Bandung", "250.000");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text.ToString();
            string notelpon = textBox2.Text.ToString();
            string tanggal = comboBox6.Text.ToString();
            string jam = comboBox3.Text.ToString();
            string tujuan = comboBox4.Text.ToString();
            string jumlah = comboBox5.Text.ToString();
            int harga = int.Parse(comboBox5.Text) * int.Parse(cbharga.SelectedItem.ToString());
            string total = $"{Convert.ToInt32(harga) * Convert.ToInt32(jumlah)}";
            dataGridView1.Rows.Add(nama, notelpon, tanggal, jam, tujuan, jumlah, harga);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
