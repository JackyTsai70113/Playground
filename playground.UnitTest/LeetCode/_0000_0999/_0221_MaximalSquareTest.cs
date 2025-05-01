using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0221_MaximalSquareTest
{
    [Theory]
    [InlineData($@"
        [[""1"",""0"",""1"",""0"",""0""]
        ,[""1"",""0"",""1"",""1"",""1""]
        ,[""1"",""1"",""1"",""1"",""1""]
        ,[""1"",""0"",""0"",""1"",""0""]]", 4)]
    [InlineData($@"
        [[""0"",""1""]
        ,[""1"",""0""]]", 1)]
    [InlineData($@"
        [[""0""]]",0)]
    [InlineData($@"
        [[""1"",""1""]
        ,[""1"",""1""]]", 4)]
    public void MaxProfitWithFee(string matrix, int expected)
    {
        var actual = _0221_MaximalSquare.MaximalSquare(matrix.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
