﻿namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {
            Console.WriteLine($"Adição: {x + y}");
        }

        public static void Substrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x - y}");
        }
    }
}
