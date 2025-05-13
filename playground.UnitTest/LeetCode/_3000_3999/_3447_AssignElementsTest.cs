using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3447_AssignElementsTest
{
    [Theory]
    [InlineData(new int[] { 8, 4, 3, 2, 4 }, new int[] { 4, 2 }, new int[] { 0, 0, -1, 1, 0 })]
    [InlineData(new int[] { 2, 3, 5, 7 }, new int[] { 5, 3, 3 }, new int[] { -1, 1, 0, -1 })]
    [InlineData(new int[] { 10, 21, 30, 41 }, new int[] { 2, 1 }, new int[] { 0, 1, 0, 1 })]
    public void AssignElements(int[] groups, int[] elements, int[] expected)
    {
        var actual = _3447_AssignElements.AssignElements(groups, elements);
        Assert.Equal(expected, actual);
    }
}
