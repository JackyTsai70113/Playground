using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class MaxUncrossedLinesTest
{
    [Theory]
    [InlineData("[1,4,2]","[1,2,4]", 2)]
    [InlineData("[2,5,1,2,5]","[10,5,2,1,5,2]", 3)]
    [InlineData("[1,3,7,1,7,5]","[1,9,2,5,1]", 2)]
    public void MaxUncrossedLines(string a, string b, int expected)
    {
        int actual = MaxUncrossedLinesClass.MaxUncrossedLines(a.ToArr<int>(), b.ToArr<int>());

        Assert.Equal(expected, actual);
    }
}
