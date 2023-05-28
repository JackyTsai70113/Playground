using playground.Design;

namespace playground.UnitTest.Design;

public class TrieTest
{
    [Theory]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [apple], [apple]]", new string[] { null, null, "true" })]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [apple], [app]]", new string[] { null, null, "false" })]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [apple], [b]]", new string[] { null, null, "false" })]
    [InlineData(new string[] { "Trie", "insert", "search", "search", "startsWith", "insert", "search" }, "[[], [apple], [apple], [app], [app], [app], [app]]", new string[] { null, null, "true", "false", "true", null, "true" })]
    public void Trie(string[] funcs, string valArr, string[] expected)
    {
        var vals = valArr.To2dArr<string>();
        TrieClass obj = new();
        for (int i = 0; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "Trie":
                    obj = new TrieClass();
                    break;
                case "insert":
                    obj.Insert(vals[i][0]);
                    break;
                case "search":
                    Assert.Equal(expected[i], obj.Search(vals[i][0]).ToString().ToLower());
                    break;
                case "startsWith":
                    Assert.Equal(expected[i], obj.StartsWith(vals[i][0]).ToString().ToLower());
                    break;
                default:
                    break;
            }
        }
    }
}
