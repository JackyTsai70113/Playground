namespace playground.UnitTest;

public class MinimumSubstringsInPartitionTest3144
{
    [Theory]
    [InlineData("fabccddg", 3)]
    [InlineData("abababaccddb", 2)]
    public void MinimumSubstringsInPartition(string s, int expected)
    {
        var actual = MinimumSubstringsInPartition3144.MinimumSubstringsInPartition(s);
        Assert.Equal(expected, actual);
    }
}
