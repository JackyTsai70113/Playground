namespace playground.UnitTest;

public class StringIndicesTest3093
{
    [Theory]
    [InlineData(new string[] { "abcd", "bcd", "xbcd" }, new string[] { "cd", "bcd", "xyz" }, new int[] { 1, 1, 1 })]
    [InlineData(new string[] { "abcdefgh", "poiuygh", "ghghgh" }, new string[] { "gh", "acbfgh", "acbfegh" }, new int[] { 2, 0, 2 })]
    public void StringIndices(string[] wordsContainer, string[] wordsQuery, int[] expected)
    {
        var actual = StringIndices3093.StringIndices(wordsContainer, wordsQuery);
        Assert.Equal(expected, actual);
    }
}
