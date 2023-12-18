namespace Задача_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        zadacha1 zadacha1 = new zadacha1();
        private void button1_Click(object sender, EventArgs e)
        {
            zadacha1.GenerateArray();
            richTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            foreach (int i in zadacha1.MyArray)
            {
                richTextBox1.Text += i.ToString() + ";";
            }
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zadacha1.setMyArrayfromTextBox(richTextBox1.Text);
            textBox1.Text = zadacha1.arithmetic_mean(zadacha1.MyArray).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            zadacha1.setMyArrayfromTextBox(richTextBox1.Text);
            textBox2.Text = zadacha1.geometric_mean(zadacha1.MyArray).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zadacha1.setMyArrayfromTextBox(richTextBox1.Text);
            textBox3.Text = zadacha1.quadratic_mean(zadacha1.MyArray).ToString();

        }
        
    }
}