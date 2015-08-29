using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorModel calcModel;
        private string inputNumText;

        public CalculatorForm()
        {
            InitializeComponent();
            calcModel = new CalculatorModel();
            inputNumText = "";
            ResultTextBox.Text = "0";
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (inputNumText == "0")
                inputNumText = "";
            inputNumText += ((Button)sender).Text;
            ResultTextBox.Text = inputNumText;
        }

        private void OpeButton_Click(object sender, EventArgs e)
        {
            string input = ((Button)sender).Text;
            calcModel.inputOperator(input, double.Parse(ResultTextBox.Text));
            inputNumText = "";
            ResultTextBox.Text = calcModel.result.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            calcModel.clearResult();
            inputNumText = "";
            ResultTextBox.Text = "0";
        }
    }
}
