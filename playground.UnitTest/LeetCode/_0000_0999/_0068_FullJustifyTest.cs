using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0068_FullJustifyTest
{
    [Theory]
    [InlineData(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16, new string[] {
        "This    is    an",
        "example  of text",
        "justification.  " })]
    [InlineData(new string[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16, new string[] {
        "What   must   be",
        "acknowledgment  ",
        "shall be        " })]
    [InlineData(new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" }, 20, new string[] {
        "Science  is  what we",
        "understand      well",
        "enough to explain to",
        "a  computer.  Art is",
        "everything  else  we",
        "do                  " })]
    [InlineData(new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "wea", "d" }, 20, new string[] {
        "Science  is  what we",
        "understand      well",
        "enough to explain to",
        "a  computer.  Art is",
        "everything  else wea",
        "d                   " })]
    public void FullJustify(string[] words, int maxWidth, string[] expected)
    {
        var actual = _0068_FullJustify.FullJustify(words, maxWidth);
        Assert.Equal(expected, actual);
    }
}
