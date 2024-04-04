namespace playground.UnitTest;

public class PartitionStringTest2405
{
    [Theory]
    [InlineData("abacaba", 4)]
    [InlineData("ssssss", 6)]
    public void PartitionString(string s, int expected)
    {
        var actual = PartitionString2405.PartitionString(s);
        Assert.Equal(expected, actual);
    }
}
