using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3418_MaximumAmountTest
{
    [Theory]
    [InlineData("[[-4]]", 0)]
    [InlineData("[[0,1,-1],[1,-2,3],[2,-3,4]]", 8)]
    [InlineData("[[10,10,10],[10,10,10]]", 40)]
    [InlineData("[[6,-16],[0,-18]]", 6)]
    [InlineData("[[4,-16,1,-11],[6,18,-17,14],[16,-10,9,3],[-11,17,0,-11]]", 45)]
    public void MaximumAmount(string A, int expected)
    {
        var actual = _3418_MaximumAmount.MaximumAmount(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
