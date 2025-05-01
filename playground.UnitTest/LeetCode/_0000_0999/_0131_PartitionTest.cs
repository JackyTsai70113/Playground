using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0131_PartitionTest
{
    [Theory]
    [InlineData("aab", "[[\"a\",\"a\",\"b\"],[\"aa\",\"b\"]]")]
    [InlineData("a", "[[\"a\"]]")]
    public void Partition(string s, string expected)
    {
        var actual = _0131_Partition.Partition(s);
        Assert.Equal(expected.To2dArr<string>(), actual);
    }
}
