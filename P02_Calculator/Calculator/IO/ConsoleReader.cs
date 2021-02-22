using System;
using SimpleCalculator.IO.Contracts;

namespace SimpleCalculator.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
