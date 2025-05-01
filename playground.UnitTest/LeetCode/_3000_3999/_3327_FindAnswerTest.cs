using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3327_FindAnswerTest
{
    [Theory]
    [InlineData(new int[] { -1, 0, 0, 1, 1, 2 }, "aababa", new bool[] { true, true, false, true, true, true })]
    [InlineData(new int[] { -1, 0, 0, 0, 0 }, "aabcb", new bool[] { true, true, true, true, true })]
    public void RemainingMethods(int[] parent, string s, bool[] expected)
    {
        var actual = new _3327_FindAnswer().FindAnswer(parent, s);
        Assert.Equal(expected, actual);
    }
}
