using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0208_TrieTest
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
        _0208_Trie trie = new();
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
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
