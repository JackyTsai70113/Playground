using playground.LeetCode.Helpers;

namespace playground.UnitTest.LeetCode.Helpers;

public class MathHelperTest
{
    [Fact]
    public void PowersOfTwo_ShouldContainKnownValues()
    {
        Assert.Equal(1024UL, MathHelper.PowersOfTwo[10]);
        Assert.Equal(1_073_741_824UL, MathHelper.PowersOfTwo[30]);
        Assert.Equal(9_223_372_036_854_775_808UL, MathHelper.PowersOfTwo[63]);
    }

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

    [Fact]
    public void GetPrimes_N_Equals_0_Or_1_ShouldReturnAllFalse()
    {
        var result0 = MathHelper.GetPrimes(0);
        Assert.Equal(new bool[] { false }, result0);

        var result1 = MathHelper.GetPrimes(1);
        Assert.Equal(new bool[] { false, false }, result1);
    }

    [Fact]
    public void GetPrimes_N_Equals_2_ShouldReturnCorrectPrimes()
    {
        var result = MathHelper.GetPrimes(2);
        Assert.Equal(new bool[] { false, false, true }, result);
    }

    [Fact]
    public void GetPrimes_N_Equals_10_ShouldReturnCorrectPrimes()
    {
        var result = MathHelper.GetPrimes(10);
        // 0 and 1 are not prime, 2,3,5,7 are prime
        var expected = new bool[]
        {
            false, false, true, true, false,
            true, false, true, false, false, false
        };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetPrimes_N_Equals_20_ShouldReturnCorrectPrimes()
    {
        var result = MathHelper.GetPrimes(20);
        var expected = new bool[]
        {
            false, false, true,  true,  false,
            true,  false, true,  false, false,
            false, true, false, true, false,
            false, false, true, false, true, false
        };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetPowersOfTwoMod_N_Equals_1_ShouldReturnArrayWithOne()
    {
        var result = MathHelper.GetPowersOfTwoMod(1);
        Assert.Equal(new long[] { 1 }, result);
    }

    [Fact]
    public void GetPowersOfTwoMod_N_Equals_5_DefaultMod_ShouldReturnCorrectArray()
    {
        var result = MathHelper.GetPowersOfTwoMod(5);
        Assert.Equal(new long[] { 1, 2, 4, 8, 16 }, result);
    }

    [Fact]
    public void GetPowersOfTwoMod_N_Equals_10_CustomMod_ShouldReturnCorrectArray()
    {
        var mod = 100;
        var result = MathHelper.GetPowersOfTwoMod(10, mod);
        var expected = new long[] { 1, 2, 4, 8, 16, 32, 64, 28, 56, 12 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetPowersOfTwoMod_LargeN_ShouldNotThrow()
    {
        var result = MathHelper.GetPowersOfTwoMod(1000);
        Assert.Equal(1000, result.Length);
        Assert.Equal(1L, result[0]);
    }
}

