namespace Pion.Core;

public static class Extensions
{
    public static string Indent(this string self)
    {
        return string.Join("\n", self
            .Split("\n")
            .Select((line, i) => i != 0
                ? "    " + line
                : line));
    }
}
