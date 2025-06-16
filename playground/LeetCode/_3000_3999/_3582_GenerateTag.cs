using System.Text;

namespace playground.LeetCode._3000_3999;

public class _3582_GenerateTag
{
    public static string GenerateTag(string caption)
    {
        var words = caption.Split(' ');
        var tagBuilder = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (string.IsNullOrEmpty(word)) continue;

            if (tagBuilder.Length == 0)
            {
                tagBuilder.Append(word.ToLower());
            }
            else
            {
                tagBuilder.Append(char.ToUpper(word[0]));
                tagBuilder.Append(word[1..].ToLower());
            }
        }

        var filteredTagBuilder = new StringBuilder();
        foreach (char c in tagBuilder.ToString())
        {
            if (('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z'))
            {
                filteredTagBuilder.Append(c);
            }
        }
        var result = '#' + filteredTagBuilder.ToString();

        return result.Length > 100 ? result[..100] : result;
    }
}
