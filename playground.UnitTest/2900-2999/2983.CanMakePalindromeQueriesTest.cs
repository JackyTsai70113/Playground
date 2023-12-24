namespace playground.UnitTest;

public class CanMakePalindromeQueriesTest2983
{
    [Theory]
    [InlineData("abcabc", "[[1,1,3,5],[0,2,5,5]]", "[true, true]")]
    [InlineData("abbcdecbba", "[[0,2,7,9]]", "[false]")]
    [InlineData("acbcab", "[[1,2,4,5]]", "[true]")]
    public void CanMakePalindromeQueries(string s, string A, string expected)
    {
        var actual = CanMakePalindromeQueries2983.CanMakePalindromeQueries(s, A.To2dArr());
        Assert.Equal(expected.ToArr<bool>(), actual);
    }
}
