using playground.Backtracking;

namespace playground.UnitTest.Backtracking;

public class CombinationSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 6, 7 }, 7, "[[2,2,3],[7]]")]
    [InlineData(new int[] { 2, 3, 5 }, 8, "[[2,2,2,2],[2,3,3],[3,5]]")]
    [InlineData(new int[] { 2 }, 1, "[]")]
    public void CombinationSum(int[] A, int target, string str2)
    {
        var actual = CombinationSumClass.CombinationSum(A, target);
        var expected = str2.To2dArr();
        Assert.Equal(expected, actual.ToArray());
    }
}
