using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class CountVowelPermutationTest
{
    [Theory]
    [InlineData(1, 5)]
    [InlineData(2, 10)]
    [InlineData(20000, 759959057)]
    public void CountVowelPermutation(int n, int expected)
    {
        var actual = CountVowelPermutationClass.CountVowelPermutation(n);
        Assert.Equal(expected, actual);
    }
}
