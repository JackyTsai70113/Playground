using playground.UndirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UndirectGraph;

public class MakeConnectedTest
{

    [Theory]
    [InlineData(4, "[[0, 2], [0, 1], [1, 2]]", 1)]
    [InlineData(6, "[[0, 1], [0, 2], [0, 3], [1, 2], [1, 3]]", 2)]
    [InlineData(6, "[[0, 1], [0, 2], [0, 3], [1, 2]]", -1)]
    [InlineData(8, "[[0, 1], [0, 2], [0, 3], [1, 2], [1, 3], [2, 3], [4, 5]]", 3)]
    [InlineData(5, "[[0, 1], [2, 3]]", -1)]
    [InlineData(4, "[[0, 1], [0, 2]]", -1)]
    [InlineData(4, "[[0, 1], [2, 3]]", -1)]
    [InlineData(5, "[[0, 1], [0, 2], [2, 3]]", -1)]
    [InlineData(4, "[[0, 1], [0, 2], [1, 2]]", 1)]
    [InlineData(4, "[[0, 1], [0, 2], [2, 3]]", 0)]
    [InlineData(3, "[[0, 1], [0, 2], [1, 2]]", 0)]
    public void MakeConnected(int n, string str, int expected)
    {
        var arr = str.To2dArr<int>();

        int actual = MakeConnectedClass.MakeConnected(n, arr);

        Assert.Equal(expected, actual);
    }
}
