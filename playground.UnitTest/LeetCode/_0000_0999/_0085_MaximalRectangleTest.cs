using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0085_MaximalRectangleTest
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
        var actual = _0085_MaximalRectangle.MaximalRectangle(A.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
