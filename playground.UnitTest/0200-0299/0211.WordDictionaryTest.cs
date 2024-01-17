namespace playground.UnitTest;

public class WordDictionaryTest0211
{
    [Theory]
    [InlineData(new string[] { "WordDictionary", "addWord", "addWord", "addWord", "search", "search", "search", "search" }, "[[],[\"bad\"],[\"dad\"],[\"mad\"],[\"pad\"],[\"bad\"],[\".ad\"],[\"b..\"]]", new string[] { null, null, null, null, "false", "true", "true", "true" })]
    [InlineData(new string[] { "WordDictionary", "addWord", "addWord", "addWord", "addWord", "search", "search", "addWord", "search", "search", "search", "search", "search", "search" }, "[[],[\"at\"],[\"and\"],[\"an\"],[\"add\"],[\"a\"],[\".at\"],[\"bat\"],[\".at\"],[\"an.\"],[\"a.d.\"],[\"b.\"],[\"a.d\"],[\".\"]]", new string[] { null, null, null, null, null, "false", "false", null, "true", "true", "false", "false", "true", "false" })]
    public void WordDictionary(string[] funcs, string b, string[] expected)
    {
        var vals = b.To2dArr<string>();
        WordDictionary0211 obj = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "addWord":
                    obj.AddWord(vals[i][0]);
                    break;
                case "search":
                    Assert.Equal(bool.Parse(expected[i]), obj.Search(vals[i][0]));
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
