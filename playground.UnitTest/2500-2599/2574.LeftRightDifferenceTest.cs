namespace playground.UnitTest;

public class LeftRightDifferenceTest2574
{
    [Theory]
    [InlineData(new int[] { 10, 4, 8, 3 }, new int[] { 15, 1, 11, 22 })]
    [InlineData(new int[] { 1 }, new int[] { 0 })]
    public void LeftRightDifference(int[] nums, int[] expected)
    {
        var actual = LeftRightDifference2574.LeftRightDifference(nums);
        Assert.Equal(expected, actual);
    }
}
