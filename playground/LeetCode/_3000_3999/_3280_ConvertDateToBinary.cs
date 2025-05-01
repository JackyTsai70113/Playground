namespace playground;

public class _3280_ConvertDateToBinary
{
    public static string ConvertDateToBinary(string date)
    {
        var strs = date.Split('-').Select(str => ToBinary(str)).ToArray();
        return string.Join('-', strs);
    }

    static string ToBinary(string str)
    {
        int num = int.Parse(str);
        string res = string.Empty;
        while (num > 0)
        {
            res = ((num & 1) == 0 ? '0' : '1') + res;
            num >>= 1;
        }
        return res;
    }
}
