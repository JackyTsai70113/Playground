using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3335_LengthAfterTransformationsTest
{
    [Theory]
    [InlineData("abcyy", 2, 7)]
    [InlineData("azbk", 1, 5)]
    public void LengthAfterTransformations(string s, int t, int expected)
    {
        int actual;
        actual = _3335_LengthAfterTransformations.LengthAfterTransformations_TopDown(s, t);
        Assert.Equal(expected, actual);
        actual = _3335_LengthAfterTransformations.LengthAfterTransformations_ButtomUp(s, t);
        Assert.Equal(expected, actual);
        actual = _3335_LengthAfterTransformations.LengthAfterTransformations_OptimizeSpace(s, t);
        Assert.Equal(expected, actual);
    }
}
