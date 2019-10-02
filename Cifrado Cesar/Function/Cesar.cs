using System.Collections.Generic;

namespace Cifrado_Cesar
{
    public class Cesar
    {
        // Abecedario general (Esp Mayusculas)
        private static readonly char[] _espMayus =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S',
            'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        // Abecedario general (Esp Minusculas)
        private static readonly char[] _espMinus =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's',
            't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        /// <summary>
        ///     Funcion para detectar el cambio de opciones del Abecedario
        /// </summary>
        /// <param name="opcion">Opcion del Abecedario (Mayus, Minus, Ambos)</param>
        /// <param name="idioma">Idioma (Español, Ingles)</param>
        /// <returns>List&gt;char%lt; del Abecedario</returns>
        public static List<char> cambioAbecedario(string opcion, string idioma)
        {
            var Abecedario = new List<char>();

            // Establece el Abecedario base
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

            // Elimina la ñ en version Ingles
            if (idioma.Equals("Ingles"))
            {
                Abecedario.Remove('ñ');
                Abecedario.Remove('Ñ');
            }

            return Abecedario;
        }
    }
}