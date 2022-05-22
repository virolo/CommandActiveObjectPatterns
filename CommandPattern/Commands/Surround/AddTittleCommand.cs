namespace CommandPattern.Commands.Surround
{
    public class AddTittleCommand : SurroundValuesCommand
    {
        public AddTittleCommand(Parameters parameters) : base(parameters) { }
        protected override OpenCloseValues GetSurroundCharacter()
        {
            return new OpenCloseValues("<title>", "</tittle>");
        }
    }
}