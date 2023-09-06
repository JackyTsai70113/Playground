using playground.Strings;

namespace playground.UnitTest.Strings;

public class FullJustifyTest
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
        var actual = FullJustifyClass.FullJustify(words, maxWidth);
        Assert.Equal(expected, actual);
    }
}
