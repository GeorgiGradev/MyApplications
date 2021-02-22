using SimpleCalculator.Core.Contracts;
using SimpleCalculator.IO;
using SimpleCalculator.IO.Contracts;
using SimpleCalculator.Models;
using SimpleCalculator.Models.Contracts;

namespace SimpleCalculator.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine()
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Run()
        {
            double firstNumber = ReadNumber("first");
            string @operator = GetOperator();
            double secondNumber = ReadNumber("second");

            CalculateAndPrintResult(firstNumber, @operator, secondNumber);
        }

        private void CalculateAndPrintResult(double firstNumber, string @operator, double secondNumber)
        {
            ICalculator calculator = null;
            switch (@operator)
            {
                case "+":
                    calculator = new Add(firstNumber, secondNumber);
                    break;
                case "-":
                    calculator = new Subtract(firstNumber, secondNumber);
                    break;
                case "*":
                    calculator = new Multiply(firstNumber, secondNumber);
                    break;
                case "/":
                    calculator = new Divide(firstNumber, secondNumber);
                    break;
            }

            writer.Write($"The result is: {calculator.Calculate():F2}");
        }

        private double ReadNumber(string count)
        {
            double number;
            while (true)
            {
                writer.Write($"Enter {count} number: ");
                if (double.TryParse(reader.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    writer.WriteLine("Invalid number please try again:");
                }

            }

            return number;
        }

        private string GetOperator()
        {
            while (true)
            {
                writer.Write("Enter operator: ");
                var @operator = reader.ReadLine();

                if (@operator == "+" || @operator == "-" || @operator == "*" || @operator == "/")
                {
                    return @operator;
                }
                else
                {
                    writer.WriteLine("Invalid operator please use one of following (+,-,*,/)");
                    writer.WriteLine("+ for Add");
                    writer.WriteLine("- for Subtract");
                    writer.WriteLine("* for Multiply");
                    writer.WriteLine("/ for Divide");
                }

            }
        }
    }
}
