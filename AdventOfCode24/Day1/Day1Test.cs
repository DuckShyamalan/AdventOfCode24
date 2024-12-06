using NUnit.Framework;

namespace AdventOfCode24.Day1;

public class Day1Test
{
    [Test]
    public void Part1()
    {
        var input = File.ReadAllText("day1.txt");
        var distance = new Day1().GetTotalDistance(input);
        
        Console.WriteLine(distance);
    }
    
    [Test]
    public void Part2()
    {
        var input = File.ReadAllText("day1.txt");
        var distance = new Day1().GetSimilarityScore(input);
        
        Console.WriteLine(distance);
    }
}