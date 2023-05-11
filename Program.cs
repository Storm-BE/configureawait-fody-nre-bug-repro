Console.WriteLine("Hello, World!");
string? someString = null;
await (someString == "anyValue" ? SomeMethodAsync() : SomeMethodAsync());
Console.WriteLine("Finished successfully!");

static Task SomeMethodAsync()
{
    return Task.CompletedTask;
}
