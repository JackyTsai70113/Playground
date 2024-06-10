namespace playground.UnitTest;

public class SortedArrayToBSTTest0108
{
    [Theory]
    [InlineData(new int[] { -10, -3, 0, 5, 9 }, "[0,-10,5,null,-3,null,9]")]
    [InlineData(new int[] { 1, 3 }, "[1,null,3]")]
    public void SortedArrayToBST(int[] nums, string expected)
    {
        var actual = SortedArrayToBST0108.SortedArrayToBST(nums);
        Assert.Equal(expected, actual.ToString());
    }
}
