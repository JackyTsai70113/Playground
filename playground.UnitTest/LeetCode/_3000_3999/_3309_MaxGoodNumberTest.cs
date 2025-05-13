using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3309_MaxGoodNumberTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 30)]
    [InlineData(new int[] { 2, 8, 16 }, 1296)]
    public void MaxGoodNumber(int[] nums, int expected)
    {
        var actual = _3309_MaxGoodNumber.MaxGoodNumber(nums);
        Assert.Equal(expected, actual);
    }
}
