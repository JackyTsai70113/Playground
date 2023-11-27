namespace playground.UnitTest;

public class LexicographicallySmallestArrayTest
{
    [Theory]
    [InlineData("[1,5,3,9,8]", 2, "[1,3,5,8,9]")]
    [InlineData("[1,7,6,18,2,1]", 3, "[1,6,7,18,1,2]")]
    [InlineData("[1,7,28,19,10]", 3, "[1,7,28,19,10]")]
    public void LexicographicallySmallestArray(string A, int limit, string expected)
    {
        var actual = LexicographicallySmallestArray_2948.LexicographicallySmallestArray(A.ToArr(), limit);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
