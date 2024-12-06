using System.Collections;

namespace AdventOfCode24.Day1;

public class Day1
{
    internal int GetTotalDistance(string input)
    {
        var (left, right) = ParseInput(input);
        left = left.Order();
        right = right.Order();
        return left.Zip(right, GetDistance).Sum();
    }

    internal int GetSimilarityScore(string input)
    {
        var (left, right) = ParseInput(input);
        return left.Select(x => x * right.Count(y => y == x)).Sum();
    }
    
    private int GetDistance(int left, int right)
    {
        return Math.Abs(left - right);
    }
    
    private (IEnumerable<int> left, IEnumerable<int> right) ParseInput(string input)
    {
        IEnumerable<string[]> lists = input.Split("\n").Select(x => x.Split("   ")); // [[l, r], [l, r], ..]

        var stringsEnumerable = lists as string[][] ?? lists.ToArray();
        IEnumerable<int> leftList = stringsEnumerable.Select(x => int.Parse(x[0]));
        IEnumerable<int> rightList = stringsEnumerable.Select(x => int.Parse(x[1]));

        return (leftList, rightList);
    }
}