namespace SimpleCalculator.Models
{
    public class Multiply : Calculator
    {
        public Multiply(double firstNumber, double secondNumber)
            : base(firstNumber, secondNumber)
        {
        }

        public override double Calculate()
        {
            return this.firstNumber * this.secondNumber;
        }
    }
}
