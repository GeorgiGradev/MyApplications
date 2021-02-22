namespace SimpleCalculator.IO.Contracts
{
    public interface IWriter
    {
        public void Write(string line);
        public void WriteLine();
        public void WriteLine(string line);
    }
}
