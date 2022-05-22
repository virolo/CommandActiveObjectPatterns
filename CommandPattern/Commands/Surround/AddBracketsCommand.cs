namespace CommandPattern.Commands.Surround
{
    public class AddBracketsCommand : SurroundValuesCommand
    {
        public AddBracketsCommand(Parameters parameters) : base(parameters) { }
        protected override OpenCloseValues GetSurroundCharacter()
        {
            return new OpenCloseValues("{", "}");
        }
    }
}