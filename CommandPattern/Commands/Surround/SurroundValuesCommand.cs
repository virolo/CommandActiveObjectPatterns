namespace CommandPattern.Commands.Surround
{
    public abstract class SurroundValuesCommand: Command
    {
        private Parameters _parameters;

        protected SurroundValuesCommand(Parameters parameters)
        {
            _parameters = parameters;
        }

        protected abstract OpenCloseValues GetSurroundCharacter();
        
        public void Execute()
        {
            OpenCloseValues surroundValues = GetSurroundCharacter();
            _parameters.Value = $"{surroundValues.Left}{_parameters.Value}{surroundValues.Right}";
        }
    }
}