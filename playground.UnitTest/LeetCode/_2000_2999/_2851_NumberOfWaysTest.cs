using playground.DynamicPrograming;
using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class NumberOfWaysTest
{
    [Theory]
    [InlineData("abcd", "cdab", 2, 2)]
    [InlineData("ababab", "ababab", 1, 2)]
    [InlineData("goxoq", "dfqgl", 244326024901249, 0)]
    [InlineData("pfly", "wvqr", 840550364246523, 0)]
    [InlineData("wkldv", "ldvwk", 854972569843185, 322134019)]
    [InlineData("rkjojlqlcjlujiahqqemdsldbjhcekhhwhyaqqimhwxsqrsyiaqhthebpubtssmcjlfybwvjiivsyutzudaxxkvgnekbvwtab", "cjlfybwvjiivsyutzudaxxkvgnekbvwtabrkjojlqlcjlujiahqqemdsldbjhcekhhwhyaqqimhwxsqrsyiaqhthebpubtssm", 113173393214299, 295976496)]
    public void NumberOfWays(string s, string t, long k, int expected)
    {
        var actual = _2851_NumberOfWays.NumberOfWays(s, t, k);
        Assert.Equal(expected, actual);
    }
}
