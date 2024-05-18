namespace playground.UnitTest;

public class MincostToHireWorkersTest0857
{
    [Theory]
    [InlineData(new int[] { 10, 20, 5 }, new int[] { 70, 50, 30 }, 2, 105.00000)]
    [InlineData(new int[] { 3, 1, 10, 10, 1 }, new int[] { 4, 8, 2, 2, 7 }, 3, 30.666666666666664)]
    [InlineData(new int[] { 3, 1, 10, 10, 1 }, new int[] { 4, 8, 2, 2, 7 }, 5, 200.00000)]
    public void MincostToHireWorkers(int[] quality, int[] wage, int k, double expected)
    {
        var actual = MincostToHireWorkers0857.MincostToHireWorkers(quality, wage, k);
        Assert.Equal(expected, actual);
    }
}
