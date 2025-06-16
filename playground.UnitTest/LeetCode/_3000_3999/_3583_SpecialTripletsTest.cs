using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3583_SpecialTripletsTest
{
    [Theory]
    [InlineData(new[] { 6, 3, 6 }, 1)]
    [InlineData(new[] { 0, 1, 0, 0 }, 1)]
    [InlineData(new[] { 8, 4, 2, 8, 4 }, 2)]
    public void TestSpecialTriplets(int[] nums, int expected)
    {
        var actual = _3583_SpecialTriplets.SpecialTriplets(nums);
        Assert.Equal(expected, actual);
    }
}
