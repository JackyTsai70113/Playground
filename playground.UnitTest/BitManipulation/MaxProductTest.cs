using playground.BitManipulation;
using playground.UnitTest.Utils;

namespace playground.UnitTest.BitManipulation;

public class MaxProductTest
{
    [Theory]
    [InlineData("[abcw,baz,foo,bar,xtfn,abcdef]", 16)]
    [InlineData("[a,ab,abc,d,cd,bcd,abcd]", 4)]
    [InlineData("[a,aa,aaa,aaaa]", 0)]
    public void MaxProduct(string a, int expected)
    {
        var actual = MaxProductClass.MaxProduct(a.ToArr<string>());
        Assert.Equal(expected, actual);
    }
}
