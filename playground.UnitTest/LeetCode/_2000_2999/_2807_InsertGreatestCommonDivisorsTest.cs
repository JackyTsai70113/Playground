using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2807_InsertGreatestCommonDivisorsTest
{
    [Theory]
    [InlineData("[18,6,10,3]", "[18,6,6,2,10,1,3]")]
    [InlineData("[7]", "[7]")]
    public void InsertGreatestCommonDivisors(string head, string expected)
    {
        var actual = _2807_InsertGreatestCommonDivisors.InsertGreatestCommonDivisors(head.ToListNode());
        Assert.Equal(expected, actual.ToString());
    }
}
