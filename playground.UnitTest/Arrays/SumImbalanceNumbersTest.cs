using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class SumImbalanceNumbersTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 1, 4 }, 3)]
    [InlineData(new int[] { 1, 3, 2, 4 }, 2)]
    [InlineData(new int[] { 1, 3, 3, 3, 5 }, 8)]
    public void SumImbalanceNumbers(int[] nums, int expected)
    {
        var actual = SumImbalanceNumbersClass.SumImbalanceNumbers(nums);
        Assert.Equal(expected, actual);
    }
}
