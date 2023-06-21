using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class MaximumBeautyTest
{
    [Theory]
    [InlineData("[[1,2],[3,2],[2,4],[5,6],[3,5]]", new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 4, 5, 5, 6, 6 })]
    [InlineData("[[0,2],[3,2],[2,4],[5,6],[3,5]]", new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 4, 5, 5, 6, 6 })]
    [InlineData("[[1,2],[1,2],[1,3],[1,4]]", new int[] { 1}, new int[] { 4})]
    [InlineData("[[10,1000]]", new int[] { 5 }, new int[] { 0 })]
    [InlineData("[[193,732],[781,962],[864,954],[749,627],[136,746],[478,548],[640,908],[210,799],[567,715],[914,388],[487,853],[533,554],[247,919],[958,150],[193,523],[176,656],[395,469],[763,821],[542,946],[701,676]]", new int[] { 885, 1445, 1580, 1309, 205, 1788, 1214, 1404, 572, 1170, 989, 265, 153, 151, 1479, 1180, 875, 276, 1584 }, new int[] { 962, 962, 962, 962, 746, 962, 962, 962, 946, 962, 962, 919, 746, 746, 962, 962, 962, 919, 962 })]
    public void MaximumBeauty(string items, int[] queries, int[] expected)
    {
        var actual = MaximumBeautyClass.MaximumBeauty(items.To2dArr(), queries);
        Assert.Equal(expected, actual);
    }
}