namespace playground.UnitTest;

public class _1424_FindDiagonalOrderTest
{
    [Theory]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", "[1,4,2,7,5,3,8,6,9]")]
    [InlineData("[[1,2,3,4,5],[6,7],[8],[9,10,11],[12,13,14,15,16]]", "[1,6,2,8,7,3,9,4,12,10,5,13,11,14,15,16]")]
    public void FindDiagonalOrder(string nums, string expected)
    {
        var actualArr = _1424_FindDiagonalOrder.FindDiagonalOrder(nums.To2dArr());
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actualArr));
    }
}
