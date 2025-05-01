using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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
