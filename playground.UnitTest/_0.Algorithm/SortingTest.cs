namespace playground.UnitTest._0.Algorithm;

public class SortingTest
{
    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void InsertionSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.InsertionSort(actual, n);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void ShellSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.ShellSort(actual, n);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void SelectionSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.SelectionSort(actual, n);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void BubbleSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.BubbleSort(actual, n);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void ShakerSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.ShakerSort(actual, n);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void MergeSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.MergeSort(actual, n);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}