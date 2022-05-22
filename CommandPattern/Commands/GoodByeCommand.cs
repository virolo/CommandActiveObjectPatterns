using System;

namespace CommandPattern.Commands
{
    public class GoodByeCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Good Bye!");
        }
    }
}