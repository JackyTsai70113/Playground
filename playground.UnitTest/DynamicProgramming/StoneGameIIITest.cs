using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class StoneGameIIITest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 9, 4, 4 }, "Alice")]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 100 }, "Alice")]
    [InlineData(new int[] { 1, 2, 3, 6 }, "Tie")]
    [InlineData(new int[] { 1, 2, 3, 7 }, "Bob")]
    [InlineData(new int[] { 1, 2, 3, -9 }, "Alice")]
    [InlineData(new int[] { -1, -2, -3 }, "Tie")]
    [InlineData(new int[] { 9, -4, 0, 12, -5, -13, 15, 6, -16, 8, 2, 16, 12, -6, 13, 0, -16, -11, 9, -14, 7, -1, 14 }, "Bob")]
    public void StoneGameIII(int[] stoneValue, string expected)
    {
        var actual = StoneGameIIIClass.StoneGameIII(stoneValue);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 9, 4, 4 }, "Alice")]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 100 }, "Alice")]
    [InlineData(new int[] { 1, 2, 3, 6 }, "Tie")]
    [InlineData(new int[] { 1, 2, 3, 7 }, "Bob")]
    [InlineData(new int[] { 1, 2, 3, -9 }, "Alice")]
    [InlineData(new int[] { -1, -2, -3 }, "Tie")]
    [InlineData(new int[] { 9, -4, 0, 12, -5, -13, 15, 6, -16, 8, 2, 16, 12, -6, 13, 0, -16, -11, 9, -14, 7, -1, 14 }, "Bob")]
    public void StoneGameIII_Tabulation(int[] stoneValue, string expected)
    {
        var actual = StoneGameIIIClass.StoneGameIII_Tabulation(stoneValue);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 9, 4, 4 }, "Alice")]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 100 }, "Alice")]
    [InlineData(new int[] { 1, 2, 3, 6 }, "Tie")]
    [InlineData(new int[] { 1, 2, 3, 7 }, "Bob")]
    [InlineData(new int[] { 1, 2, 3, -9 }, "Alice")]
    [InlineData(new int[] { -1, -2, -3 }, "Tie")]
    [InlineData(new int[] { 9, -4, 0, 12, -5, -13, 15, 6, -16, 8, 2, 16, 12, -6, 13, 0, -16, -11, 9, -14, 7, -1, 14 }, "Bob")]
    public void StoneGameIII_Tabulation_O1(int[] stoneValue, string expected)
    {
        var actual = StoneGameIIIClass.StoneGameIII_Tabulation_O1(stoneValue);
        Assert.Equal(expected, actual);
    }
}
