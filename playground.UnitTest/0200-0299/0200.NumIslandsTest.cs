namespace playground.UnitTest;

public class NumIslandsTest0200
{
    [Theory]
    [InlineData($@"
        [[""1"",""1"",""1"",""1"",""0""]
        ,[""1"",""1"",""0"",""1"",""0""]
        ,[""1"",""1"",""0"",""0"",""0""]
        ,[""0"",""0"",""0"",""0"",""0""]]", 1)]
    [InlineData($@"
        [[""1"",""1"",""0"",""0"",""0""]
        ,[""1"",""1"",""0"",""0"",""0""]
        ,[""0"",""0"",""1"",""0"",""0""]
        ,[""0"",""0"",""0"",""1"",""1""]]", 3)]
    public void NumIslands(string A, int expected)
    {
        var actual = NumIslands0200.NumIslands(A.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
