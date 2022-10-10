
WriteAllLines write = new WriteAllLines();


await WriteAllLines.ExampleAsync();
class WriteAllLines
{
    public static async Task ExampleAsync()
    {
        string[] lines =
        {
            "test1", "test2", "test3", "test4"
        };

        await File.WriteAllLinesAsync("ournames.txt", lines);
    }
}