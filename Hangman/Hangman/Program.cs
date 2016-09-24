using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {

        private static int lives;

        private static string getUserName ()
        {
            string userName = "";
            Console.WriteLine("Ingrese su nombre de jugador: ");
            return userName = Console.ReadLine();
        }

        private static void initGameComponents ()
        {
            lives = 5;

        }

        static void Main(string[] args)
        {
            initGameComponents();
            string userName = getUserName();

        }
    }
}
