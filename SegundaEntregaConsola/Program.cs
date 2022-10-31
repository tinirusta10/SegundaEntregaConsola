using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEntregaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 77

            //SortedList diccio = new SortedList();
            //diccio.Add("hello", "hola");
            //diccio.Add("you", "tu");
            //diccio.Add("me", "yo");
            //diccio.Add("They", "Ellos");
            //diccio.Add("computer", "computadora");
            //diccio.Add("keyboard", "teclado");
            //diccio.Add("word", "palabra");
            //diccio.Add("document", "documento");
            //diccio.Add("house", "casa");
            //diccio.Add("car", "auto");
            //diccio.Add("fan", "ventilador");
            //string palabras = Console.ReadLine();

            //string[] palabra = palabras.Split(' ');

            //foreach (string x in palabra)
            //{
            //    if (diccio.ContainsKey(x))
            //    {
            //        Console.Write(diccio[x] + ' '.ToString());  
            //    }
            //}

            //Console.WriteLine();
            //Console.ReadKey();

            #endregion

            #region 78

            //Hashtable diccio = new Hashtable();
            //diccio.Add("hello", "hola");
            //diccio.Add("you", "tu");
            //diccio.Add("me", "yo");
            //diccio.Add("They", "Ellos");
            //diccio.Add("computer", "computadora");
            //diccio.Add("keyboard", "teclado");
            //diccio.Add("word", "palabra");
            //diccio.Add("document", "documento");
            //diccio.Add("house", "casa");
            //diccio.Add("car", "auto");
            //diccio.Add("fan", "ventilador");

            //string palabras = Console.ReadLine();

            //string[] palabra = palabras.Split(' ');

            //foreach (string x in palabra)
            //{
            //    if (diccio.ContainsKey(x))
            //    {
            //        Console.Write(diccio[x] + ' '.ToString());
            //    }
            //}

            //Console.WriteLine();
            //Console.ReadKey();

            #endregion

            #region 79

            SortedSet<string> palabras =  new SortedSet<string>();
            string palabra = Console.ReadLine();

            while (palabra != "")
            {
                if (palabras.Contains(palabra))
                {
                    Console.WriteLine("la palabra ingresada ya existe, ingresa otra distinta");
                    palabra = Console.ReadLine();
                }
                else
                {
                    palabras.Add(palabra);
                    palabra = Console.ReadLine();
                }
            }

            #endregion

        }
    }
}
