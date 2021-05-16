using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Class1
    {
        static public bool Check(string a, string b)
        {
            char[] x = a.ToCharArray();
            char[] y = b.ToCharArray();

            int count1 = 0; int count2 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                count1 += (int)x[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                count2 += (int)y[i];
            }
            return count1 == count2;
        }
    }
}
