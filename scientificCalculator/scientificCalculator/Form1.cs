using Microsoft.Win32;
using System.CodeDom;

namespace scientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonCONSTE.Visible = false;
            buttonCONSTC.Visible = false;
            buttonCONSTEC.Visible = false;
            buttonCONSTH.Visible = false;   
            buttonCONSTPI.Visible = false;
        }
        double firstDgt;
        string Operator;
        bool isOperator = false;
        double result;
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0"|| isOperator)
                textBoxOutput.Clear();
            isOperator = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxOutput.Text.Contains("."))
                {
                    textBoxOutput.Text += button.Text;
                }
            }
            else
            {
                textBoxOutput.Text += button.Text;
            }

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            int index = textBoxOutput.Text.Length;
            index--;
            if (index > 0)
            {
                textBoxOutput.Text = textBoxOutput.Text.Remove(index);
            }
            else if (index <= 0)
            {
                textBoxOutput.Text = "";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            firstDgt = double.Parse(textBoxOutput.Text);
            Button optr = (Button)sender;
            Operator = optr.Text;
            isOperator = true;
        }

        private void buttonEQ_Click(object sender, EventArgs e)
        {
            switch (Operator)
            {
                case "+":
                    textBoxOutput.Text = (firstDgt + double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "-":
                    textBoxOutput.Text = (firstDgt - double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "÷":
                    textBoxOutput.Text = (firstDgt / double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "X":
                    textBoxOutput.Text = (firstDgt * double.Parse(textBoxOutput.Text)).ToString();
                    break;
                case "^":
                    textBoxOutput.Text = (Math.Pow(firstDgt, double.Parse(textBoxOutput.Text))).ToString();
                    break;
            }
        }

        private void buttonLOG_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Log10(result);
            textBoxOutput.Text = result.ToString(); 
        }
        private void buttonLN_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Log(result);
            textBoxOutput.Text = result.ToString();
        }
        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Sqrt(result);
            textBoxOutput.Text = result.ToString();
        }
        private void buttonSQRT_Click_1(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Sqrt(result);
            textBoxOutput.Text = result.ToString();
        }

        private void buttonSIN_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Sin(result);
            textBoxOutput.Text = result.ToString();
        }

        private void buttonCOS_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Cos(result);
            textBoxOutput.Text = result.ToString();
        }

        private void buttonTAN_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Tan(result);
            textBoxOutput.Text = result.ToString();
        }

        private void buttonARCSIN_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Sinh(result);
            textBoxOutput.Text = result.ToString();
        }

        private void buttonARCCOS_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Cosh(result);
            textBoxOutput.Text = result.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBoxOutput.Text);
            result = Math.Tanh(result);
            textBoxOutput.Text = result.ToString();
        }
        private void buttonPOW_Click(object sender, EventArgs e)
        {

        }


        private void buttonCONST_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = 
            textBoxOutput.Text += button.Text;

        }

        private void buttonVIS_Click(object sender, EventArgs e)
        {
            buttonVIS.Visible = false;
            buttonCONSTE.Visible = true;
            buttonCONSTC.Visible = true;
            buttonCONSTEC.Visible = true;
            buttonCONSTH.Visible = true;
            buttonCONSTPI.Visible = true;
        }


    }
}