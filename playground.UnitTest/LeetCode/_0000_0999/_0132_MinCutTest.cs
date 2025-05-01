using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0132_MinCutTest
{
    [Theory]
    [InlineData("aab", 1)]
    [InlineData("a", 0)]
    [InlineData("ab", 1)]
    [InlineData("apjesgpsxoeiokmqmfgvjslcjukbqxpsobyhjpbgdfruqdkeiszrlmtwgfxyfostpqczidfljwfbbrflkgdvtytbgqalguewnhvvmcgxboycffopmtmhtfizxkmeftcucxpobxmelmjtuzigsxnncxpaibgpuijwhankxbplpyejxmrrjgeoevqozwdtgospohznkoyzocjlracchjqnggbfeebmuvbicbvmpuleywrpzwsihivnrwtxcukwplgtobhgxu", 239)]
    public void MinCut(string s, int expected)
    {
        var actual = _0132_MinCut.MinCut(s);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("aab", 1)]
    [InlineData("a", 0)]
    [InlineData("ab", 1)]
    [InlineData("apjesgpsxoeiokmqmfgvjslcjukbqxpsobyhjpbgdfruqdkeiszrlmtwgfxyfostpqczidfljwfbbrflkgdvtytbgqalguewnhvvmcgxboycffopmtmhtfizxkmeftcucxpobxmelmjtuzigsxnncxpaibgpuijwhankxbplpyejxmrrjgeoevqozwdtgospohznkoyzocjlracchjqnggbfeebmuvbicbvmpuleywrpzwsihivnrwtxcukwplgtobhgxu", 239)]
    public void MinCut2(string s, int expected)
    {
        var actual = _0132_MinCut.MinCut2(s);
        Assert.Equal(expected, actual);
    }
}
