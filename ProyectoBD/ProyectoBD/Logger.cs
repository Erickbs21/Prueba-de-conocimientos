using System;
using System.IO;

namespace ProyectoBD
{
    public static class Logger
    {
        private static string ruta =
            @"C:\Users\erici\OneDrive\Escritorio\Prueba tecnica\Prueba-de-conocimientos\ProyectoBD\ProyectoBD\log.txt";

        public static void Escribir(string mensaje)
        {
            string texto = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                         + " - " + mensaje;

            File.AppendAllText(ruta, texto + Environment.NewLine);
        }
    }
}
