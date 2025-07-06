using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class CountTest
{
    [Theory]
    [InlineData("1", "203", 8, 46, 136)]
    [InlineData("1", "417", 8, 46, 311)]
    [InlineData("1", "417", 4, 4, 15)]
    [InlineData("1", "417", 8, 10, 106)]
    [InlineData("1", "4179", 8, 46, 3869)]
    [InlineData("1", "41792", 8, 46, 41027)]
    [InlineData("4179205230", "7748704426", 8, 46, 883045899)]
    [InlineData("1", "10000000000000000000000", 1, 400, 490000)]
    [InlineData("1", "12", 1, 8, 11)]
    [InlineData("1", "5", 1, 5, 5)]
    public void Count(string num1, string num2, int min_sum, int max_sum, int expected)
    {
        var actual = new CountClass().Count(num1, num2, min_sum, max_sum);
        Assert.Equal(expected, actual);
    }
}
