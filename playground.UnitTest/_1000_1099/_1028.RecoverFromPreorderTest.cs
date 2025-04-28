namespace playground.UnitTest;

public class RecoverFromPreorderTest1028
{
    [Theory]
    [InlineData("1-2-3", "[1,2,3]")]
    [InlineData("1-2--3--4-5--6--7", "[1,2,5,3,4,6,7]")]
    [InlineData("1-2--3---4-5--6---7", "[1,2,5,3,null,6,null,4,null,7]")]
    [InlineData("1-401--349---90--88", "[1,401,null,349,88,90]")]
    public void RecoverFromPreorder(string s, string expected)
    {
        var actual = RecoverFromPreorder1028.RecoverFromPreorder(s);
        Assert.Equal(expected, actual.ToString());
    }
}
