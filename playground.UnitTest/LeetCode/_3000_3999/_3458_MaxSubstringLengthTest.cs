using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

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
