using playground.Design;

namespace playground.UnitTest.Design;

public class TrieTest
{
    [Theory]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [apple], [apple]]", new string[] { null, null, "true" })]
    [InlineData(new string[] { "Trie", "insert", "startsWith" }, "[[], [apple], [pple]]", new string[] { null, null, "false" })]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [apple], [app]]", new string[] { null, null, "false" })]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [apple], [b]]", new string[] { null, null, "false" })]
    [InlineData(new string[] { "Trie", "insert", "search", "search", "startsWith", "insert", "search" }, "[[], [apple], [apple], [app], [app], [app], [app]]", new string[] { null, null, "true", "false", "true", null, "true" })]
    public void Trie(string[] functions, string valArr, string[] expected)
    {
        var vals = valArr.To2dArr<string>();
        TrieClass trie = new();
        for (int i = 0; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "Trie":
                    trie = new TrieClass();
                    break;
                case "insert":
                    trie.Insert(vals[i][0]);
                    break;
                case "search":
                    Assert.Equal(expected[i], trie.Search(vals[i][0]).ToString().ToLower());
                    break;
                case "startsWith":
                    Assert.Equal(expected[i], trie.StartsWith(vals[i][0]).ToString().ToLower());
                    break;
                default:
                    break;
            }
        }
    }
}