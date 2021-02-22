using SimpleCalculator.Core;
using SimpleCalculator.Core.Contracts;

namespace SimpleCalculator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
