namespace playground.UnitTest.LeetCode._3000_3999;

public class _3217_ModifiedListTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, "[1,2,3,4,5]", "[4,5]")]
    [InlineData(new int[] { 1 }, "[1,2,1,2,1,2]", "[2,2,2]")]
    [InlineData(new int[] { 5 }, "[1,2,3,4]", "[1,2,3,4]")]
    public void ModifiedList(int[] nums, string head, string expected)
    {
        var actual = _3217_ModifiedList.ModifiedList(nums, head.ToListNode());
        Assert.Equal(expected, actual.ToString());
    }
}
