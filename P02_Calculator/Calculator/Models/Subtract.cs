namespace SimpleCalculator.Models
{
    public class Subtract : Calculator
    {
        public Subtract(double firstNumber, double secondNumber)
            : base(firstNumber, secondNumber)
        {
        }

        public override double Calculate()
        {
            return this.firstNumber - this.secondNumber;
        }
    }
}
