namespace playground.UnitTest;

public class MinOperationsTest_2896
{
    [Theory]
    [InlineData("0101001010", "0101001010", 2, 0)]
    [InlineData("1100011000", "0101001010", 2, 4)]
    [InlineData("10110", "00011", 4, -1)]
    public void MinOperations(string s1, string s2, int x, int expected)
    {
        var actual = MinOperations_2896.MinOperations(s1, s2, x);
        Assert.Equal(expected, actual);
    }
}
