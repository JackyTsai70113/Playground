using playground._2400_2499;

namespace playground.UnitTest._2400_2499;

public class _2471_MinimumOperationsTest
{
    [Theory]
    [InlineData("[1, 4, 3, 7, 6, 8, 5, null, null, null, null, 9, null, 10]", 3)]
    [InlineData("[1,3,2,7,6,5,4]", 3)]
    [InlineData("[1,2,3,4,5,6]", 0)]
    [InlineData("[332,463,103,417,150,409,41,135,129,117,474,263,null,328,456,347,167,383,null,null,422,493,489,275,72,null,null,425,89,null,null,162,18,null,null,null,null,363,290,106,260,468,null,null,null,432,null,323,null,null,null,null,null,null,36,null,null,302,190,null,280,null,null,null,null,488,null,null,null,null,446,null,null,null,null,null,75]", 24)]

    public void MinimumOperations(string root, int expected)
    {
        var actual = _2471_MinimumOperations.MinimumOperations(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}