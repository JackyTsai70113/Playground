namespace playground.UnitTest;

public class SimilarPairsTest2506
{
    [Theory]
    [InlineData(new string[] { "aba", "aabb", "abcd", "bac", "aabc" }, 2)]
    [InlineData(new string[] { "aabb", "ab", "ba" }, 3)]
    [InlineData(new string[] { "nba", "cba", "dba" }, 0)]
    public void SimilarPairs(string[] words, int expected)
    {
        var actual = SimilarPairs2506.SimilarPairs(words);
        Assert.Equal(expected, actual);
    }
}
