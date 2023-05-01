using playground.Design;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Design;

public class TrieTest
{
    [Theory]
    [InlineData("[Trie, insert, search]", "[[], [apple], [apple]]", "[null, null, true]")]
    [InlineData("[Trie, insert, search, search, startsWith, insert, search]", "[[], [apple], [apple], [app], [app], [app], [app]]","[null, null, true, false, true, null, true]")]
    public void Trie(string funcArr, string valArr, string expectedStr)
    {
        var funcs = funcArr.ToArr<string>();

        var vals = valArr.To2dArr<string>();

        TrieClass obj = new();
        var expected = expectedStr.ToArr<string>();
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
