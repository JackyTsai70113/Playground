using playground.DirectedGraph;

namespace playground.UnitTest.DirectedWeightedGraph;

public class NumBusesToDestinationTest
{
    [Theory]
    [InlineData("[[1,2,7],[3,6,7]]", 1, 6, 2)]
    [InlineData("[[7,12],[4,5,15],[6],[15,19],[9,12,13]]", 15, 12, -1)]
    public void NumBusesToDestination(string array, int source, int target, int expected){
        var routes = array.To2dArr<int>();
        var actual = NumBusesToDestinationClass.NumBusesToDestination(routes, source, target);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[[1,2,7],[3,6,7]]", 1, 6, 2)]
    [InlineData("[[7,12],[4,5,15],[6],[15,19],[9,12,13]]", 15, 12, -1)]
    public void NumBusesToDestination2(string array, int source, int target, int expected){
        var routes = array.To2dArr<int>();
        var actual = NumBusesToDestinationClass.NumBusesToDestination2(routes, source, target);
        Assert.Equal(expected, actual);
    }
}
