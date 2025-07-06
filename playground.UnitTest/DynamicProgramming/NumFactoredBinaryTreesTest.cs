using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class NumFactoredBinaryTreesTest
{
    [Theory]
    [InlineData(new int[] { 2, 4 }, 3)]
    [InlineData(new int[] { 2, 4, 5, 10 }, 7)]
    [InlineData(new int[] { 2, 4, 5, 10, 20 }, 18)]
    public void NumFactoredBinaryTrees(int[] arr, int expected)
    {
        int actual = NumFactoredBinaryTreesClass.NumFactoredBinaryTrees(arr);
        Assert.Equal(expected, actual);
    }
}
