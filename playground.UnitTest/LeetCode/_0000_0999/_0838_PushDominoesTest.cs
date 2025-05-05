using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0838_PushDominoesTest
{
    [Theory]
    [InlineData("RR.L", "RR.L")]
    [InlineData("RR.R.", "RRRRR")]
    [InlineData(".L.R...LR..L..", "LL.RR.LLRRLL..")]
    public void PushDominoes(string s, string expected)
    {
        var actual = _0838_PushDominoes.PushDominoes(s);
        Assert.Equal(expected, actual);
    }
}
