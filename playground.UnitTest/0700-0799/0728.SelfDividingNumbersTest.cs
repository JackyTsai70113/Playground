namespace playground.UnitTest;

public class SelfDividingNumbersTest0728
{
    [Theory]
    [InlineData(1, 22, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
    [InlineData(47, 85, new int[] { 48, 55, 66, 77 })]
    public void SelfDividingNumbers(int left, int right, IList<int> expected)
    {
        var actual = SelfDividingNumbers0728.SelfDividingNumbers(left, right);
        Assert.Equal(expected, actual);
    }
}
