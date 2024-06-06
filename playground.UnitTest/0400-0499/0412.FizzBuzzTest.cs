namespace playground.UnitTest;

public class FizzBuzzTest0412
{
    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuzz(int n, IList<string> expected)
    {
        var actual = FizzBuzz0412.FizzBuzz(n);
        Assert.Equal(expected, actual);
    }
}
