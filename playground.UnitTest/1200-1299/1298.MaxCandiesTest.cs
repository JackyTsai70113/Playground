namespace playground.UnitTest;

public class MaxCandiesTest1298
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 0 }, new int[] { 7, 5, 4, 100 }, "[[],[],[1],[]]", "[[1,2],[3],[],[]]", new int[] { 0 }, 16)]
    [InlineData(new int[] { 1, 0, 0, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 1, 1 }, "[[1,2,3,4,5],[],[],[],[],[]]", "[[1,2,3,4,5],[],[],[],[],[]]", new int[] { 0 }, 6)]
    public void MaxCandies(int[] status, int[] candies, string keys, string containedBoxes, int[] initialBoxes, int expected)
    {
        {
            var actual = MaxCandies1298.MaxCandies(status, candies, keys.To2dArr(), containedBoxes.To2dArr(), initialBoxes);
            Assert.Equal(expected, actual);
        }
    }
}
