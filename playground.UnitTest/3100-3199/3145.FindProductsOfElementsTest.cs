namespace playground.UnitTest;

public class FindProductsOfElementsTest3145
{
    [Theory]
    [InlineData("[[0,3,7]]", new int[] { 4 })]
    [InlineData("[[1,3,7]]", new int[] { 4 })]
    [InlineData("[[2,2,7]]", new int[] { 1 })]
    [InlineData("[[2,5,3],[7,7,4]]", new int[] { 2, 2 })]
    public static void FindProductsOfElements(string queries, int[] expected)
    {
        var actual = FindProductsOfElements3145.FindProductsOfElements(queries.To2dArr<long>());
        Assert.Equal(expected, actual);
    }
}
