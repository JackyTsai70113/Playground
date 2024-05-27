namespace playground.UnitTest;

public class OccurrencesOfElementTest3159
{
    [Theory]
    [InlineData(new int[] { 1, 3, 1, 7 }, new int[] { 1, 3, 2, 4 }, 1, new int[] { 0, -1, 2, -1 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 10 }, 5, new int[] { -1 })]
    public void OccurrencesOfElement(int[] nums, int[] queries, int x, int[] expected)
    {
        var actual = OccurrencesOfElement3159.OccurrencesOfElement(nums, queries, x);
        Assert.Equal(expected, actual);
    }
}
