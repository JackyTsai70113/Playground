using playground.BinaryTrees;

namespace playground.UnitTest.BinaryTrees;

public class RecoverFromPreorderTest
{
    [Theory]
    [InlineData("1-2-3", "[1,2,3]")]
    [InlineData("1-2--3--4-5--6--7", "[1,2,5,3,4,6,7]")]
    [InlineData("1-2--3---4-5--6---7", "[1,2,5,3,null,6,null,4,null,7]")]
    [InlineData("1-401--349---90--88", "[1,401,null,349,88,90]")]
    public void RecoverFromPreorder(string str, string expectStr)
    {
        var expected = expectStr.ToTreeNode();
        var actual = RecoverFromPreorderClass.RecoverFromPreorder(str);
        Assert.True(expected.IsSameTree(actual));
    }
}
