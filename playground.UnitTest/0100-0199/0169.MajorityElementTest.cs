namespace playground.UnitTest;

public class MajorityElementTest0169
{
    [Theory]
    [InlineData(new int[] { 2, 2, 3 }, 2)]
    [InlineData(new int[] { 2, 3, 2 }, 2)]
    [InlineData(new int[] { 3, 2, 2 }, 2)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    [InlineData(new int[] { 1, 1, 2, 2, 2, 1, 1 }, 1)]
    [InlineData(new int[] { 1, 2, 1, 2, 1 }, 1)]
    [InlineData(new int[] { 1, 2, 1, 2, 1, 2, 2, 2 }, 2)]
    [InlineData(new int[] { 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345 }, 345)]
    public void MajorityElement(int[] nums, int expected)
    {
        var actual = MajorityElement0169.MajorityElement(nums);
        Assert.Equal(expected, actual);
    }
}
