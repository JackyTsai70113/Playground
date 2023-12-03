namespace playground.UnitTest;

public class FindPeaksTest_2951
{
    [Theory]
    [InlineData("[2,4,4]", "[]")]
    [InlineData("[1,4,3,8,5]", "[1,3]")]
    public void FindPeaks(string A, string expected)
    {
        var actual = FindPeaks_2951.FindPeaks(A.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
