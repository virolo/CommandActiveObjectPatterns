namespace CommandPattern.Commands.Surround
{
    public class AddParenthesisCommand : SurroundValuesCommand
    {
        public AddParenthesisCommand(Parameters parameters) : base(parameters) { }
        protected override OpenCloseValues GetSurroundCharacter()
        {
            return new OpenCloseValues("(",")");
        }
    }
}