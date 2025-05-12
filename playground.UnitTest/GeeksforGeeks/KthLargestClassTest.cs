using playground.GeeksforGeeks;

namespace playground.UnitTest.GeeksforGeeks;

public class KthLargestClassTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 12)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, 15)]
    [InlineData(new int[] { 3, 2, 1 }, 2, 5)]
    [InlineData(new int[] { 2, 6, 4, 1 }, 3, 11)]
    [InlineData(new int[] { -1, -2, -3, -4, -5 }, 2, -2)]
    public void KthLargestTest(int[] arr, int k, int expected)
    {
        var result = KthLargestClass.KthLargest(arr, k);
        Assert.Equal(expected, result);
    }
}
