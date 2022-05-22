using System;

namespace CommandPattern.Commands
{
    public class HelloCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Hello World!");
        }
    }
}