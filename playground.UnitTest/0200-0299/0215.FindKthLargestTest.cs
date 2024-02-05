namespace playground.UnitTest;

public class FindKthLargestTest0215
{
    [Theory]
    [InlineData("[3,2,1,5,6,4]", 2, 5)]
    [InlineData("[3,2,3,1,2,4,5,5,6]", 4, 4)]
    public void FindMin(string num, int k, int expected)
    {
        var actual = FindKthLargest0215.FindKthLargest(num.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
