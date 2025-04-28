namespace playground;

public class IntToRoman_0012
{
    /// <summary>
    /// https://leetcode.com/problems/integer-to-roman
    /// </summary>
    public static string IntToRoman(int num)
    {
        var res = new List<char>();
        while (num > 0)
        {
            switch (num)
            {
                case >= 1000:
                    res.Add('M');
                    num -= 1000;
                    break;
                case >= 900:
                    res.AddRange(new[] { 'C', 'M' });
                    num -= 900;
                    break;
                case >= 500:
                    res.Add('D');
                    num -= 500;
                    break;
                case >= 400:
                    res.AddRange(new[] { 'C', 'D' });
                    num -= 400;
                    break;
                case >= 100:
                    res.Add('C');
                    num -= 100;
                    break;
                case >= 90:
                    res.AddRange(new[] { 'X', 'C' });
                    num -= 90;
                    break;
                case >= 50:
                    res.Add('L');
                    num -= 50;
                    break;
                case >= 40:
                    res.AddRange(new[] { 'X', 'L' });
                    num -= 40;
                    break;
                case >= 10:
                    res.Add('X');
                    num -= 10;
                    break;
                case >= 9:
                    res.AddRange(new[] { 'I', 'X' });
                    num -= 9;
                    break;
                case >= 5:
                    res.Add('V');
                    num -= 5;
                    break;
                case >= 4:
                    res.AddRange(new[] { 'I', 'V' });
                    num -= 4;
                    break;
                case >= 1:
                    res.Add('I');
                    num--;
                    break;
            }
        }
        return new string(res.ToArray());
    }
}
