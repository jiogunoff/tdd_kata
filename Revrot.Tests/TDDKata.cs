using System;
using System.Linq;
using System.Text;

namespace Revrot.Tests
{
    public static class TDDKata
    {
        public static string Revrot(string str, int sz)
        {
            if (sz <= 0 || str.Length < sz)
            {
                return string.Empty;
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
                    sb.Append(chunk.Substring(1, chunk.Length - 1) + chunk[0]);
                }
            }

            return sb.ToString();
        }
    }
}