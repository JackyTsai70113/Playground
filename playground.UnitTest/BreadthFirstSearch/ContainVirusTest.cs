using playground.BreadthFirstSearch;

namespace playground.UnitTest.BreadthFirstSearch;

public class ContainVirusTest
{
    [Theory]
    [InlineData("[[0,1,0,0,0,0,0,1],[0,1,0,0,0,0,0,1],[0,0,0,0,0,0,0,1],[0,0,0,0,0,0,0,0]]", 10)]
    [InlineData("[[1,1,1],[1,0,1],[1,1,1]]", 4)]
    [InlineData("[[1,1,1,0,0,0,0,0,0],[1,0,1,0,1,1,1,1,1],[1,1,1,0,0,0,0,0,0]]", 13)]
    [InlineData("[[1,0,0,0,0,0],[0,0,1,0,1,0],[0,0,0,0,1,0]]", 12)]
    [InlineData("[[0,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,1,0,0],[1,0,0,0,0,0,0,0,0,0],[0,0,1,0,0,0,1,0,0,0],[0,0,0,0,0,0,1,0,0,0],[0,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,0,1,0],[0,0,0,0,1,0,1,0,0,0],[0,0,0,0,0,0,0,0,0,0]]", 56)]
    public void ContainVirus(string A, int expected)
    {
        var actual = ContainVirusClass.ContainVirus(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
