using System.Linq;

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

            if (sz == 2)
            {
                return new string(str.Reverse().ToArray());
            }
            
            return str;
        }
    }
}