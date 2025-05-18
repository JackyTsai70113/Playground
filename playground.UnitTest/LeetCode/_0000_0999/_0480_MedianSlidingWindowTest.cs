using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0480_MedianSlidingWindowTest
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, 1, new double[] { 1.00000, 2.00000 })]
    [InlineData(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3,
        new double[] { 1.00000, -1.00000, -1.00000, 3.00000, 5.00000, 6.00000 })]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 3, 1, 4, 2 }, 3,
        new double[] { 2.00000, 3.00000, 3.00000, 3.00000, 2.00000, 3.00000, 2.00000 })]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 3, 1, 4, 2 }, 4,
        new double[] { 2.50000, 2.50000, 3.00000, 2.50000, 2.50000, 2.50000 })]
    public void MedianSlidingWindow(int[] A, int k, double[] expected)
    {
        double[] actual = _0480_MedianSlidingWindow.MedianSlidingWindow(A, k);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 2147483647, 2147483647 }, 2, new double[] { 2147483647.00000 })]
    [InlineData(new int[] { 1, 2 }, 1, new double[] { 1.00000, 2.00000 })]
    [InlineData(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3,
       new double[] { 1.00000, -1.00000, -1.00000, 3.00000, 5.00000, 6.00000 })]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 3, 1, 4, 2 }, 3,
       new double[] { 2.00000, 3.00000, 3.00000, 3.00000, 2.00000, 3.00000, 2.00000 })]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 3, 1, 4, 2 }, 4,
       new double[] { 2.50000, 2.50000, 3.00000, 2.50000, 2.50000, 2.50000 })]
    public void MedianSlidingWindow_DynamicMedian(int[] A, int k, double[] expected)
    {
        double[] actual = _0480_MedianSlidingWindow.MedianSlidingWindow_DynamicMedian(A, k);
        Assert.Equal(expected, actual);
    }
}
