using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0295_MedianFinderTest
{
    [Theory]
    [InlineData(new string[] { "MedianFinder", "addNum", "addNum", "findMedian", "addNum", "findMedian" }, "[[],[1],[2],[],[3],[]]", "[null,null,null,1.50000,null,2.00000]")]
    public void MedianFinder(string[] functions, string valStr, string expectedStr)
    {
        var vals = valStr.To2dArr();
        var expected = expectedStr.ToArr<double?>();
        _0295_MedianFinder obj = new();
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "addNum":
                    obj.AddNum(vals[i][0]);
                    break;
                case "findMedian":
                    var median = obj.FindMedian();
                    Assert.Equal(expected[i].Value, median);
                    break;
                default:
                    break;
            }
        }
    }
}
