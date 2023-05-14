using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class MaxScoreTest
{
    [Theory]
    [InlineData("[1, 2]", 1)]
    [InlineData("[3,4,6,8]", 11)]
    [InlineData("[1,2,3,4,5,6]", 14)]
    public void MaxScore(string a, int expected)
    {
        int actual = MaxScoreClass.MaxScore(a.ToArr<int>());

        Assert.Equal(expected, actual);
    }
}
