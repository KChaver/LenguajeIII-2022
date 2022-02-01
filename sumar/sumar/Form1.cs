namespace sumar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumarButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numero1textBox.Text);
            int num2 = Convert.ToInt32(Numero2textBox.Text);

            sumar(num1,num2);

            ResultadotextBox.Text = sumar(num1, num2).ToString();

        }

        private int sumar (int num1, int num2)
        {
            return num1 + num2;
        }

        private void MostrarMJS()
        {
            MessageBox.Show("Este es un MJS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMJS();
        }
    }
}