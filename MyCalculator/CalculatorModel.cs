using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculator
{
    class CalculatorModel
    {
        public float result;
        private string preOperator;

        public CalculatorModel()
        {
            clearResult();
        }

        public int inputOperator(String inputOperator, float inputNum)
        {
            int ret = 0;

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

            if (float.IsInfinity(result))
            {
                ret = -1;
            }
            else if (float.IsNaN(result))
            {
                ret = -2;
            }
            return ret;
        }

        public void clearResult()
        {
            result = 0;
            preOperator = "";
        }

    }
}
