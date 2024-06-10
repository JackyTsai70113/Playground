namespace playground.UnitTest;

public class GenerateTest0118
{
    [Theory]
    [InlineData(5, "[[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]")]
    [InlineData(1, "[[1]]")]
    public void Generate(int n, string expected)
    {
        var actual = Generate0118.Generate(n);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
