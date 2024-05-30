namespace playground.UnitTest;

public class CountTripletsTest1442
{
    [Theory]
    [InlineData(new int[] { 2, 3, 1, 6, 7 }, 4)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 10)]
    public void CountTriplets(int[] arr, int expected)
    {
        var actual = CountTriplets1442.CountTriplets(arr);
        Assert.Equal(expected, actual);
    }
}
