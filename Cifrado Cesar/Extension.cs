using System.Collections.Generic;

namespace Cifrado_Cesar
{
    internal static class Extension
    {
        /// <summary>
        ///     Funcion para obtener el Abecedario
        /// </summary>
        /// <param name="Abecedario">Lista de caracteres del Abecedario</param>
        /// <returns>String con el Abecedario</returns>
        public static string toAbc(this List<char> Abecedario)
        {
            var abc = "";

            foreach (var caracter in Abecedario) abc += caracter;

            return abc;
        }
    }
}