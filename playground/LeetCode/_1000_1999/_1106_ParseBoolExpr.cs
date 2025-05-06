namespace playground.LeetCode._1000_1999;

public class _1106_ParseBoolExpr
{
    public static bool ParseBoolExpr(string s)
    {
        var st = new Stack<char>();

        foreach (char c in s)
        {
            if (c == ',' || c == '(')
                continue;

            if (c == ')')
            {
                Evaluate(st);
            }
            else
            {
                st.Push(c);
            }
        }

        return st.Peek() == 't';
    }

    /// <summary>
    /// 進行布林運算評估，當遇到 ')' 時觸發。
    /// </summary>
    private static void Evaluate(Stack<char> st)
    {
        bool hasTrue = false;
        bool hasFalse = false;

        // 收集布林值直到遇到運算符
        while (!IsOperator(st.Peek()))
        {
            char val = st.Pop();
            if (val == 't') hasTrue = true;
            else if (val == 'f') hasFalse = true;
        }

        char op = st.Pop(); // 運算符：&, |, !
        char result = op switch
        {
            '&' => hasFalse ? 'f' : 't',
            '|' => hasTrue ? 't' : 'f',
            _ => hasTrue ? 'f' : 't',
        };

        st.Push(result);
    }

    /// <summary>
    /// 判斷是否為布林運算符。
    /// </summary>
    private static bool IsOperator(char c)
    {
        return c == '&' || c == '|' || c == '!';
    }
}