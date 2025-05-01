using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0079_ExistTest
{
    [Theory]
    [InlineData($@"[[""A"",""B"",""C"",""E""],[""S"",""F"",""C"",""S""],[""A"",""D"",""E"",""E""]]", "ABCCED", true)]
    [InlineData($@"[[""A"",""B"",""C"",""E""],[""S"",""F"",""C"",""S""],[""A"",""D"",""E"",""E""]]", "SEE", true)]
    [InlineData($@"[[""A"",""B"",""C"",""E""],[""S"",""F"",""C"",""S""],[""A"",""D"",""E"",""E""]]", "ABCB", false)]
    public void Exist(string board, string word, bool expected)
    {
        var actual = _0079_Exist.Exist(board.To2dArr<char>(), word);
        Assert.Equal(expected, actual);
    }
}
