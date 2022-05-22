using System;
using System.Collections.Generic;
using CommandPattern.Commands;
using CommandPattern.Commands.Surround;

namespace CommandPattern
{
    public class Parameters
    {
        public string Value { get; set; }

        public Parameters(string value)
        {
            Value = value;
        }
    }
    
    public class Program
    {
        private static List<Command> SimpleCommands()
        {
            return new List<Command>
            {
                new HelloCommand(),
                new HelloCommand(),
                new HelloCommand(),
                new HelloCommand(),
                new GoodByeCommand()
            };
        }

        private static List<Command> ComposedCommands(Parameters parameters)
        {
            return new List<Command>
            {
                new AddParenthesisCommand(parameters),
                new AddParenthesisCommand(parameters),
                new AddBracketsCommand(parameters),
                new AddBracketsCommand(parameters),
                new AddParenthesisCommand(parameters),
            };
        }

        private static List<Command> HtmlCommands(Parameters parameters)
        {
            return new List<Command>
            {
                new AddTittleCommand(parameters),
                new HeaderOneCommand(parameters),
            };
        }

        public static void Main(string[] args)
        {
            Parameters parameters = new Parameters("Hello World");

            Console.WriteLine($"Starting string -> \n{parameters.Value}");
            
            List<Command> commands = HtmlCommands(parameters);

            ActiveObjectEngine activeObjectEngine = new ActiveObjectEngine(commands);
            activeObjectEngine.Run();
            
            Console.WriteLine($"Runned string -> \n{parameters.Value}");
        }
    }
}