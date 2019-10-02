using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_Cesar
{
    public class Cesar
    {
        private static char[] _espMayus = new[]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S',
            'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private static char[] _espMinus = new[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's',
            't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        public static List<char> cambioAbecedario(string opcion, string idioma)
        {
            List<char> Abecedario = new List<char>();

            switch (opcion)
            {
                case "Minusculas":
                    Abecedario.AddRange(_espMinus);
                    break;
                case "Mayusculas":
                    Abecedario.AddRange(_espMayus);
                    break;
                case "Ambas":
                    Abecedario.AddRange(_espMayus);
                    Abecedario.AddRange(_espMinus);
                    break;
                default:
                    Abecedario.AddRange(_espMinus);
                    break;
            }

            if (idioma.Equals("Ingles"))
            {
                Abecedario.Remove('ñ');
                Abecedario.Remove('Ñ');
            }

            return Abecedario;
        }
    }
}
