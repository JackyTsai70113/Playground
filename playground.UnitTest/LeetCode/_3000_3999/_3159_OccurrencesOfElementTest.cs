namespace playground.UnitTest;

public class _3159_OccurrencesOfElementTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 1, 7 }, new int[] { 1, 3, 2, 4 }, 1, new int[] { 0, -1, 2, -1 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 10 }, 5, new int[] { -1 })]
    public void OccurrencesOfElement(int[] nums, int[] queries, int x, int[] expected)
    {
        var actual = _3159_OccurrencesOfElement.OccurrencesOfElement(nums, queries, x);
        Assert.Equal(expected, actual);
    }
}
