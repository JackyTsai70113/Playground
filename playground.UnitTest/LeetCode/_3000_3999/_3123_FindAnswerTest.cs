using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3123_FindAnswerTest
{
    [Theory]
    [InlineData(6, "[[0,1,4],[0,2,1],[1,3,2],[1,4,3],[1,5,1],[2,3,1],[3,5,3],[4,5,2]]", new bool[] { true, true, true, false, true, true, true, false })]
    [InlineData(4, "[[2,0,1],[0,1,1],[0,3,4],[3,2,2]]", new bool[] { true, false, false, true })]
    public void FindAnswer(int n, string edges, bool[] expected)
    {
        var actual = _3123_FindAnswer.FindAnswer(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
