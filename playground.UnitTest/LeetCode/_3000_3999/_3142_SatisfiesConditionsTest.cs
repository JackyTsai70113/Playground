namespace playground.UnitTest.LeetCode._3000_3999;

public class _3142_SatisfiesConditionsTest
{
    [Theory]
    [InlineData("[[1,0,2],[1,0,2]]", true)]
    [InlineData("[[1,1,1],[0,0,0]]", false)]
    [InlineData("[[1],[2],[3]]", false)]
    public void SatisfiesConditions(string A, bool expected)
    {
        var actual = _3142_SatisfiesConditions.SatisfiesConditions(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
