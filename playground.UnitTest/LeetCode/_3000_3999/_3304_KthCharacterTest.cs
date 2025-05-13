using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3304_KthCharacterTest
{
    [Theory]
    [InlineData(5, 'b')]
    [InlineData(10, 'c')]
    public void CountOfSubstrings(int k, char expected)
    {
        var actual = _3304_KthCharacter.KthCharacter(k);
        Assert.Equal(expected, actual);
    }
}
