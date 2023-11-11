namespace playground.UnitTest.PriorityQueue;

public class MaxIncreasingGroupsTest
{
    [Theory]
    [InlineData("[1,2,5]", 3)]
    [InlineData("[2,1,2]", 2)]
    [InlineData("[1,1]", 1)]
    public void MaxIncreasingGroups(string usageLimitsStr, int expected)
    {
        var actual = MaxIncreasingGroupsClass.MaxIncreasingGroups(usageLimitsStr.ToArr<int>().ToList());
        Assert.Equal(expected, actual);
    }
}
