using playground.Algorithms;

namespace playground.UnitTest.Algorithms;

public class ZAlgorithmTest
{
    [Theory]
    [InlineData("", new int[] { })]
    [InlineData("a", new int[] { 0 })]
    [InlineData("aaaaa", new int[] { 0, 4, 3, 2, 1 })]
    [InlineData("abcde", new int[] { 0, 0, 0, 0, 0 })]
    [InlineData("aabaacd", new int[] { 0, 1, 0, 2, 1, 0, 0 })]
    [InlineData("abababab", new int[] { 0, 0, 6, 0, 4, 0, 2, 0 })]
    [InlineData("abacaba", new int[] { 0, 0, 1, 0, 3, 0, 1 })]
    [InlineData("aabcaabxaaaz", new int[] { 0, 1, 0, 0, 3, 1, 0, 0, 2, 2, 1, 0 })]
    [InlineData("abcabcabc", new int[] { 0, 0, 0, 6, 0, 0, 3, 0, 0 })]
    public void ZFunction_ReturnsExpectedResults(string s, int[] expected)
    {
        var result = ZAlgorithm.ZFunction(s);
        Assert.Equal(expected, result);
    }
}