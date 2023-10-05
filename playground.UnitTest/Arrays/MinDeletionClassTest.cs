using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MinDeletionClassTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 3, 5 }, 1)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3 }, 2)]
    public void MinDeletion(int[] nums, int expected)
    {
        var actual = MinDeletionClass.MinDeletion(nums);
        Assert.Equal(expected, actual);
    }
}
