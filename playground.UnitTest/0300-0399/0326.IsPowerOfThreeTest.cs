namespace playground.UnitTest;

public class IsPowerOfThreeTest0326
{
    [Theory]
    [InlineData(27, true)]
    [InlineData(0, false)]
    [InlineData(-1, false)]
    public void IsPowerOfThree(int n, bool expected)
    {
        var actual = IsPowerOfThree0326.IsPowerOfThree(n);
        Assert.Equal(expected, actual);
    }
}
