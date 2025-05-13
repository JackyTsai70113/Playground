namespace playground.UnitTest.LeetCode._1000_1999;

public class _1685_GetSumAbsoluteDifferencesTest
{
    [Theory]
    [InlineData("[2,3,5]", "[4,3,5]")]
    [InlineData("[1,4,6,8,10]", "[24,15,13,15,21]")]
    public void GetSumAbsoluteDifferences(string A, string expected)
    {
        var actual = _1685_GetSumAbsoluteDifferences.GetSumAbsoluteDifferences(A.ToArr());
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
