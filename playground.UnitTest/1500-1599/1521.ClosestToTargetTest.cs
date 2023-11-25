namespace playground.UnitTest;

public class ClosestToTargetTest
{
    [Theory]
    [InlineData("[9,12,3,7,15]", 5, 2)]
    [InlineData("[1000000,1000000,1000000]", 1, 999999)]
    [InlineData("[1,2,4,8,16]", 0, 0)]
    public void Candy(string arr, int target, int expected)
    {
        var actual = ClosestToTarget_1521.ClosestToTarget(arr.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}
