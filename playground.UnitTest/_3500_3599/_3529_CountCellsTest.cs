using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3529_CountCellsTest
{
    [Theory]
    [InlineData($@"
        [[""a"",""a"",""c"",""c""]
        ,[""b"",""b"",""b"",""c""]
        ,[""a"",""a"",""b"",""a""]
        ,[""c"",""a"",""a"",""c""]
        ,[""a"",""a"",""b"",""a""]]"
        , "abaca", 1)]
    [InlineData($@"
        [[""c"",""a"",""a"",""a""]
        ,[""a"",""a"",""b"",""a""]
        ,[""b"",""b"",""a"",""a""]
        ,[""a"",""a"",""b"",""a""]]"
        , "aba", 4)]
    [InlineData($@"
        [[""a""]]"
        , "a", 1)]
    [InlineData($@"
        [[""x"",""e""]
        ,[""e"",""t""]
        ,[""e"",""c""]
        ,[""y"",""e""]
        ,[""n"",""c""]]"
        , "e", 4)]
    [InlineData($@"
        [[""y"",""e"",""e"",""b"",""e"",""t""]
        ,[""s"",""x"",""e"",""e"",""e"",""b""]
        ,[""e"",""e"",""e"",""e"",""b"",""o""]]"
        , "eeb", 4)]
    public void CountCells(string A, string pattern, int expected)
    {
        var actual = _3529_CountCells.CountCells(A.To2dArr<char>(), pattern);
        Assert.Equal(expected, actual);
    }
}
