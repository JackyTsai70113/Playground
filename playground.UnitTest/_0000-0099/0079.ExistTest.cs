namespace playground.UnitTest;

public class ExistTest0079
{
    [Theory]
    [InlineData($@"[[""A"",""B"",""C"",""E""],[""S"",""F"",""C"",""S""],[""A"",""D"",""E"",""E""]]", "ABCCED", true)]
    [InlineData($@"[[""A"",""B"",""C"",""E""],[""S"",""F"",""C"",""S""],[""A"",""D"",""E"",""E""]]", "SEE", true)]
    [InlineData($@"[[""A"",""B"",""C"",""E""],[""S"",""F"",""C"",""S""],[""A"",""D"",""E"",""E""]]", "ABCB", false)]
    public void Exist(string board, string word, bool expected)
    {
        var actual = Exist0079.Exist(board.To2dArr<char>(), word);
        Assert.Equal(expected, actual);
    }
}
