namespace playground.UnitTest;

public class MaximalSquareTest0221
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
        var actual = MaximalSquare0221.MaximalSquare(matrix.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
