namespace playground.UnitTest;

public class OpenLockTest0752
{
    [Theory]
    [InlineData(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202", 6)]
    [InlineData(new string[] { "8888" }, "0009", 1)]
    [InlineData(new string[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" }, "8888", -1)]
    [InlineData(new string[] { "0000" }, "8888", -1)]
    public void OpenLock(string[] deadends, string target, int expected)
    {
        var actual = OpenLock0752.OpenLock(deadends, target);
        Assert.Equal(expected, actual);
    }
}