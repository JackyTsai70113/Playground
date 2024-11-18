using playground._1600_1699;

namespace playground.UnitTest;

public class _1652_DecryptTest
{
    [Theory]
    [InlineData(new int[] { 5, 7, 1, 4 }, 3, new int[] { 12, 10, 16, 13 })]
    [InlineData(new int[] { 1, 2, 3, 4 }, 0, new int[] { 0, 0, 0, 0 })]
    [InlineData(new int[] { 2, 4, 9, 3 }, -2, new int[] { 12, 5, 6, 13})]
    public void FrequencySort(int[] code, int k, int[] expected)
    {
        var actual = _1652_Decrypt.Decrypt(code, k);
        Assert.Equal(expected, actual);
    }
}
