namespace exerc_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "passou-me com o ponteiro do rato por cima";
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}