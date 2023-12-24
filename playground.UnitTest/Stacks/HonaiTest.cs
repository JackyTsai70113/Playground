using playground.Stacks;

namespace playground.UnitTest.Stacks;

public class HonaiTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 3)]
    [InlineData(3, 7)]
    public void Honai(int n, int expected)
    {
        var actual = HonaiClass.Honai(n);
        Assert.Equal(expected, actual);
    }
}
