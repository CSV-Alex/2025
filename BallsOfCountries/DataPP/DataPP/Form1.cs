namespace DataPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Pelotas Paises - 456 D.C";
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value + 10 <= progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            else
            {
                progressBar1.Value = progressBar1.Maximum;
            }

        }
    }
}
