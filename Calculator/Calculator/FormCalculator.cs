using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private readonly Controller _controller;

        public FormCalculator()
        {
            InitializeComponent();
            _controller = new Controller(this);
        }

        public void UpdateTextBox(double value)
        {
            textBox.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public void UpdateTextBoxMemory(double value)
        {
            textBoxMemory.Text = value.ToString(CultureInfo.InvariantCulture);
        }

        public void UpdateOperatorImage(Image operatorImage)
        {
            pictureBoxOperator.Image = operatorImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            _controller.UpdateInput("0");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _controller.UpdateOperation(Operations.PLUS);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _controller.UpdateOperation(Operations.MINUS);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            _controller.UpdateOperation(Operations.MULTIPLY);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            _controller.UpdateOperation(Operations.DIVIDE);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _controller.Clear();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            _controller.Go();
        }
    }
}
