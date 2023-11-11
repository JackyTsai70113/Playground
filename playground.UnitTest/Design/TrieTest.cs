using playground.Design;

namespace playground.UnitTest.Design;

public class TrieTest
{
    [Theory]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [\"apple\"], [\"apple\"]]", "[null,null,true]")]
    [InlineData(new string[] { "Trie", "insert", "startsWith" }, "[[], [\"apple\"], [\"pple\"]]", "[null,null,false]")]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [\"apple\"], [\"app\"]]", "[null,null,false]")]
    [InlineData(new string[] { "Trie", "insert", "search" }, "[[], [\"apple\"], [\"b\"]]", "[null,null,false]")]
    [InlineData(new string[] { "Trie", "insert", "search", "search", "startsWith", "insert", "search" }, "[[], [\"apple\"], [\"apple\"], [\"app\"], [\"app\"], [\"app\"], [\"app\"]]", "[null,null,true,false,true,null,true]")]
    public void Trie(string[] functions, string valArr, string expectedStr)
    {
        var vals = valArr.To2dArr<string>();
        var expected = expectedStr.ToArr<bool?>();
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
                    Assert.Equal(expected[i].Value, trie.Search(vals[i][0]));
                    break;
                case "startsWith":
                    Assert.Equal(expected[i].Value, trie.StartsWith(vals[i][0]));
                    break;
                default:
                    break;
            }
        }
    }
}