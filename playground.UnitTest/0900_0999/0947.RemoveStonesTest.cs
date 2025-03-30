namespace playground.UnitTest;

public class RemoveStonesTest0947
{
    [Theory]
    [InlineData("[[0,0],[0,1],[1,0],[1,2],[2,1],[2,2]]", 5)]
    [InlineData("[[0,0],[0,2],[1,1],[2,0],[2,2]]", 3)]
    [InlineData("[[1,1],[2,0],[2,2],[0,0],[0,2]]", 3)]
    [InlineData("[[0,0]]", 0)]
    public void RemoveStones(string A, int expected)
    {
        var actual = RemoveStones0947.RemoveStones(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
