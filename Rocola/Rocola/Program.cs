using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocola
{
    public class Musica
    {
        public int ID;
        public String Nombre;
        public String Artista;
        public int Genero;
        
    }
    public class Album : Musica
    {
        public bool Favorita;

        public Album(int id,String nombre, String artista, int genero, bool favorita)
        {
            ID = id;
            Nombre = nombre;
            Artista = artista;
            Genero = genero;
            Favorita = favorita;
        }
    }
    public class Cancion : Album
    {
        public int Album;
        public String Letras;

        public Cancion(int id,String nombre, String artista, int genero, int album, String letras, bool favorita) : base(id,nombre,artista,genero,favorita)
        {
            ID = id;
            Nombre = nombre;
            Artista = artista;
            Genero = genero;
            Album = album;
            Letras = letras;
            Favorita = favorita;
        }

        static void reproducir()
        {
            //Reproduce la cancion
            Console.WriteLine("Vete ya si no encuentras motivos");
        }
    }

    public class ListaReproduccion
    {
        public int Id;
        public int[] canciones;

        
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
