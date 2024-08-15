namespace playground.UnitTest;

public class SlidingPuzzleTest0773
{
    [Theory]
    [InlineData("[[1,2,3],[4,0,5]]", 1)]
    [InlineData("[[1,2,3],[5,4,0]]", -1)]
    [InlineData("[[4,1,2],[5,0,3]]", 5)]
    public void SlidingPuzzle(string A, int expected)
    {
        var actual = new SlidingPuzzle0773().SlidingPuzzle(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
