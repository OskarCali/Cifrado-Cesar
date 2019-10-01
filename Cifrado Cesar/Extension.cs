using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_Cesar
{
    static class Extension
    {
        public static string toAbc(this List<char> Abecedario)
        {
            string abc = "";

            foreach (var caracter in Abecedario)
            {
                abc += caracter;
            }

            return abc;
        }
    }
}
