namespace playground.UnitTest;

public class CombinationSumTest0039
{
    [Theory]
    [InlineData(new int[] { 2, 3, 6, 7 }, 7, "[[2,2,3],[7]]")]
    [InlineData(new int[] { 2, 3, 5 }, 8, "[[2,2,2,2],[2,3,3],[3,5]]")]
    [InlineData(new int[] { 2 }, 1, "[]")]
    public void CombinationSum(int[] A, int target, string expected)
    {
        var actual = CombinationSum0039.CombinationSum(A, target);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
