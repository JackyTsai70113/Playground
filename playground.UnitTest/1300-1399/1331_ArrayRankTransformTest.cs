using playground._1300_1399;

namespace playground.UnitTest._1300_1399;

public class _1331_ArrayRankTransformTest
{
    [Theory]
    [InlineData(new int[] { 40, 10, 20, 30 }, new int[] { 4, 1, 2, 3 })]
    [InlineData(new int[] { 100, 100, 100 }, new int[] { 1, 1, 1 })]
    [InlineData(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 }, new int[] { 5, 3, 4, 2, 8, 6, 7, 1, 3 })]
    public void ArrayRankTransform(int[] arr, int[] expected)
    {
        var actual = _1331_ArrayRankTransform.ArrayRankTransform(arr);
        Assert.Equal(expected, actual);
    }
}
