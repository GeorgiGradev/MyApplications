namespace SimpleCalculator.Models
{
    public class Add : Calculator
    {
        public Add(double firstNumber, double secondNumber)
            : base(firstNumber, secondNumber)
        {

        }
        public override double Calculate()
        {
            return this.firstNumber + this.secondNumber;
        }
    }
}
