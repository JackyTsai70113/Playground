using playground.DirectedGraph;

namespace playground.UnitTest.DirectedGraph;

public class CrackSafeTest
{
    [Theory]
    [InlineData(1, 2, "01")]
    [InlineData(2, 2, "00110")]
    public void CrackSafe(int n, int k, string expected)
    {
        var actual = CrackSafeClass.CrackSafe(n, k);

        Assert.Equal(expected, actual);
    }
}
