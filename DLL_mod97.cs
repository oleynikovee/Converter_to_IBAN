using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_MOD97_Csharp
{
    public class Generate
    {
        public static UInt64 mod97_test(string s, UInt64 len)
        {
            UInt64 i, j, parts = len / 7;
            string rem = "00";

            for (i = 1; i <= parts + Convert.ToUInt64((len % 7 != 0)); ++i)
            {
                rem = rem.Substring(0, 2) + s.Substring(((int)i - 1) * 7,
                   Math.Min(s.Substring(((int)i - 1) * 7).Length, 7));
                j = Convert.ToUInt64(rem) % 97;

                string tmp;
                tmp = (j / 10).ToString(); ;

                tmp += (j % 10).ToString();
                rem = tmp + rem.Substring(2);
            }

            return Convert.ToUInt64(rem) % 97;
        }
    }
}
