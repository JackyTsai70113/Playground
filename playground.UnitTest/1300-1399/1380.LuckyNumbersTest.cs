namespace playground.UnitTest;

public class LuckyNumbersTest1380
{
    [Theory]
    [InlineData("[[3,7,8],[9,11,13],[15,16,17]]", new int[] { 15 })]
    [InlineData("[[1,10,4,2],[9,3,8,7],[15,16,17,12]]", new int[] { 12 })]
    [InlineData("[[7,8],[1,2]]", new int[] { 7 })]
    public void LuckyNumbers(string A, IList<int> expected)
    {
        var actual = LuckyNumbers1380.LuckyNumbers(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
