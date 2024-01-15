namespace playground.UnitTest._0.Algorithm;

public class SortingTest
{
    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void InsertionSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.InsertionSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void ShellSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.ShellSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void SelectionSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.SelectionSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void BubbleSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.BubbleSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void ShakerSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.ShakerSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    [InlineData("[9,8,7,6,5,0,1,2,3,4]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void MergeSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.MergeSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void HeapSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.HeapSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", 10, "[0,1,2,3,4,5,6,7,8,9]")]
    public void QuickSort(string nums, int n, string expected)
    {
        var actual = nums.ToArr();
        Sorting.QuickSort(actual, n);
        Assert.Equal(expected.ToArr(), actual);
    }
}