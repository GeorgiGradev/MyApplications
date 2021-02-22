using SimpleCalculator.IO.Contracts;
using System;

namespace SimpleCalculator.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string line)
        {
            Console.Write(line);
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }
}
