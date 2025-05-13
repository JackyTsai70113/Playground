namespace playground.UnitTest.LeetCode._1000_1999;

public class _1521_ClosestToTargetTest
{
    [Theory]
    [InlineData("[9,12,3,7,15]", 5, 2)]
    [InlineData("[1000000,1000000,1000000]", 1, 999999)]
    [InlineData("[1,2,4,8,16]", 0, 0)]
    public void Candy(string arr, int target, int expected)
    {
        var actual = _1521_ClosestToTarget.ClosestToTarget(arr.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}
