using playground.UnitTest.Utils;

namespace playground.UnitTest;


public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 3, 4, 6, 5 }, new int[] { 9, 1, 2, 5, 8, 3 }, 5, new int[] { 9, 8, 6, 5, 3 })]
    [InlineData(new int[] { 6, 7 }, new int[] { 6, 0, 4 }, 5, new int[] { 6, 7, 6, 0, 4 })]
    [InlineData(new int[] { 3, 9 }, new int[] { 8, 9 }, 3, new int[] { 9, 8, 9 })]
    [InlineData(new int[] { 8, 1, 8, 8, 6 }, new int[] { 4 }, 2, new int[] { 8, 8 })]
    public void MaxNumberTest(int[] nums1, int[] nums2, int k, int[] expect)
    {
        var result = Solution.MaxNumber(nums1, nums2, k);

        Assert.Equal(expect, result);
    }

    [Theory]
    [InlineData(4, new int[] { 0, 2, 0, 1, 1, 2 }, 1)]
    [InlineData(6, new int[] { 0, 1, 0, 2, 0, 3, 1, 2, 1, 3 }, 2)]
    [InlineData(6, new int[] { 0, 1, 0, 2, 0, 3, 1, 2, }, -1)]
    [InlineData(8, new int[] { 0, 1, 0, 2, 0, 3, 1, 2, 1, 3, 2, 3, 4, 5 }, 3)]
    [InlineData(5, new int[] { 0, 1, 2, 3 }, -1)]
    [InlineData(4, new int[] { 0, 1, 0, 2 }, -1)]
    [InlineData(4, new int[] { 0, 1, 2, 3 }, -1)]
    [InlineData(5, new int[] { 0, 1, 0, 2, 2, 3 }, -1)]
    [InlineData(4, new int[] { 0, 1, 0, 2, 1, 2 }, 1)]
    [InlineData(4, new int[] { 0, 1, 0, 2, 2, 3 }, 0)]
    [InlineData(3, new int[] { 0, 1, 0, 2, 1, 2 }, 0)]
    public void MakeConnectedTest(int n, int[] connections, int expect)
    {
        var arr = connections.To2dArray(2);

        int result = Solution.MakeConnected(n, arr);

        Assert.Equal(expect, result);
    }

    [Theory]
    [InlineData(3, new int[] { 0, 1, 0, 2, 1, 2 }, 0)]
    [InlineData(7, new int[] { 0, 2, 0, 5, 2, 4, 1, 6, 5, 4 }, 14)]
    public void CountPairsTest(int n, int[] array, int expect)
    {
        var edges = array.To2dArray(2);

        long result = Solution.CountPairs(n, edges);

        Assert.Equal(expect, result);
    }

    [Theory]
    [InlineData(3997649, true)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    public void IsPrimeTest(int number, bool expected)
    {
        var actual = new IsPrimeClass((int)(4*1e6)).IsPrime(number);

        Assert.Equal(expected, actual);
    }
}
