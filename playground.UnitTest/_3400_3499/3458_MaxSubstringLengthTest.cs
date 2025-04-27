using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3458_MaxSubstringLengthTest
{
    [Theory]
    [InlineData("cjd", 3, true)]
    [InlineData("abcdbaefab", 2, true)]
    [InlineData("cdefdc", 3, false)]
    [InlineData("abeabe", 0, true)]
    [InlineData("cgvmkoyzwxgc", 4, true)]
    [InlineData("uqjxfyrgpnrrjyfxqvtpvyipznvtyuuzrtaxvzitgbqpjxzmixyabgbzfuvuvvaunyuuxbrjuuxtvnbygptxnvaaxumgxqqmtbzxnniiubgzyumzqfixuuuqtrraqjfnymrjygtuzrrrxutrmnazafzqttaanfyzvfnfrmyxzritbuaftygfqtaumuxujaqrpbbbyxmbpjqrtpuggyyityfmmrubaygoehkdowsoeehklwolokdcckddwloeklcodecslcsdhwwlheclldewwksdkksooecceowheddhechshlwokeohwoedkhoodehhewocewheocscwdllsocshkhswodchckdkeeeeoholeleddkwsehokhwlooksohdkwhwhkwscecdddcdkdsskdhsllckedseeehkokdoldoloelccwkedelddsccewldkohelslolhdhoksohkdkhccdhsedsldckoodhcseherbnrttirutqftuxvfmiggxuaazppxjrrxibzzaxzznzvgbjmrpuixmgbfqpzztmjzgqbmfvazyyftmguxxpxyfvvfabbiiyyjanaqvfvpfuyqipgnbuguptpuvvxpnggqir", 1, true)]
    [InlineData("ddjlopbgngpoenkqktvuuvpygctyquoeqszijjfiswiladdfwzislzdd", 4, false)]
    public void MaxSubstringLength(string s, int k, bool expected)
    {
        var actual = _3458_MaxSubstringLength.MaxSubstringLength(s, k);
        Assert.Equal(expected, actual);
    }
}
