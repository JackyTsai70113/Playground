namespace playground.UnitTest;

public class FindPermutationDifferenceTest3146
{
    [Theory]
    [InlineData("abc", "bac", 2)]
    [InlineData("abcde", "edbac", 12)]
    public void FindPermutationDifference(string s, string t, int expected)
    {
        var actual = FindPermutationDifference3146.FindPermutationDifference(s, t);
        Assert.Equal(expected, actual);
    }
}
