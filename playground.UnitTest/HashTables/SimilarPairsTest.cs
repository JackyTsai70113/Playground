using playground.HashTables;

namespace playground.UnitTest.HashTables;

public class SimilarPairsTest
{
    [Theory]
    [InlineData(new string[] { "aba", "aabb", "abcd", "bac", "aabc" }, 2)]
    [InlineData(new string[] { "aabb", "ab", "ba" }, 3)]
    [InlineData(new string[] { "nba", "cba", "dba" }, 0)]
    public void SimilarPairs(string[] words, int expected)
    {
        var actual = SimilarPairsClass.SimilarPairs(words);
        Assert.Equal(expected, actual);
    }
}
