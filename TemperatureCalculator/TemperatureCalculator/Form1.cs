namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // input
            //textBoxC.Text = "Hello";
            string input = textBoxC.Text;
            // convert to f
            // f = c x 9/5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            // show input to textbox
            textBoxF.Text = f.ToString();
        }
    }
}