namespace SimpleCalculator.Models
{
    public class Divide : Calculator
    {
        public Divide(double firstNumber, double secondNumber)
            : base(firstNumber, secondNumber)
        {
        }

        public override double Calculate()
        {
            return this.firstNumber / this.secondNumber;
        }
    }
}
