namespace playground.UnitTest;

public class _1220_CountVowelPermutationTest
{
    [Theory]
    [InlineData(1, 5)]
    [InlineData(2, 10)]
    [InlineData(20000, 759959057)]
    public void CountVowelPermutation(int n, int expected)
    {
        var actual = _1220_CountVowelPermutation.CountVowelPermutation(n);
        Assert.Equal(expected, actual);
    }
}
