using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MinOperationsTest
{
    [Theory]
    [InlineData("0101001010", "0101001010", 2, 0)]
    [InlineData("1100011000", "0101001010", 2, 4)]
    [InlineData("10110", "00011", 4, -1)]
    public void MinOperations(string s1, string s2, int x, int expected)
    {
        int actual = MinOperationsClass.MinOperations(s1, s2, x);
        Assert.Equal(expected, actual);
    }
}
