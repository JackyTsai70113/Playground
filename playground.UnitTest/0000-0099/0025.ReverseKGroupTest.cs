namespace playground.UnitTest;

public class ReverseKGroupTest_0025
{
    [Theory]
    [InlineData("[1,2]", 2, "[2,1]")]
    [InlineData("[1,2,3,4,5]", 1, "[1,2,3,4,5]")]
    [InlineData("[1,2,3,4,5]", 2, "[2,1,4,3,5]")]
    [InlineData("[1,2,3,4,5]", 3, "[3,2,1,4,5]")]
    public void ReverseKGroup(string head, int k, string expected)
    {
        var actual = ReverseKGroup_0025.ReverseKGroup(head.ToListNode(), k);
        Assert.Equal(expected, actual.ToString());
    }
}