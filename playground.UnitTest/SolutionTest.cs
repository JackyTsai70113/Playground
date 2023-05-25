namespace playground.UnitTest;

public class SolutionTest
{
    [Fact]
    public void Solution()
    {
        // int aa = playground.Solution.TakeCharacters("aabaaaacaabc", 2);
        int aa = playground.Solution.CountPartitions(new int[] { 1, 2, 3, 4 }, 4);
        Console.WriteLine(aa);
    }
}
