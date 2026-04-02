Console.WriteLine(SayHello("Olli"));

static string SayHello(string name)
{
    var helloString = $"Hello {name}";
    return helloString;
}