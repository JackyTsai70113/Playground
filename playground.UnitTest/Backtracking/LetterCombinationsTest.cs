using playground.Backtracking;

namespace playground.UnitTest.Backtracking;

public class LetterCombinationsTest
{
    [Theory]
    [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
    [InlineData("", new string[] { })]
    [InlineData("2", new string[] { "a", "b", "c" })]
    [InlineData("3", new string[] { "d", "e", "f" })]
    [InlineData("4", new string[] { "g", "h", "i" })]
    [InlineData("5", new string[] { "j", "k", "l" })]
    [InlineData("6", new string[] { "m", "n", "o" })]
    [InlineData("7", new string[] { "p", "q", "r", "s" })]
    [InlineData("8", new string[] { "t", "u", "v" })]
    [InlineData("9", new string[] { "w", "x", "y", "z" })]
    public void LetterCombinations(string digits, string[] expected)
    {
        var actual = LetterCombinationsClass.LetterCombinations(digits);
        Assert.True(expected.SequenceEqual(actual));
    }
}
