using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0433_MinMutationTest
{
    [Theory]
    [InlineData("AACCGGTT", "AACCGGTA", new string[] { "AACCGGTA" }, 1)]
    [InlineData("AACCGGTT", "AAACGGTA", new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" }, 2)]
    [InlineData("AACCGGTT", "CCCCGGTT", new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA", "CCCCGGTT" }, -1)]
    [InlineData("AACCGGTT", "AAACGGTA", new string[] { }, -1)]
    public void MinMutation(string start, string end, string[] bank, int expected)
    {
        var actual = _0433_MinMutation.MinMutation(start, end, bank);
        Assert.Equal(expected, actual);
    }
}
