namespace Pion.Core;

public static class Extensions
{
    public static string Indent(this string self)
    {
        return string.Join(Environment.NewLine, self
            .Split(Environment.NewLine)
            .Select((line, i) => i != 0
                ? "    " + line
                : line));
    }
}
