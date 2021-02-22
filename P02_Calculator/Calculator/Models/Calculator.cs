using SimpleCalculator.Models.Contracts;

namespace SimpleCalculator.Models
{
    public abstract class Calculator : ICalculator
    {
        protected double firstNumber;
        protected double secondNumber;

        protected Calculator(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public abstract double Calculate();
    }
}
