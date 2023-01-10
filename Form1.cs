namespace Individual_Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = GetFactorial(numericUpDown1.Value).ToString();
        }

        private long GetFactorial(decimal value)
        {
            long result = 1;
            for (int i = 1; i < value; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}