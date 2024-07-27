namespace playground.UnitTest;

public class SortJumbledTest2191
{
    [Theory]
    [InlineData(new int[] { 8, 9, 4, 0, 2, 1, 3, 5, 7, 6 }, new int[] { 991, 338, 38 }, new int[] { 338, 38, 991 })]
    [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 789, 456, 123 }, new int[] { 123, 456, 789 })]
    public void SortJumbled(int[] mapping, int[] nums, int[] expected)
    {
        var actual = SortJumbled2191.SortJumbled(mapping, nums);
        Assert.Equal(expected, actual);
    }
}
