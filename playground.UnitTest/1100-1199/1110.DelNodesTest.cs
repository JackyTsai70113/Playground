namespace playground.UnitTest;

public class DelNodesTest1110
{
    [Theory]
    [InlineData("[1,2,3,4,5,6,7]", new int[] { 3, 5 }, "[[1,2,null,4],[6],[7]]")]
    [InlineData("[1,2,4,null,3]", new int[] { 3 }, "[[1,2,4]]")]
    [InlineData("[1,2,4,3]", new int[] { 3 }, "[[1,2,4]]")]
    public void DelNodes(string root, int[] to_delete, string expected)
    {
        {
            var actual = DelNodes1110.DelNodes(root.ToTreeNode(), to_delete);
            var expectedTrees = expected.ToArr<object>();
            Assert.Equal(expectedTrees.Length, actual.Count);
            for (int i = 0; i < expectedTrees.Length; i++)
            {
                Assert.Equal(expectedTrees[i].ToString(), actual[i].ToString());
            }
        }
    }
}
