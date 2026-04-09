// Top Level statments
// - All executable statements must come first.
// - All type declarations (classes, enums, structs, records) must come last.
// - No mixing. No statements after types.


static string SayHello(string name)
{
    var helloString = $"Hello {name}";
    return helloString;
}

static int SumInt(params int[] args)
{
    int result = 0;
    foreach (var arg in args)
    {
        result += arg;
    }
    return result;
}

var enumList = Enum.GetValues<Color>();
var castedEnumList = Enum.GetValues<Color>().Cast<Color>();
var selectedEnumList = Enum.GetValues<Color>().Select(c => new
{
    id = (int)c,
    colorName = c.ToString()
});

Console.WriteLine(SayHello("Olli"));
Console.WriteLine(SumInt([3, 6, 91]));

public enum Color
{
    Red,
    Green,
    Blue
};