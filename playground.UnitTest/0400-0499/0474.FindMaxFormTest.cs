namespace playground.UnitTest;

public class FindMaxFormTest0474
{
    [Theory]
    [InlineData(new string[] { "10", "0001", "111001", "1", "0" }, 5, 3, 4)]
    [InlineData(new string[] { "10", "0", "1" }, 1, 1, 2)]
    [InlineData(new string[] { "11", "11", "0", "0", "10", "1", "1", "0", "11", "1", "0", "111", "11111000", "0", "11", "000", "1", "1", "0", "00", "1", "101", "001", "000", "0", "00", "0011", "0", "10000" }, 90, 66, 29)]
    public void FindMaxForm(string[] strs, int m, int n, int expected)
    {
        var actual = FindMaxForm0474.FindMaxForm(strs, m, n);
        Assert.Equal(expected, actual);
    }
}
