using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class MinChangesTest
{
    [Theory]
    [InlineData("1001", 2)]
    [InlineData("10", 1)]
    [InlineData("0000", 0)]
    public void MinChanges(string s, int expected)
    {
        var actual = MinChangesClass.MinChanges(s);
        Assert.Equal(expected, actual);
    }
}
