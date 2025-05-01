using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2945_FindMaximumLengthTest
{
    [Theory]
    [InlineData("[5,2,2]", 1)]
    [InlineData("[1,2,3,4]", 4)]
    [InlineData("[4,3,2,6]", 3)]
    public void FindMaximumLength(string A, int expected)
    {
        var actual = _2945_FindMaximumLength.FindMaximumLength(A.ToArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[5,2,2]", 1)]
    [InlineData("[1,2,3,4]", 4)]
    [InlineData("[4,3,2,6]", 3)]
    public void FindMaximumLength2(string A, int expected)
    {
        var actual = _2945_FindMaximumLength.FindMaximumLength2(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
