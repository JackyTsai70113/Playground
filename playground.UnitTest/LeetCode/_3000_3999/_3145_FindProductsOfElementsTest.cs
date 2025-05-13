namespace playground.UnitTest.LeetCode._3000_3999;

public class _3145_FindProductsOfElementsTest
{
    [Theory]
    [InlineData("[[0,3,7]]", new int[] { 4 })]
    [InlineData("[[1,3,7]]", new int[] { 4 })]
    [InlineData("[[2,2,7]]", new int[] { 1 })]
    [InlineData("[[2,5,3],[7,7,4]]", new int[] { 2, 2 })]
    public static void FindProductsOfElements(string queries, int[] expected)
    {
        var actual = _3145_FindProductsOfElements.FindProductsOfElements(queries.To2dArr<long>());
        Assert.Equal(expected, actual);
    }
}
