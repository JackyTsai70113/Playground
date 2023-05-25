using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class MaxScoreTest
{
    [Theory]
    [InlineData("[1,3,3,2]", "[2,1,3,4]", 3, 12)]
    [InlineData("[4,2,3,1,1]", "[7,5,10,9,6]", 1, 30)]
    [InlineData("[40000,20000,30000,10000,10000,40000,20000,30000,10000,10000]", "[70000,50000,100000,90000,60000,70000,50000,100000,90000,60000]", 10, 11000000000)]
    public void MaxScore(string a, string b, int k, long expected)
    {
        var actual = MaxScoreClass.MaxScore(a.ToArr(), b.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
