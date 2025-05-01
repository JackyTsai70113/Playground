using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2405_PartitionStringTest
{
    [Theory]
    [InlineData("abacaba", 4)]
    [InlineData("ssssss", 6)]
    public void PartitionString(string s, int expected)
    {
        var actual = _2405_PartitionString.PartitionString(s);
        Assert.Equal(expected, actual);
    }
}
