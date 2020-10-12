using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrama
{
    class Program
    {
        public static bool verificar_anagrama(String palabra1, String palabra2)
        {
            try
            {
                char[] pal1 = palabra1.ToCharArray();
                char[] pal2 = palabra2.ToCharArray();

                Array.Sort(pal1);
                Array.Sort(pal2);


                if(pal1.SequenceEqual(pal2))
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        static void Main(string[] args)
        {
            String palabra1;
            String palabra2;

            try
            {
                Console.WriteLine("Introduzca la primera palabra");
                palabra1 = Console.ReadLine();

                Console.WriteLine("Introduzca la segunda palabra");
                palabra2 = Console.ReadLine();

                bool resultado = verificar_anagrama(palabra1, palabra2);
                if(resultado)
                {
                    Console.WriteLine("Las palabras son anagramas");
                }
                else
                {
                    Console.WriteLine("Las palabras no son anagramas");
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
