using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0752_OpenLockTest
{
    [Theory]
    [InlineData(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202", 6)]
    [InlineData(new string[] { "8888" }, "0009", 1)]
    [InlineData(new string[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" }, "8888", -1)]
    [InlineData(new string[] { "0000" }, "8888", -1)]
    public void OpenLock(string[] deadends, string target, int expected)
    {
        var actual = _0752_OpenLock.OpenLock(deadends, target);
        Assert.Equal(expected, actual);
    }
}