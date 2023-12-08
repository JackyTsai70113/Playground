namespace playground.UnitTest;

public class ConnectTest_0117
{
    [Theory]
    [InlineData("[1,2,3,4,5,null,7]", "[1,#,2,3,#,4,5,7,#]")]
    [InlineData("[]", "[]")]
    public void Connect(string root, string expected)
    {
        var actual = Connect_0117.Connect(root.ToNode());
        if (actual == null)
            Assert.Empty(expected.ToArr());
        else
            Assert.Equal(expected, actual.ToString());
    }
}