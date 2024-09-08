using System.Text.Json;

namespace playground.UnitTest;

public class SplitListToPartsTest0725
{
    [Theory]
    [InlineData("[]", 3, "[[],[],[]]")]
    [InlineData("[1,2,3]", 5, "[[1],[2],[3],[],[]]")]
    [InlineData("[1,2,3,4,5,6,7,8,9,10]", 3, "[[1,2,3,4],[5,6,7],[8,9,10]]")]
    public void SplitListToParts(string head, int k, string expected)
    {
        var actual = SplitListToParts0725.SplitListToParts(head.ToListNode(), k);
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
