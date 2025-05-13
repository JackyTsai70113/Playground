namespace playground.UnitTest.LeetCode._3000_3999;

public class _3127_CanMakeSquareTest
{
    [Theory]
    [InlineData($@"[[""B"",""W"",""B""],[""B"",""W"",""W""],[""B"",""W"",""B""]]", true)]
    [InlineData($@"[[""B"",""W"",""B""],[""W"",""B"",""W""],[""B"",""W"",""B""]]", false)]
    [InlineData($@"[[""B"",""W"",""B""],[""B"",""W"",""W""],[""B"",""W"",""W""]]", true)]
    public void CanMakeSquare(string A, bool expected)
    {
        var actual = _3127_CanMakeSquare.CanMakeSquare(A.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
