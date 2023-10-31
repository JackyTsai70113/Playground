using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

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
        var actual = NumberOfWaysClass.NumberOfWays(s, t, k);
        Assert.Equal(expected, actual);
    }
}
