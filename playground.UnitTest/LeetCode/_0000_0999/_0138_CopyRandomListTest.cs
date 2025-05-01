using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0138_CopyRandomListTest
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[[7,null],[13,0],[11,4],[10,2],[1,0]]", "[[7,null],[13,0],[11,4],[10,2],[1,0]]")]
    [InlineData("[[1,1],[2,1]]", "[[1,1],[2,1]]")]
    [InlineData("[[3,null],[3,0],[3,null]]", "[[3,null],[3,0],[3,null]]")]
    public void CopyRandomList(string head, string expected)
    {
        var actual = _0138_CopyRandomList.CopyRandomList(head.ToRandomNode());
        if (head == "[]")
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
