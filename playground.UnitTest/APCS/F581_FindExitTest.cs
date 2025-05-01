using playground.APCS;

namespace playground.UnitTest.APCS;

public class F581_FindExitTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 4, 2, 1, 3 }, new int[] { 11, 8, 7 }, 5)]
    [InlineData(new int[] { 2, 3, 4, 5, 6 }, new int[] { 8, 7 }, 0)]
    [InlineData(new int[] { 2, 1, 5, 4, 3, 5, 3 }, new int[] { 8, 9, 12 }, 4)]
    [InlineData(new int[] { 1, 3, 5, 7 }, new int[] { 4, 2, 2 }, 0)]
    public void FindExit(int[] rooms, int[] missions, int expected)
    {
        var actual = F581_FindExit.FindExit(rooms, missions);
        Assert.Equal(expected, actual);
    }
}
