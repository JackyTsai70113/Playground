using playground._0700_0799;

namespace playground.UnitTest._0700_0799;

public class _0799_ChampagneTowerTest
{
    [Theory]
    [InlineData(1, 1, 1, 0.00000)]
    [InlineData(2, 1, 1, 0.50000)]
    [InlineData(100000009, 33, 17, 1.00000)]
    public void ChampagneTower(int poured, int query_row, int query_glass, double expected)
    {
        var actual = _0799_ChampagneTower.ChampagneTower(poured, query_row, query_glass);
        Assert.Equal(expected, actual);
    }
}
