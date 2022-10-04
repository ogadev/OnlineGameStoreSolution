
WriteAllLines write = new WriteAllLines();


await WriteAllLines.ExampleAsync();
class WriteAllLines
{
    public static async Task ExampleAsync()
    {
        string[] lines =
        {
            "Bailey", "Kailtyn", "Oscar"
        };

        await File.WriteAllLinesAsync("ournames.txt", lines);
    }
}