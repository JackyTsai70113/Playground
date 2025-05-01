using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0449_CodecTest
{
    [Theory]
    [InlineData("[2,1,3]", "[2,1,3]")]
    [InlineData("[1,null,2]", "[1,null,2]")]
    [InlineData("[2,1]", "[2,1]")]
    [InlineData("[3]", "[3]")]
    [InlineData("[]", "[]")]
    public void Codec(string root, string expected)
    {

        var str = _0449_Codec.Serialize(root.ToTreeNode());
        var actual = _0449_Codec.Deserialize(str);
        if (actual == null)
            Assert.Equal(expected.ToTreeNode(), actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
