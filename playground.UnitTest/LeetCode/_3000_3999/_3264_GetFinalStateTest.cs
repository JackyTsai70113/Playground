namespace playground.UnitTest.LeetCode._3000_3999;

public class _3264_GetFinalStateTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 3, 5, 6 }, 5, 2, new int[] { 8, 4, 6, 5, 6 })]
    [InlineData(new int[] { 1, 2 }, 3, 4, new int[] { 16, 8 })]
    public void GetFinalState(int[] nums, int k, int multiplier, int[] expected)
    {
        var actual = _3264_GetFinalState.GetFinalState(nums, k, multiplier);
        Assert.Equal(expected, actual);
    }
}
