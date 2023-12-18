using System.Windows.Forms;

namespace Задача_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        zadacha2 zadacha2 = new zadacha2();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = int.Parse(textBox1.Text);
            dataGridView2.RowCount = int.Parse(textBox1.Text);
            dataGridView3.RowCount = int.Parse(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = int.Parse(textBox2.Text);
            dataGridView2.ColumnCount = int.Parse(textBox2.Text);
            dataGridView3.ColumnCount = int.Parse(textBox2.Text);
        }
        private void create_fill_matrix()
        {
            zadacha2.createarray(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    zadacha2.array1[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    zadacha2.array2[i, j] = Convert.ToInt32(dataGridView2[j, i].Value);
                }
        }

        private void fill_datagrid3()
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView3[j, i].Value = zadacha2.array3[i, j].ToString();
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            create_fill_matrix();
            zadacha2.array3 = zadacha2.add_up_the_matrices(zadacha2.array1, zadacha2.array2);
            fill_datagrid3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            create_fill_matrix();
            zadacha2.array3 = zadacha2.subtract_matrices(zadacha2.array1, zadacha2.array2);
            fill_datagrid3();

        }
    }
}