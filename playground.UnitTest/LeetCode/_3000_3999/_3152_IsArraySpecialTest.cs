namespace playground.UnitTest;

public class _3152_IsArraySpecialTest
{
    [Theory]
    [InlineData(new int[] { 3, 4, 1, 2, 6 }, "[[0,4]]", new bool[] { false })]
    [InlineData(new int[] { 4, 3, 1, 6 }, "[[0,2],[2,3]]", new bool[] { false, true })]
    [InlineData(new int[] { 6, 4, 9 }, "[[0,2]]", new bool[] { false })]
    [InlineData(new int[] { 9, 5, 9 }, "[[0,2]]", new bool[] { false })]
    [InlineData(new int[] { 3, 7, 3, 10, 5, 5 }, "[[3,4],[1,5],[5,5],[0,4],[1,2],[2,3],[5,5],[0,1]]", new bool[] { true, false, true, false, false, true, true, false })]
    public static void IsArraySpecial(int[] nums, string qs, bool[] expected)
    {
        var actual = _3152_IsArraySpecial.IsArraySpecial(nums, qs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
