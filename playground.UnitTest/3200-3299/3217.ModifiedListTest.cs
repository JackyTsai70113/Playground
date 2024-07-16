namespace playground.UnitTest;

public class ModifiedListTest3217
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, "[1,2,3,4,5]", "[4,5]")]
    [InlineData(new int[] { 1 }, "[1,2,1,2,1,2]", "[2,2,2]")]
    [InlineData(new int[] { 5 }, "[1,2,3,4]", "[1,2,3,4]")]
    public void ModifiedList(int[] nums, string head, string expected)
    {
        var actual = ModifiedList3217.ModifiedList(nums, head.ToListNode());
        Assert.Equal(expected, actual.ToString());
    }
}
