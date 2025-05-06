using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1769_MinOperationsTest
{
    [Theory]
    [InlineData("110", new int[] { 1, 1, 3 })]
    [InlineData("001011", new int[] { 11, 8, 5, 4, 3, 4 })]
    public void MinOperations(string boxes, int[] expected)
    {
        var actual = _1769_MinOperations.MinOperations(boxes);
        Assert.Equal(expected, actual);
    }
}
