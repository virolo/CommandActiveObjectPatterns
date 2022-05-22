using System.Collections.Generic;
using CommandPattern.Commands;

namespace CommandPattern
{
    public class ActiveObjectEngine
    {
        private List<Command> _commands;

        public ActiveObjectEngine(List<Command> commands)
        {
            _commands = commands;
        }

        public void Run()
        {
            foreach (Command command in _commands)
            {
                command.Execute();
            }
        }
    }
}