namespace FrmCalculator
{

    public partial class Form1 : Form
    {
        CalculatorClass cal = new CalculatorClass();
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxInput1.Text, out num1) && double.TryParse(txtBoxInput2.Text, out num2))
            {
                double result = 0;

                switch (cbOperator.Text)
                {
                    case "+":

                       result = cal.GetSum(num1, num2);
                        lblDisplayTotal.Text = result.ToString();

                        break;
                    case "-":
                        result = cal.GetDifference(num1, num2);
                        lblDisplayTotal.Text = result.ToString();
                        break;
                    case "*":
                        result = cal.GetProduct(num1, num2);
                        lblDisplayTotal.Text = result.ToString();
                        break;
                    case "/":
                        result = cal.GetQuotient(num1, num2);
                        lblDisplayTotal.Text = result.ToString();
                        break;
                    default:
                        lblDisplayTotal.Text = "Select an Operator";
                        break;
                }
            }
            else
            {
                lblDisplayTotal.Text = "Invalid";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class CalculatorClass
    {

        public delegate T Formula<T>(T arg1);


        public Formula<double> CalculateEvent;


        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }
        public double GetQuotient(double num1, double num2)
        {
            if (num2 == 0)
            {
                return 0;

            }
            else { return num1 / num2; }
        }
    }
}
