using playground.Other;

namespace playground.UnitTest.Other;

public class TopKElementTest
{
    [Theory]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9],[10,11,12]]", 3, new int[] { 1, 2, 3 })]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", 5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData("[[3,6,9],[1,4,7],[2,5,8]]", 5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData("[[1,1,2],[2,3,4],[2,5,8]]", 5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData("[[1,2],[2,3],[2]]", 5, new int[] { 1, 2, 3 })]
    [InlineData("[[1,2],[2,3],[2,2,2,2,2,2]]", 5, new int[] { 1, 2, 3 })]
    [InlineData("[[1,2],[2,3], []]", 5, new int[] { 1, 2, 3 })]
    public void Test(string arr, int k, int[] expected)
    {
        var actual = TopKElementClass.TopKElement(arr.To2dArr(), k);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9],[10,11,12]]", 3, new int[] { 1, 2, 3 })]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", 5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData("[[3,6,9],[1,4,7], [2,5,8]]", 5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData("[[1,2],[2,3,4],[2,5,8]]", 5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData("[[1,2],[2,3],[2]]", 5, new int[] { 1, 2, 3 })]
    [InlineData("[[1,2],[2,3],[2,2,2,2,2,2]]", 5, new int[] { 1, 2, 3 })]
    public void Test2(string arr, int k, int[] expected)
    {
        var actual = TopKElementClass.TopKElement2(arr.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
