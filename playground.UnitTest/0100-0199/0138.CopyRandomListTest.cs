namespace playground.UnitTest;

public class CopyRandomListTest0138
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[[7,null],[13,0],[11,4],[10,2],[1,0]]", "[[7,null],[13,0],[11,4],[10,2],[1,0]]")]
    [InlineData("[[1,1],[2,1]]", "[[1,1],[2,1]]")]
    [InlineData("[[3,null],[3,0],[3,null]]", "[[3,null],[3,0],[3,null]]")]
    public void CopyRandomList(string head, string expected)
    {
        var actual = CopyRandomList0138.CopyRandomList(head.ToRandomNode());
        if (head == "[]")
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
