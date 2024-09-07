namespace playground.UnitTest;

public class GenerateKeyTest3270
{
    [Theory]
    [InlineData(1, 10, 1000, 0)]
    [InlineData(987, 879, 798, 777)]
    [InlineData(1, 2, 3, 1)]
    public void GenerateKey(int num1, int num2, int num3, int expected)
    {
        var actual = GenerateKey3270.GenerateKey(num1, num2, num3);
        Assert.Equal(expected, actual);
    }
}
