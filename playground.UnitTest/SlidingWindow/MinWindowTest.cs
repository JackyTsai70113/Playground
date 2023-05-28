using playground.SlidingWindow;

namespace playground.UnitTest.SlidingWindow;

public class MinWindowTest
{
    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("CODEBANC", "ABC", "BANC")]
    [InlineData("BANC", "ABC", "BANC")]
    public void MinWindow(string s, string t, string expected)
    {
        var actual = MinWindowClass.MinWindow(s, t);
        Assert.Equal(expected, actual);
    }
}
