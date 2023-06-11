using playground.Strings;

namespace playground.UnitTest.Strings;

public class IsFascinatingTest
{
    [Theory]
    [InlineData(100, false)]
    [InlineData(192, true)]
    [InlineData(999, false)]
    public void IsFascinating(int n, bool expected)
    {
        var actual = IsFascinatingClass.IsFascinating(n);
        Assert.Equal(expected, actual);
    }
}
