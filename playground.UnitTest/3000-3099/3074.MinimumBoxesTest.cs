namespace playground.UnitTest;

public class MinimumBoxesTest3074
{
    [Theory]
    [InlineData("[1,3,2]", "[4,3,1,5,2]", 2)]
    [InlineData("[5,5,5]", "[2,4,2,7]", 4)]
    public void MinimumBoxes(string apple, string capacity, int expected)
    {
        var actual = MinimumBoxes3074.MinimumBoxes(apple.ToArr(), capacity.ToArr());
        Assert.Equal(expected, actual);
    }
}
