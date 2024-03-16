namespace playground.UnitTest;

public class CodecTest0449
{
    [Theory]
    [InlineData("[2,1,3]", "[2,1,3]")]
    [InlineData("[1,null,2]", "[1,null,2]")]
    [InlineData("[2,1]", "[2,1]")]
    [InlineData("[3]", "[3]")]
    [InlineData("[]", "[]")]
    public void Codec(string root, string expected)
    {

        var str = Codec0449.Serialize(root.ToTreeNode());
        var actual = Codec0449.Deserialize(str);
        if (actual == null)
        {
            Assert.Equal(expected.ToTreeNode(), actual);
        }
        else
        {
            Assert.Equal(expected, actual.ToString());
        }
    }
}
