using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class DivisibilityArrayTest
{
    [Theory]
    [InlineData("998244353", 3, new int[] { 1, 1, 0, 0, 0, 1, 1, 0, 0 })]
    [InlineData("1010", 10, new int[] { 0, 1, 0, 1 })]
    public void DivisibilityArray(string word, int m, int[] expected)
    {
        var actual = DivisibilityArrayClass.DivisibilityArray(word, m);
        Assert.Equal(expected, actual);
    }
}
