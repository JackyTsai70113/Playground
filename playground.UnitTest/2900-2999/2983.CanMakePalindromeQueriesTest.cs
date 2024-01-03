namespace playground.UnitTest;

public class CanMakePalindromeQueriesTest2983
{
    [Theory]
    [InlineData("abcabc", "[[1,1,3,5],[0,2,5,5]]", "[true, true]")]
    [InlineData("abcabd", "[[1,1,3,5]]", "[false]")]
    [InlineData("abbcdecbba", "[[0,2,7,9]]", "[false]")]
    [InlineData("acbcab", "[[1,2,4,5]]", "[true]")]
    [InlineData("odaxusaweuasuoeudxwa", "[[0,5,10,14]]", "[false]")]
    [InlineData("cbbbbc", "[[1,1,5,5]]", "[true]")]
    [InlineData("daeaed", "[[0,2,3,3]]", "[true]")]
    [InlineData("stgjtzqwgkuadjgqugkwdtzast", "[[5,10,13,23]]", "[false]")]
    [InlineData("baabbdab", "[[0,1,4,4]]", "[false]")]
    [InlineData("aeae", "[[1,1,2,3],[1,1,3,3]]", "[true,false]")]
    [InlineData("cdbdbc", "[[1,2,3,3]]", "[true]")]
    [InlineData("accacaca", "[[2,3,5,6],[1,1,7,7],[0,1,5,6],[0,2,6,6]]", "[true,false,false,false]")]
    [InlineData("baabbbbb", "[[0,3,5,6]]", "[false]")]
    public void CanMakePalindromeQueries(string s, string A, string expected)
    {
        var actual = CanMakePalindromeQueries2983.CanMakePalindromeQueries(s, A.To2dArr());
        Assert.Equal(expected.ToArr<bool>(), actual);
    }
}
