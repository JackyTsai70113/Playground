namespace playground.UnitTest9;

public class MaximalRectangleTest0085
{
    [Theory]
    [InlineData($@"
        [[""1"",""0"",""1"",""0"",""0""]
        ,[""1"",""0"",""1"",""1"",""1""]
        ,[""1"",""1"",""1"",""1"",""1""]
        ,[""1"",""0"",""0"",""1"",""0""]]"
        , 6)]
    [InlineData($@"
        [[""0"",""0"",""1"",""0""]
        ,[""0"",""0"",""1"",""0""]
        ,[""0"",""0"",""1"",""1""]
        ,[""0"",""1"",""1"",""1""]
        ,[""0"",""1"",""1"",""1""]
        ,[""1"",""1"",""1"",""1""]]"
        , 9)]
    [InlineData($@"[[""0""]]", 0)]
    [InlineData($@"[[""1""]]", 1)]
    public void MaximalRectangle(string A, int expected)
    {
        var actual = MaximalRectangle0085.MaximalRectangle(A.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
