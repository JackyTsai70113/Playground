using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3337_LengthAfterTransformationsTest
{
    [Theory]
    [InlineData("abcyy", 2, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 }, 7)]
    [InlineData("azbk", 1, new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 8)]
    public void LengthAfterTransformations(string s, int t, int[] nums, int expected)
    {
        int actual;
        actual = _3337_LengthAfterTransformations.LengthAfterTransformations_TopDown(s, t, nums);
        Assert.Equal(expected, actual);
        actual = _3337_LengthAfterTransformations.LengthAfterTransformations_BottomUp(s, t, nums);
        Assert.Equal(expected, actual);
        actual = _3337_LengthAfterTransformations.LengthAfterTransformations_OptimizeSpace(s, t, nums);
        Assert.Equal(expected, actual);
        actual = _3337_LengthAfterTransformations.LengthAfterTransformations_OptimizeSpace2(s, t, nums);
        Assert.Equal(expected, actual);
        actual = _3337_LengthAfterTransformations.LengthAfterTransformations_Matrix(s, t, nums);
        Assert.Equal(expected, actual);
    }
}
