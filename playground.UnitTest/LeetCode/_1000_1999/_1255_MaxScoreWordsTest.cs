namespace playground.UnitTest;

public class _1255_MaxScoreWordsTest
{
    [Theory]
    [InlineData(new string[] { "dog", "cat", "dad", "good" }, new char[] { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' }, new int[] { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 23)]
    [InlineData(new string[] { "xxxz", "ax", "bx", "cx" }, new char[] { 'z', 'a', 'b', 'c', 'x', 'x', 'x' }, new int[] { 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10 }, 27)]
    [InlineData(new string[] { "leetcode" }, new char[] { 'l', 'e', 't', 'c', 'o', 'd' }, new int[] { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, 0)]
    public void MaxScoreWords(string[] words, char[] letters, int[] score, int expected)
    {
        var actual = _1255_MaxScoreWords.MaxScoreWords(words, letters, score);
        Assert.Equal(expected, actual);
    }
}
