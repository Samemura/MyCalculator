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
                // 入力値を取得し、計算する
                float input;
                checked
                {
                    input = float.Parse(ResultTextBox.Text);
                }
                if (HistoryTextBox.Text.Contains("="))
                    HistoryTextBox.Text = "";

                string operatorText = ((Button)sender).Text;
                HistoryTextBox.Text += ResultTextBox.Text + " " + operatorText + " ";
                int error = calcModel.inputOperator(operatorText, input);

                // 結果をチェックし、表示を更新する
                if (error != 0)
                    throw new InvalidOperationException(error.ToString());

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
                switch (ex.Message)
                {
                    case "-1":
                        showErrorMessage("計算結果が計算できる範囲を超えました。");
                        break;
                    case "-2":
                        showErrorMessage("計算できない数値が入力されました。例：０による割り算");
                        break;
                    default:
                        break;
                }
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
            HistoryTextBox.Text = "";
        }
    }
}
