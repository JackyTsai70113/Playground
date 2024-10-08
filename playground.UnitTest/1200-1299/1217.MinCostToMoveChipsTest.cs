namespace playground.UnitTest;

public class MinCostToMoveChipsTest1217
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 1)]
    [InlineData(new int[] { 2, 2, 2, 3, 3 }, 2)]
    [InlineData(new int[] { 1, 1, 1000000000 }, 1)]
    public void MinCostToMoveChips(int[] position, int expected)
    {
        var actual = MinCostToMoveChips1217.MinCostToMoveChips(position);
        Assert.Equal(expected, actual);
    }
}
