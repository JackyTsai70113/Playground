using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0966_SpellcheckerTest
{
    [Theory]
    [InlineData(new string[] { "KiTe", "kite", "hare", "Hare" }, new string[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" }, new string[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" })]
    [InlineData(new string[] { "ae", "aa" }, new string[] { "UU" }, new string[] { "ae" })]
    [InlineData(new string[] { "yellow" }, new string[] { "YellOw" }, new string[] { "yellow" })]
    public void Spellchecker(string[] wordlist, string[] queries, string[] expected)
    {
        var actual = _0966_Spellchecker.Spellchecker(wordlist, queries);
        Assert.Equal(expected, actual);
    }
}
