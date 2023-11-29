using playground.Intervals;

namespace playground.UnitTest.Intervals;

public class IntervalTemplateTest
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[[]]", "[[]]")]
    [InlineData("[[4,6],[1,3]]", "[[1,3],[4,6]]")]
    [InlineData("[[4,6],[4,3]]", "[[4,3],[4,6]]")]
    public void SortInterval(string intervals, string expectedStr)
    {
        var actual = IntervalTemplate.SortInterval(intervals.To2dArr());
        Assert.Equal(expectedStr.To2dArr(), actual);
    }
}
