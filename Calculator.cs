namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double addResult = a + b;
            Console.WriteLine("Add result: {0} + {1} = {2}", a, b, addResult);
            return addResult;
          
        }

        public double Subtract(double a, double b)
        {
            double subtractResult = a - b;
            Console.WriteLine("Subtract result: {0} - {1} = {2}", a, b, subtractResult);
            return subtractResult;

        }

        public double Multiply(double a, double b)
        {
            double multiplyResult = a * b;
            Console.WriteLine("Multiply result: {0} * {1} = {2}", a, b, multiplyResult);
            return multiplyResult;
        }

        public double Divide(double a, double b)
        {
            if (a == 0)
            {
                DivideByZeroEx ex = new DivideByZeroEx("Can't divide by zero");
                throw ex;
            }

            double divideResult = a / b;
            Console.WriteLine("Divide result: {0} / {1} = {2}", a, b, divideResult);
            return divideResult;

        }
    }
}
