using System.Text;

namespace playground;

public class NumberToWords0273
{
    readonly string[] LessThanTwenty = new string[] {
        "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    readonly string[] Tens = new string[] {
        "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    readonly string[] Thousands = new string[] { "", "Thousand", "Million", "Billion" };
    public string NumberToWords(int num)
    {
        if (num == 0) return "Zero";
        StringBuilder sb = new();
        for (int i = 0; num > 0; i++)
        {
            if (num % 1000 > 0)
            {
                sb.Insert(0, Thousands[i] + " ");
                sb.Insert(0, NumToStr(num % 1000));
            }
            num /= 1000;
        }
        return sb.ToString().Trim();
    }

    /// <summary>
    /// return string from 0 ~ 999 
    /// </summary>
    public StringBuilder NumToStr(int num)
    {
        StringBuilder sb = new();
        if (num == 0)
            return sb;
        if (num < 20)
            sb.Append(LessThanTwenty[num] + " ");
        else if (num < 100)
        {
            sb.Append(Tens[num / 10] + " ");
            sb.Append(NumToStr(num % 10));
        }
        else
        {
            sb.Append(LessThanTwenty[num / 100] + " Hundred ");
            sb.Append(NumToStr(num % 100));
        }
        return sb;
    }
}
