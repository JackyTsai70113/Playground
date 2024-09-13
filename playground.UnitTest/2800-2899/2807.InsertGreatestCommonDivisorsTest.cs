namespace playground.UnitTest;

public class InsertGreatestCommonDivisorsTest2807
{
    [Theory]
    [InlineData("[18,6,10,3]", "[18,6,6,2,10,1,3]")]
    [InlineData("[7]", "[7]")]
    public void InsertGreatestCommonDivisors(string head, string expected)
    {
        var actual = InsertGreatestCommonDivisors2807.InsertGreatestCommonDivisors(head.ToListNode());
        Assert.Equal(expected, actual.ToString());
    }
}
