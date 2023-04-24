using playground.DirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DirectedGraph;

public class FindOrderTest
{
    [Theory]
    [InlineData(2, "[[1,0]]", new int[] { 0, 1 })]
    [InlineData(4, "[[1,0],[2,0],[3,1],[3,2]]", new int[] { 0, 2, 1, 3 })]
    [InlineData(1, "[]", new int[] { 0 })]
    public void FindOrder(int n, string arr, int[] expected)
    {
        var pre = arr.To2dArr<int>();

        var actual = FindOrderClass.FindOrder(n, pre);

        Assert.Equal(expected, actual);
    }
}
