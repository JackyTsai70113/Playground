using playground.Backtracking;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Backtracking;

public class CombinationSumTest
{
    [Theory]
    [InlineData("[2,3,6,7]", 7, "[[2,2,3],[7]]")]
    [InlineData("[2,3,5]", 8, "[[2,2,2,2],[2,3,3],[3,5]]")]
    [InlineData("[2]", 1, "[]")]
    public void CombinationSum(string str, int target, string str2)
    {
        var arr = str.ToArr<int>();
        var actual = CombinationSumClass.CombinationSum(arr, target);
        var expected = str2.To2dArr<int>();
        Assert.Equal(expected, actual.ToArray());
    }
}
