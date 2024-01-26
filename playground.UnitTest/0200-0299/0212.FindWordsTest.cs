namespace playground.UnitTest;

public class FindWordsTest0212
{
    [Theory]
    [InlineData($@"
        [[""o"",""a"",""a"",""n""]
        ,[""e"",""t"",""a"",""e""]
        ,[""i"",""h"",""k"",""r""]
        ,[""i"",""f"",""l"",""v""]]"
        , new string[] { "oath", "pea", "eat", "rain" }
        , new string[] { "eat", "oath" })]
    [InlineData($@"
        [[""a"",""b""]
        ,[""c"",""d""]]"
        , new string[] { "abcb" }
        , new string[] { })]
    public void FindWords(string board, string[] word, string[] expected)
    {
        var actual = FindWords0212.FindWords(board.To2dArr<char>(), word);
        Assert.Equal(expected.OrderBy(x => x), actual.OrderBy(x => x));
    }
}
