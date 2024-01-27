namespace playground.UnitTest;

public class SortListTest0148
{
    [Theory]
    [InlineData("[4,2,1,3]", "[1,2,3,4]")]
    [InlineData("[-1,5,3,4,0]", "[-1,0,3,4,5]")]
    [InlineData("[]", "[]")]
    public void SortList(string A, string expected)
    {
        var actual = SortList0148.SortList(A.ToListNode());
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
