namespace playground.UnitTest;

public class PlusOneTest0066
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    public void PlusOne(int[] digits, int[] expected)
    {
        var actual = PlusOne0066.PlusOne(digits);
        Assert.Equal(expected, actual);
    }
}
