namespace playground.UnitTest;

public class MaximizeSquareHoleAreaTest
{
    [Theory]
    [InlineData("[2,3]", "[2]", 4)]
    [InlineData("[2]", "[2]", 4)]
    [InlineData("[2,3]", "[2,3,4]", 9)]
    [InlineData("[2,4]", "[2,4]", 4)]
    public void MaximizeSquareHoleArea(string A, string B, int expected)
    {
        var actual = MaximizeSquareHoleArea_2943.MaximizeSquareHoleArea(A.ToArr(), B.ToArr());
        Assert.Equal(expected, actual);
    }
}
