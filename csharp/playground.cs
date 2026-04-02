
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


Console.WriteLine(SayHello("Olli"));
Console.WriteLine(SumInt([3, 6, 91]));
