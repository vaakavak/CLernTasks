using System;
using System.IO;


internal class Program
{
    private static void Main(string[] args)
    {
        char[,] map = null;

        string[] file = File.ReadAllLines("map.txt");
        Console.WriteLine(file[0]);
    }
}