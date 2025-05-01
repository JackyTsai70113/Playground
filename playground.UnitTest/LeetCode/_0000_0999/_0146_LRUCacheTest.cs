using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0146_LRUCacheTest
{
    [Theory]
    [InlineData(
        new string[] { "LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get" },
        "[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]",
        "[null, null, null, 1, null, -1, null, -1, 3, 4]")]
    [InlineData(
        new string[] { "LRUCache", "put", "put", "get" },
        "[[2], [1, 1], [1, 2], [1]]",
        "[null, null, null, 2]")]
    public void LRUCache(string[] funcs, string valStr, string expected)
    {
        var vals = valStr.To2dArr();
        var expectedArr = expected.ToArr<int?>();
        _0146_LRUCache lruCache = new(0);
        for (int i = 0; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "LRUCache":
                    lruCache = new(vals[i][0]);
                    break;
                case "get":
                    var val = lruCache.Get(vals[i][0]);
                    Assert.Equal(expectedArr[i], val);
                    break;
                case "put":
                    lruCache.Put(vals[i][0], vals[i][1]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
