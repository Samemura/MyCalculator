using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculator
{
    class CalculatorModel
    {
        public double result;
        private string preOperator;

        public CalculatorModel()
        {
            clearResult();
        }

        public void inputOperator(String inputOperator, double inputNum)
        {
            switch (preOperator)
            {
                case "+":
                    result += inputNum;
                    break;
                case "-":
                    result -= inputNum;
                    break;
                case "*":
                    result *= inputNum;
                    break;
                case "/":
                    result /= inputNum;
                    break;
                default:
                    result = inputNum;
                    break;
            }
            preOperator = inputOperator;
        }

        public void clearResult()
        {
            result = 0;
            preOperator = "";
        }

    }
}
