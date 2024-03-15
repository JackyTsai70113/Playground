namespace playground.UnitTest;

public class CountVowelPermutationTest1220
{
    [Theory]
    [InlineData(1, 5)]
    [InlineData(2, 10)]
    [InlineData(20000, 759959057)]
    public void CountVowelPermutation(int n, int expected)
    {
        var actual = CountVowelPermutation1220.CountVowelPermutation(n);
        Assert.Equal(expected, actual);
    }
}
