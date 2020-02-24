using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryES1
{
    public class Calcoli
    {
        public static bool QuadratoP(int N2)
        {
            for (int i = 1; i<= N2; i++)
            {
                int q = i * i;
                if (q == N2)
                    return true;
                if(q > N2)
                    return false; 
            }
            return false;
        }//fare test a casa
    }
}
