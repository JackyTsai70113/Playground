namespace playground.UnitTest;

public class SpellcheckerTest0966
{
    [Theory]
    [InlineData(new string[] { "KiTe", "kite", "hare", "Hare" }, new string[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" }, new string[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" })]
    [InlineData(new string[] { "ae", "aa" }, new string[] { "UU" }, new string[] { "ae" })]
    [InlineData(new string[] { "yellow" }, new string[] { "YellOw" }, new string[] { "yellow" })]
    public void Spellchecker(string[] wordlist, string[] queries, string[] expected)
    {
        var actual = Spellchecker0966.Spellchecker(wordlist, queries);
        Assert.Equal(expected, actual);
    }
}
