using System;
using System.Linq;
using System.Text;

namespace Revrot.Tests
{
    public static class TDDKata
    {
        public static string Revrot(string str, int sz)
        {
            if (sz <= 0)
            {
                return string.Empty;
            }

            if (str.Length < sz)
            {
                return string.Empty;
            }

            if (sz == 1)
            {
                return str;
            }
            
            if (str.Length == sz && str.Select(x => Math.Pow(int.Parse(x.ToString()), 3)).Sum() % 2 == 0)
            {
                return new string(str.Reverse().ToArray());
            }
            
            if (str.Length == sz)
            {
                var firstSymbol = str[0];
                return str.Substring(1, str.Length - 1) + firstSymbol;
            }

            var sb = new StringBuilder();
            var chunksCount = str.Length / sz;
            for (int chunkIdx = 0; chunkIdx < chunksCount; chunkIdx++)
            {
                var chunk = str.Substring(sz * chunkIdx, sz);
                if (chunk.Select(x => Math.Pow(int.Parse(x.ToString()), 3)).Sum() % 2 == 0)
                {
                    sb.Append(new string(chunk.Reverse().ToArray()));
                }
                else
                {
                    var firstSymbol = chunk[0];
                    sb.Append(chunk.Substring(1, chunk.Length - 1) + firstSymbol);
                }
            }

            return sb.ToString();
        }
    }
}