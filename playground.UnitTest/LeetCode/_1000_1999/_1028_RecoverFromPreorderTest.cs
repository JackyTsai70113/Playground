using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1028_RecoverFromPreorderTest
{
    [Theory]
    [InlineData("1-2-3", "[1,2,3]")]
    [InlineData("1-2--3--4-5--6--7", "[1,2,5,3,4,6,7]")]
    [InlineData("1-2--3---4-5--6---7", "[1,2,5,3,null,6,null,4,null,7]")]
    [InlineData("1-401--349---90--88", "[1,401,null,349,88,90]")]
    public void RecoverFromPreorder(string s, string expected)
    {
        var actual = _1028_RecoverFromPreorder.RecoverFromPreorder(s);
        Assert.Equal(expected, actual.ToString());
    }
}
