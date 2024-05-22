namespace playground.UnitTest;

public class PartitionTest0131
{
    [Theory]
    [InlineData("aab", "[[\"a\",\"a\",\"b\"],[\"aa\",\"b\"]]")]
    [InlineData("a", "[[\"a\"]]")]
    public void Partition(string s, string expected)
    {
        var actual = Partition0131.Partition(s);
        Assert.Equal(expected.To2dArr<string>(), actual);
    }
}
