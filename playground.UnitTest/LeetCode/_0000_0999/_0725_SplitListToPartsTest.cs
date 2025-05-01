using playground.LeetCode._0000_0999;

using System.Text.Json;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0725_SplitListToPartsTest
{
    [Theory]
    [InlineData("[]", 3, "[[],[],[]]")]
    [InlineData("[1,2,3]", 5, "[[1],[2],[3],[],[]]")]
    [InlineData("[1,2,3,4,5,6,7,8,9,10]", 3, "[[1,2,3,4],[5,6,7],[8,9,10]]")]
    public void SplitListToParts(string head, int k, string expected)
    {
        var actual = _0725_SplitListToParts.SplitListToParts(head.ToListNode(), k);
        var expectedNodeStrs = expected.To2dArr().Select(x => JsonSerializer.Serialize(x)).ToArray();
        for (int i = 0; i < expectedNodeStrs.Length; i++)
        {
            if (expectedNodeStrs[i] == "[]")
                Assert.Null(actual[i]);
            else
                Assert.Equal(expectedNodeStrs[i], actual[i].ToString());
        }
    }
}
