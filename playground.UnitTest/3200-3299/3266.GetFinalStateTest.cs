namespace playground.UnitTest;

public class GetFinalStateTest3266
{
    [Theory]
    [InlineData(new int[] { 1, 2, 5 }, 1, 2, new int[] { 2, 2, 5 })]
    [InlineData(new int[] { 2, 1, 3, 5, 6 }, 5, 1, new int[] { 2, 1, 3, 5, 6 })]
    [InlineData(new int[] { 2, 1, 3, 5, 6 }, 5, 2, new int[] { 8, 4, 6, 5, 6 })]
    [InlineData(new int[] { 100000, 2000 }, 2, 1000000, new int[] { 999999307, 999999993 })]
    public void GetFinalState(int[] nums, int k, int multiplier, int[] expected)
    {
        var actual = GetFinalState3266.GetFinalState(nums, k, multiplier);
        Assert.Equal(expected, actual);
    }
}