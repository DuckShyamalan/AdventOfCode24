using NUnit.Framework;
namespace AdventOfCode24.TestUtils;

public abstract class TestSetup
{
    protected static string Input { get; private set; } = null!;
    
    [SetUp]
    public static async Task Setup()
    {
        Input = await File.ReadAllTextAsync("AdventOfCode24/Day1/input.txt");
    }
}