namespace playground.UnitTest;

public class _3169_CountDaysTest
{
    [Theory]
    [InlineData(10, "[[5,7],[1,3],[9,10]]", 2)]
    [InlineData(5, "[[2,4],[1,3]]", 1)]
    [InlineData(57, "[[3,49],[23,44],[21,56],[26,55],[23,52],[2,9],[1,48],[3,31]]", 1)]
    public void CountDays(int days, string A, int expected)
    {
        var actual = _3169_CountDays.CountDays(days, A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
