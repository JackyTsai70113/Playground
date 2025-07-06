using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3608_MinTimeTest
{
    public static IEnumerable<object[]> MinTimeTestData =>
        new List<object[]>
        {
            // 每個 object[] 數組對應一個測試案例的參數
            // 順序必須與 MinTimeTest 方法的參數順序一致：n, edges, k, expected
            new object[] { 2, new[] { new[] { 0, 1, 3 } }, 2, 3 },
            new object[] { 3, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 4 } }, 3, 4 },
            new object[] { 3, new[] { new[] { 0, 2, 5 } }, 2, 0 }
        };

    [Theory]
    [MemberData(nameof(MinTimeTestData))]
    public void MinTimeTest(int n, int[][] edges, int k, int expected)
    {
        var actual = _3608_MinTime.MinTime(n, edges, k);
        Assert.Equal(expected, actual);
    }
}
