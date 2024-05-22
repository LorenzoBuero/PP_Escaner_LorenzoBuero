using System;
using System.Text;
using System.Drawing;
using Entidades;
/*
    COSAS QUE LE FALTAN:
*/

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(1995, "Lorenzo", "AJS132KASK", "13124", "I love css", 33);
            Libro libro2 = new Libro(1995, "Lorenzo", "AJS132KASK", "13124", "I love css", 33);

            if (libro1 == libro2)
            {
                Console.WriteLine("Son lo mismo");
            }
            else
            {
                Console.WriteLine(libro1.ToString());
            }
        }
    }
}