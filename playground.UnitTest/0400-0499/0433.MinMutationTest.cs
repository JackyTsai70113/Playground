namespace playground.UnitTest;

public class MinMutationTest0433
{
    [Theory]
    [InlineData("AACCGGTT", "AACCGGTA", new string[] { "AACCGGTA" }, 1)]
    [InlineData("AACCGGTT", "AAACGGTA", new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" }, 2)]
    [InlineData("AACCGGTT", "CCCCGGTT", new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA", "CCCCGGTT" }, -1)]
    [InlineData("AACCGGTT", "AAACGGTA", new string[] { }, -1)]
    public void MinMutation(string start, string end, string[] bank, int expected)
    {
        var actual = MinMutation0433.MinMutation(start, end, bank);
        Assert.Equal(expected, actual);
    }
}
