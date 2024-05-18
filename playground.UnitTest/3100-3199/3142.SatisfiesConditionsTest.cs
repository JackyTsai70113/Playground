namespace playground.UnitTest;

public class SatisfiesConditionsTest3142
{
    [Theory]
    [InlineData("[[1,0,2],[1,0,2]]", true)]
    [InlineData("[[1,1,1],[0,0,0]]", false)]
    [InlineData("[[1],[2],[3]]", false)]
    public void SatisfiesConditions(string A, bool expected)
    {
        var actual = SatisfiesConditions3142.SatisfiesConditions(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
