namespace playground.UnitTest.LeetCode._3000_3999;

public class _3144_MinimumSubstringsInPartitionTest
{
    [Theory]
    [InlineData("fabccddg", 3)]
    [InlineData("abababaccddb", 2)]
    public void MinimumSubstringsInPartition(string s, int expected)
    {
        var actual = _3144_MinimumSubstringsInPartition.MinimumSubstringsInPartition(s);
        Assert.Equal(expected, actual);
    }
}
