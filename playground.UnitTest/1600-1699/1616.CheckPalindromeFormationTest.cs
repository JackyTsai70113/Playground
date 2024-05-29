namespace playground.UnitTest;

public class CheckPalindromeFormationTest1616
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
        var actual = CheckPalindromeFormation1616.CheckPalindromeFormation(a, b);
        Assert.Equal(expected, actual);
    }
}
