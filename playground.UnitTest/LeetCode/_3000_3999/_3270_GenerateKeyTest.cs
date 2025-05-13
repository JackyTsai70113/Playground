namespace playground.UnitTest.LeetCode._3000_3999;

public class _3270_GenerateKeyTest
{
    [Theory]
    [InlineData(1, 10, 1000, 0)]
    [InlineData(987, 879, 798, 777)]
    [InlineData(1, 2, 3, 1)]
    public void GenerateKey(int num1, int num2, int num3, int expected)
    {
        var actual = _3270_GenerateKey.GenerateKey(num1, num2, num3);
        Assert.Equal(expected, actual);
    }
}
