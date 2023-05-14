using playground.Backtracking;

namespace playground.UnitTest.Backtracking;

public class IsAdditiveNumberTest
{
    [Theory]
    [InlineData("112358", true)]
    [InlineData("199100199", true)]
    [InlineData("10", false)]
    [InlineData("101", true)]
    [InlineData("199001200", false)]
    public void IsAdditiveNumber(string num, bool expected)
    {
        var actual = IsAdditiveNumberClass.IsAdditiveNumber(num);
        Assert.Equal(expected, actual);
    }
}
