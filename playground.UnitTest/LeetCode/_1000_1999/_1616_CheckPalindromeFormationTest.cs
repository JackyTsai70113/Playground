namespace playground.UnitTest;

public class _1616_CheckPalindromeFormationTest
{
    [Theory]
    [InlineData("x", "y", true)]
    [InlineData("abda", "acmc", false)]
    [InlineData("xbdef", "xecab", false)]
    [InlineData("ulacfd", "jizalu", true)]
    [InlineData("pvhmupgqeltozftlmfjjde", "yjgpzbezspnnpszebzmhvp", true)]
    [InlineData("aejbaalflrmkswrydwdkdwdyrwskmrlfqizjezd", "uvebspqckawkhbrtlqwblfwzfptanhiglaabjea", true)]
    public void CheckPalindromeFormation(string a, string b, bool expected)
    {
        var actual = _1616_CheckPalindromeFormation.CheckPalindromeFormation(a, b);
        Assert.Equal(expected, actual);
    }
}
