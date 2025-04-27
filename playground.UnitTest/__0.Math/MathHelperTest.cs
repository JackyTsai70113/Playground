namespace playground.UnitTest.__0.Math;

public class MathHelperTest
{
    [Fact]
    public void Factorials_N_Equals_0_Or_1_ShouldReturnCorrectArray()
    {
        var result0 = MathHelper.Factorials(0);
        Assert.Equal(new long[] { 1 }, result0);

        var result1 = MathHelper.Factorials(1);
        Assert.Equal(new long[] { 1, 1 }, result1);
    }

    [Fact]
    public void Factorials_GeneralCase_ShouldReturnCorrectArray()
    {
        var result = MathHelper.Factorials(5);
        Assert.Equal(new long[] { 1, 1, 2, 6, 24, 120 }, result);
    }

    [Fact]
    public void GetPermutationCount_UniqueCharacters_ShouldReturnFactorial()
    {
        // "abc" => 3! = 6
        Assert.Equal(6, MathHelper.GetPermutationCount("abc"));
    }

    [Fact]
    public void GetPermutationCount_WithDuplicateCharacters_ShouldReturnCorrect()
    {
        // "aab" => 3! / (2!) = 3
        Assert.Equal(3, MathHelper.GetPermutationCount("aab"));
    }

    [Fact]
    public void GetPermutationCount_AllSameCharacters_ShouldReturn1()
    {
        // "aaaa" => 4! / (4!) = 1
        Assert.Equal(1, MathHelper.GetPermutationCount("aaaa"));
    }

    [Fact]
    public void GetPermutationCount_NullOrEmptyString_ShouldReturn1()
    {
        // Empty string: 0! = 1
        Assert.Equal(1, MathHelper.GetPermutationCount(null));
        Assert.Equal(1, MathHelper.GetPermutationCount(""));
    }

    [Fact]
    public void GetPermutationCount_SingleCharacter_ShouldReturn1()
    {
        // "a" => 1
        Assert.Equal(1, MathHelper.GetPermutationCount("a"));
    }
}
