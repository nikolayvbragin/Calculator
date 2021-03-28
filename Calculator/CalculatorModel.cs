using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {

        }

        public object Calculate(int operand1, int operand2, char operation)
        {
            switch (operation)
            {
                case ('+'):
                    return Add(operand1, operand2);

                case ('-'):
                    return Subt(operand1, operand2);

                case ('*'):
                    return Mult(operand1, operand2);

                case ('/'):
                    return Div(operand1, operand2);
            }






            return null;
        }

        private int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        private int Subt(int op1, int op2)
        {
            return op1 - op2;
        }

        private int Mult(int op1, int op2)
        {
            return op1 * op2;
        }

        private double Div (int op1, int op2)
        {
            double op1Temp = Convert.ToDouble(op1);
            double op2Temp = Convert.ToDouble(op2);
            
            // Реализовал, но вызова исключения не добился,
            // видимо, обрабатывается где-то еще
            try
            {
                double output = op1Temp / op2Temp;
                return output;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException();
            }
        }

    }
}
