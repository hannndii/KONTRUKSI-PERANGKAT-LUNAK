namespace App_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = textBox1.Text;
            if(input == "")
            {
                MessageBox.Show("Harap Masukkan Nama Anda!");
            }
            else
            {
                label1.Text = "Halo, " + input;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
