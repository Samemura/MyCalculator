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
            try
            {
                float input;
                checked
                {
                    input = float.Parse(ResultTextBox.Text);
                }
                int error = calcModel.inputOperator(((Button)sender).Text, input);
                if (error == -1)
                    throw new InvalidOperationException("計算結果が計算できる範囲を超えました。");
                else if (error == -2)
                    throw new InvalidOperationException("計算できない数値が入力されました。例：０による割り算");

                inputNumText = "";
                ResultTextBox.Text = calcModel.result.ToString();
            }
            catch (OverflowException)
            {
                showErrorMessage("入力された数値が計算できる範囲を超えました。");
                initCalcStatus();
            }
            catch (InvalidOperationException ex)
            {
                showErrorMessage(ex.Message);
                initCalcStatus();
            }

        }

        private static void showErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage,
                            "エラー !",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            initCalcStatus();
        }

        private void initCalcStatus()
        {
            calcModel.clearResult();
            inputNumText = "";
            ResultTextBox.Text = "0";
        }
    }
}
