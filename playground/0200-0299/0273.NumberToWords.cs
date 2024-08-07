using System.Text;

namespace playground;

public class NumberToWords0273
{
    public string NumberToWords(int num)
    {
        if (num == 0) return "Zero";
        StringBuilder sb = new();
        for (int i = 0; num > 0; i++)
        {
            if (num % 1000 > 0)
            {
                if (i == 1)
                {
                    sb.Insert(0, " Thousand");
                }
                else if (i == 2)
                {
                    sb.Insert(0, " Million");
                }
                else if (i == 3)
                {
                    sb.Insert(0, " Billion");
                }
                sb.Insert(0, " " + NumTo100Str(num % 1000));
            }
            num /= 1000;
        }
        return sb.Remove(0, 1).ToString();
    }

    public StringBuilder NumTo100Str(int num)
    {
        StringBuilder sb = new();
        if (num / 100 > 0)
        {
            var sb_a = NumToStr(num / 100);
            sb.Append(sb_a);
            sb.Append(" Hundred");
        }
        if (num / 100 > 0 && num % 100 > 0)
        {
            sb.Append(' ');
        }
        var sb_b = NumTo10Str(num % 100);
        sb.Append(sb_b);
        return sb;
    }

    public StringBuilder NumTo10Str(int num)
    {
        StringBuilder sb = new();
        if (num == 0) return sb;
        int a = num / 10;
        int b = num % 10;
        if (a >= 9)
        {
            sb.Append("Ninety");
        }
        else if (a >= 8)
        {
            sb.Append("Eighty");
        }
        else if (a >= 7)
        {
            sb.Append("Seventy");
        }
        else if (a >= 6)
        {
            sb.Append("Sixty");
        }
        else if (a >= 5)
        {
            sb.Append("Fifty");
        }
        else if (a >= 4)
        {
            sb.Append("Forty");
        }
        else if (a >= 3)
        {
            sb.Append("Thirty");
        }
        else if (a >= 2)
        {
            sb.Append("Twenty");
        }
        else if (a >= 1)
        {
            if (b >= 9)
            {
                sb.Append("Nineteen");
            }
            else if (b >= 8)
            {
                sb.Append("Eighteen");
            }
            else if (b >= 7)
            {
                sb.Append("Seventeen");
            }
            else if (b >= 6)
            {
                sb.Append("Sixteen");
            }
            else if (b >= 5)
            {
                sb.Append("Fifteen");
            }
            else if (b >= 4)
            {
                sb.Append("Fourteen");
            }
            else if (b >= 3)
            {
                sb.Append("Thirteen");
            }
            else if (b >= 2)
            {
                sb.Append("Twelve");
            }
            else if (b >= 1)
            {
                sb.Append("Eleven");
            }
            else
            {
                sb.Append("Ten");
            }
            return sb;
        }
        if (b == 0) return sb;
        if (a >= 1)
        {
            sb.Append(' ');
        }
        var sb2 = NumToStr(b);
        sb.Append(sb2);
        return sb;
    }
    public StringBuilder NumToStr(int num)
    {
        StringBuilder sb = new();
        if (num >= 9)
        {
            sb.Append("Nine");
        }
        else if (num >= 8)
        {
            sb.Append("Eight");
        }
        else if (num >= 7)
        {
            sb.Append("Seven");
        }
        else if (num >= 6)
        {
            sb.Append("Six");
        }
        else if (num >= 5)
        {
            sb.Append("Five");
        }
        else if (num >= 4)
        {
            sb.Append("Four");
        }
        else if (num >= 3)
        {
            sb.Append("Three");
        }
        else if (num >= 2)
        {
            sb.Append("Two");
        }
        else if (num >= 1)
        {
            sb.Append("One");
        }
        return sb;
    }
}
