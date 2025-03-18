using playground._1000_1099;

namespace playground.UnitTest._1000_1099;

public class _1079_NumTilePossibilitiesTest
{
    [Theory]
    [InlineData("AAB", 8)]
    [InlineData("AAABBC", 188)]
    [InlineData("V", 1)]
    public void NumTilePossibilities(string tiles, int expected)
    {
        var actual = _1079_NumTilePossibilities.NumTilePossibilities(tiles);
        Assert.Equal(expected, actual);
    }
}
