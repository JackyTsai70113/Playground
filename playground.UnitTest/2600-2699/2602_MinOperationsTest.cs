using playground._2600_2699;

namespace playground.UnitTest._2600_2699;

public class _2602_MinOperationsTest
{
    [Theory]
    [InlineData(new int[] { 3, 1, 6, 8 }, new int[] { 1, 5 }, new long[] { 14, 10 })]
    [InlineData(new int[] { 2, 9, 6, 3 }, new int[] { 10 }, new long[] { 20 })]
    [InlineData(
        new int[] { 47,50,97,58,87,72,41,63,41,51,17,21,7,100,69,66,79,92,84,9,57,26,26,28,83,38 }, 
        new int[] { 50,84,76,41,64,82,20,22,64,7,38,92,39,28,22,3,41,46,47,50,88,51,9,49,38,67,26,65,89,27,71,25,77,72,65,41,84,68,51,26,84,24,79,41,96,83,92,9,93,84,35,70,74,79,37,38,26,26,41,26 }, 
        new long[] { 607,855,747,655,633,825,943,905,633,1227,685,1009,675,805,905,1331,655,625,619,607,929,605,1179,611,685,653,833,639,949,819,689,851,759,699,639,655,855,661,605,833,855,869,783,655,1097,839,1009,1179,1031,855,721,679,723,783,697,685,833,833,655,833 })]
    public void MinOperations(int[] nums, int[] queries, IList<long> expected)
    {
        var actual = _2602_MinOperations.MinOperations(nums, queries);
        Assert.Equal(expected, actual);
    }
}
