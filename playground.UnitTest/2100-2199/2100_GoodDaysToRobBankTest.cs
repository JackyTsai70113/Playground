using playground._2100_2199;

namespace playground.UnitTest._2100_2199;

public class _2100_GoodDaysToRobBankTest
{
    [Theory]
    [InlineData(new int[] { 5, 7, 3, 1, 2 }, 2, new int[] { })]
    [InlineData(new int[] { 5, 3, 3, 3, 5, 6, 2 }, 8, new int[] { })]
    [InlineData(new int[] { 5, 3, 3, 3, 5, 6, 2 }, 2, new int[] { 2, 3 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 0, new int[] { 0, 1, 2, 3, 4 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 2, new int[] { })]
    public void GoodDaysToRobBank(int[] nums, int k, IList<int> expected)
    {
        var actual = _2100_GoodDaysToRobBank.GoodDaysToRobBank(nums, k);
        Assert.Equal(expected, actual);
    }
}
