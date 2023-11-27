namespace playground.UnitTest;

public class FindMaximumLengthTest
{
    [Theory]
    [InlineData("[5,2,2]", 1)]
    [InlineData("[1,2,3,4]", 4)]
    [InlineData("[4,3,2,6]", 3)]
    public void FindMaximumLength(string A, int expected)
    {
        var actual = FindMaximumLength_2945.FindMaximumLength(A.ToArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[5,2,2]", 1)]
    [InlineData("[1,2,3,4]", 4)]
    [InlineData("[4,3,2,6]", 3)]
    public void FindMaximumLength2(string A, int expected)
    {
        var actual = FindMaximumLength_2945.FindMaximumLength2(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
