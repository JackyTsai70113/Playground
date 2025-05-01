using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0023_MergeKListsTest
{
    [Theory]
    [InlineData(new string[] { "[1,4,5]", "[1,3,4]", "[2,6]" }, "[1,1,2,3,4,4,5,6]")]
    [InlineData(new string[] { "[]" }, "[]")]
    [InlineData(new string[] { }, "[]")]
    public void MergeKLists(string[] lists, string expected)
    {
        var actual = _0023_MergeKLists.MergeKLists(lists.Select(x => x.ToListNode()).ToArray());
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
