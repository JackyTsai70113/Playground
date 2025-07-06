using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0211_WordDictionaryTest
{
    [Theory]
    [InlineData(new string[] { "WordDictionary", "addWord", "addWord", "addWord", "search", "search", "search", "search" }, new string[] { "", "bad", "dad", "mad", "pad", "bad", ".ad", "b.." }, new object[] { null, null, null, null, false, true, true, true })]
    [InlineData(new string[] { "WordDictionary", "addWord", "addWord", "addWord", "addWord", "search", "search", "addWord", "search", "search", "search", "search", "search", "search" }, new string[] { "", "at", "and", "an", "add", "a", ".at", "bat", ".at", "an.", "a.d.", "b.", "a.d", "." }, new object[] { null, null, null, null, null, false, false, null, true, true, false, false, true, false })]
    public void WordDictionary(string[] functions, string[] vals, object[] expected)
    {
        _0211_WordDictionary obj = new();
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "addWord":
                    obj.AddWord(vals[i]);
                    break;
                case "search":
                    Assert.Equal(expected[i], obj.Search(vals[i]));
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
