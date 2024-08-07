namespace playground.UnitTest;

public class MinOperationsTest1598
{
    [Theory]
    [InlineData(new string[] { "d1/", "d2/", "../", "d21/", "./" }, 2)]
    [InlineData(new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }, 3)]
    [InlineData(new string[] { "d1/", "../", "../", "../" }, 0)]
    public void MinOperations(string[] logs, int expected)
    {
        var actual = MinOperations1598.MinOperations(logs);
        Assert.Equal(expected, actual);
    }
}
