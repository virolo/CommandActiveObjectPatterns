namespace CommandPattern.Commands.Surround
{
    public class HeaderOneCommand : SurroundValuesCommand
    {
        public HeaderOneCommand(Parameters parameters) : base(parameters) { }
        protected override OpenCloseValues GetSurroundCharacter()
        {
            return new OpenCloseValues("<h1>\n", "\n</h1>");
        }
    }
}