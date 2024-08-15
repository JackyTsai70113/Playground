namespace playground.UnitTest.Other;

public class MovePuzzleTest
{
    [Theory]
    [InlineData("[[1,1,2],[3,3,2],[4,4,0]]", "[[1,1,2],[3,3,2],[4,4,0]]", new char[] { })]
    [InlineData("[[1,1,2],[3,3,0],[4,4,2]]", "[[1,1,2],[3,3,2],[4,4,0]]", new char[] { 'D' })]
    [InlineData("[[1,0,2],[1,3,4],[2,3,4]]", "[[1,1,2],[3,3,2],[4,4,0]]", new char[] { 'L', 'D', 'R', 'D', 'L', 'U', 'R', 'D', 'R', 'U', 'L', 'L', 'D', 'R', 'R' })]
    [InlineData("[[4,1,2],[3,2,0],[3,4,1]]", "[[1,1,2],[3,3,2],[4,4,0]]", new char[] { 'L', 'L', 'U', 'R', 'R', 'D', 'D', 'L', 'L', 'U', 'R', 'R', 'U', 'L', 'D', 'D', 'R' })]
    public void MovePuzzle(string A, string B, char[] expected)
    {
        var actuals = new MovePuzzleClass().MovePuzzle(A.To2dArr(), B.To2dArr());
        var res = false;
        foreach (var actual in actuals)
        {
            if (actual.SequenceEqual(expected))
            {
                res = true;
                break;
            }
        }
        Assert.True(res);
    }
}
