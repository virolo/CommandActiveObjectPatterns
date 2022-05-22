namespace CommandPattern.Commands.Surround
{
    public class OpenCloseValues
    {
        public string Left { get; }
        public string Right { get; }

        public OpenCloseValues(string left, string right)
        {
            Left = left;
            Right = right;
        }
    }
}