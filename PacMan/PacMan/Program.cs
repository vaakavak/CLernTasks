using System;
using System.IO;

int[,] map = null;

string[] file = File.ReadAllLines("map.txt");
Console.WriteLine(file[0]);