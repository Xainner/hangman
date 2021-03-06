﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {

        //Global variables
        private static int lives;
        private static string[] categories = new string[4];
        private static string category;

        private static string getUserName ()
        {
            string userName = "";
            Console.WriteLine("Ingrese su nombre de jugador: ");
            return userName = Console.ReadLine();
        }

        private static void initGameComponents ()
        {
            lives = 5;
            setCategories();

        }

        private static void setCategories ()
        {
            categories[0] = "Futbol";
            categories[1] = "Comida";
            categories[2] = "Videojuegos";
            categories[3] = "Libros";
        }

        private static void startGame (string userName)
        {
            Console.WriteLine("");
            Console.WriteLine("Partida iniciada, buena suerte " + userName + ".");
            Console.WriteLine("");
            Console.WriteLine("Seleccione la categoria a jugar: ");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(i+1 + ". " + categories[i]);
            }
            int gameCategory =Int32.Parse(Console.ReadLine());
            switch (gameCategory)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Eligio la categoria: Futbol");
                    category = "Futbol";
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Eligio la categoria: Comida");
                    category = "Comida";
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Eligio la categoria: Videojuegos");
                    category = "Videojuegos";
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Eligio la categoria: Libros");
                    category = "Libros";
                    break;
            }
        }

        static void Main(string[] args)
        {
            initGameComponents();
            string userName = getUserName();
            startGame(userName);
        }
    }
}
