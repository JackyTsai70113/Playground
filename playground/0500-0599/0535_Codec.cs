using System.Text;

namespace playground._0500_0599;

public class _0535_Codec
{
    Random random = new();
    StringBuilder sb = new();
    string chs = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    Dictionary<string, string> encodeDict = new();
    Dictionary<string, string> decodeDict = new();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        while (!encodeDict.ContainsKey(longUrl))
        {
            sb.Clear();
            for (int i = 0; i < 6; i++)
            {
                sb.Append(chs[random.Next(chs.Length)]);
            }
            var str = sb.ToString();
            if (!decodeDict.ContainsKey(str))
            {
                encodeDict[longUrl] = str;
                decodeDict[str] = longUrl;
            }
        }
        return encodeDict[longUrl];
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        return decodeDict[shortUrl];
    }
}
