using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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
