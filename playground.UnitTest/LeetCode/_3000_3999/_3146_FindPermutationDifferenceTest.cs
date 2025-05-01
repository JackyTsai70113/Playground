namespace playground.UnitTest;

public class _3146_FindPermutationDifferenceTest
{
    [Theory]
    [InlineData("abc", "bac", 2)]
    [InlineData("abcde", "edbac", 12)]
    public void FindPermutationDifference(string s, string t, int expected)
    {
        var actual = _3146_FindPermutationDifference.FindPermutationDifference(s, t);
        Assert.Equal(expected, actual);
    }
}
