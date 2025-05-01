using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0200_NumIslandsTest
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
        var actual = _0200_NumIslands.NumIslands(A.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
