namespace playground.UnitTest.LeetCode._3000_3999;

public class _3093_StringIndicesTest
{
    [Theory]
    [InlineData(new string[] { "abcd", "bcd", "xbcd" }, new string[] { "cd", "bcd", "xyz" }, new int[] { 1, 1, 1 })]
    [InlineData(new string[] { "abcdefgh", "poiuygh", "ghghgh" }, new string[] { "gh", "acbfgh", "acbfegh" }, new int[] { 2, 0, 2 })]
    public void StringIndices(string[] wordsContainer, string[] wordsQuery, int[] expected)
    {
        var actual = _3093_StringIndices.StringIndices(wordsContainer, wordsQuery);
        Assert.Equal(expected, actual);
    }
}
