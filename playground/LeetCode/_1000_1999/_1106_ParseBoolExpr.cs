namespace playground._1100_1199;

public class _1106_ParseBoolExpr_cs
{
    public static bool ParseBoolExpr(string s)
    {
        var st = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == ',')
                continue;
            else if (s[i] == '&' || s[i] == '|' || s[i] == '!' || s[i] == 't' || s[i] == 'f')
            {
                st.Push(s[i]);
            }
            else // s[i] == ')'
            {
                bool hasTrue = false;
                bool hasFalse = false;
                while (st.Peek() != '&' && st.Peek() != '|' && st.Peek() != '!')
                {
                    if (st.Pop() == 't') hasTrue = true;
                    else hasFalse = true;
                }
                var op = st.Pop();
                if (op == '!')
                {
                    st.Push(hasTrue ? 'f' : 't');
                }
                else if (op == '&')
                {
                    st.Push(hasFalse ? 'f' : 't');
                }
                else
                { // op == '|'
                    st.Push(hasTrue ? 't' : 'f');
                }
            }
        }
        return st.Peek() == 't' ? true : false;
    }
}
