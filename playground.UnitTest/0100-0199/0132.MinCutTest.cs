namespace playground.UnitTest;

public class MinCutTest0132
{
    [Theory]
    [InlineData("aab", 1)]
    [InlineData("a", 0)]
    [InlineData("ab", 1)]
    [InlineData("apjesgpsxoeiokmqmfgvjslcjukbqxpsobyhjpbgdfruqdkeiszrlmtwgfxyfostpqczidfljwfbbrflkgdvtytbgqalguewnhvvmcgxboycffopmtmhtfizxkmeftcucxpobxmelmjtuzigsxnncxpaibgpuijwhankxbplpyejxmrrjgeoevqozwdtgospohznkoyzocjlracchjqnggbfeebmuvbicbvmpuleywrpzwsihivnrwtxcukwplgtobhgxu", 239)]
    public void MinCut(string s, int expected)
    {
        var actual = MinCut0132.MinCut(s);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("aab", 1)]
    [InlineData("a", 0)]
    [InlineData("ab", 1)]
    [InlineData("apjesgpsxoeiokmqmfgvjslcjukbqxpsobyhjpbgdfruqdkeiszrlmtwgfxyfostpqczidfljwfbbrflkgdvtytbgqalguewnhvvmcgxboycffopmtmhtfizxkmeftcucxpobxmelmjtuzigsxnncxpaibgpuijwhankxbplpyejxmrrjgeoevqozwdtgospohznkoyzocjlracchjqnggbfeebmuvbicbvmpuleywrpzwsihivnrwtxcukwplgtobhgxu", 239)]
    public void MinCut2(string s, int expected)
    {
        var actual = MinCut0132.MinCut2(s);
        Assert.Equal(expected, actual);
    }
}
