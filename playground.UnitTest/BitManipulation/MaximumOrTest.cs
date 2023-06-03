using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class MaximumOrTest
{
    [Theory]
    [InlineData(new int[] { 12, 9 }, 1, 30)]
    [InlineData(new int[] { 8, 1, 2 }, 2, 35)]
    public void MaximumOr(int[] nums, int k, long expected)
    {
        var actual = MaximumOrClass.MaximumOr(nums, k);
        Assert.Equal(expected, actual);
    }
}
