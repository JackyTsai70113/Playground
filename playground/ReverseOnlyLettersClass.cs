using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground;

public class ReverseOnlyLettersClass
{
    public static string ReverseOnlyLetters(string s)
    {
        StringBuilder sb = new();
        int end = s.Length - 1;
        foreach (var c in s)
        {
            if (char.IsLetter(c))
            {
                while(!char.IsLetter(s[end]))
                    end--;
                sb.Append(s[end--]);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
