namespace playground;

public class GenerateKey3270
{
    public static int GenerateKey(int num1, int num2, int num3)
    {
        string str1 = ToStr(num1), str2 = ToStr(num2), str3 = ToStr(num3);
        var res = 0;
        for (int i = 0; i < 4; i++)
        {
            var temp = Math.Min(str1[i], Math.Min(str2[i], str3[i])) - '0';
            res = res * 10 + temp;
        }
        return res;
    }

    public static string ToStr(int num)
    {
        var str = num.ToString();
        var prefix = new string(Enumerable.Repeat('0', 4 - str.Length).ToArray());
        return prefix + str;
    }
}
