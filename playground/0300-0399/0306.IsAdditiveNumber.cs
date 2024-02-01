using System.Text;

namespace playground;

public class IsAdditive0306
{
    // public bool IsAdditiveNumber(string num)
    // {
    //     for (int i = 1; i <= num.Length / 2; ++i)
    //     {
    //         for (int j = i + 1; j <= (num.Length - i) / 2; ++j)
    //         {
    //             var first = num.Substring(0, i);
    //             var second = num.Substring(i, j);
    //             var third = num.Substring(i + j);
    //             if (Bt(first, second, third))
    //                 return true;
    //         }
    //     }
    //     return false;
    // }

    // bool Bt(string first, string second, string third)
    // {
    //     if (first[0] == '0' || second[0] == '0') return false;
    //     string sum = Add(first, second);
    //     if(sum==third) return true;
    //     if(third.Length <= sum.Length || )
    // }

    // string Add(string a, string b)
    // {
    //     var sb = new StringBuilder();
    //     int i = a.Length - 1, j = b.Length - 1, carry = 0;
    //     while (i >= 0 || j >= 0)
    //     {
    //         int sum = (i >= 0 ? a[i--] - '0' : 0) + (j >= 0 ? b[j--] - '0' : 0) + carry;
    //         sb.Insert(0, sum % 10 + '0');
    //         carry = sum / 10;
    //     }
    //     if (carry == 1)
    //         sb.Insert(0, '1');
    //     return sb.ToString();
    // }
}
