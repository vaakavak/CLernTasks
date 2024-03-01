using System;
using System.IO;
using System.Threading;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.CursorVisible = false;

        char[,] map = ReadMap("map.txt");
        ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

        Task.Run(() =>
        {
            while (true)
            {
                pressedKey = Console.ReadKey();
            }

        });

        int pacmanX = 1;
        int pacmanY = 1;
        int score = 0;

        while (true)
        {
            Console.Clear();

            HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score);

            Console.ForegroundColor = ConsoleColor.Blue;
            DrawMap(map);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(pacmanX, pacmanY);
            Console.Write("@");
            //Thread.Sleep(1000); //время отрисовки кадра

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(80, 0);
            Console.Write($"Счет: {score}");

            Thread.Sleep(1000);
        }
    }
    private static char[,] ReadMap(string path)
    {
        string[] file = File.ReadAllLines("map.txt"); // переменная которая хранит файл
        char[,] map = new char[GetMaxLengthOfLine(file), file.Length];

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                map[x, y] = file[y][x];
            }
        }

        return map;
    }

    private static void DrawMap(char[,] map)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }
            Console.WriteLine();
        }

    }

    private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score) //ConsoleKeyInfo - информация о нажатой клавише
    {

        int[] direction = GetDirection(pressedKey);
        int nextPacmanPositionX = pacmanX + direction[0];
        int nextPacmanPositionY = pacmanY + direction[1];

        char nexCell = map[nextPacmanPositionX, nextPacmanPositionY];

        if (nexCell == ' ' || nexCell == '.')
        {
            pacmanX = nextPacmanPositionX;
            pacmanY = nextPacmanPositionY;

            if (nexCell == '.')
            {
                score++;
                map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
            }

        }


    }

    private static int[] GetDirection(ConsoleKeyInfo pressedKey)
    {
        int[] derection = { 0, 0 };
        if (pressedKey.Key == ConsoleKey.UpArrow)
        {
            derection[1] = -1;
        }
        else if (pressedKey.Key == ConsoleKey.DownArrow)
        {
            derection[1] = 1;
        }
        else if (pressedKey.Key == ConsoleKey.LeftArrow)
        {
            derection[0] = -1;
        }
        else if (pressedKey.Key == ConsoleKey.RightArrow)
        {
            derection[0] = 1;
        }
        return derection;
    }


    private static int GetMaxLengthOfLine(string[] lines) // найти максимальную длину
    {
        int maxLength = lines[0].Length; //длина первой строчки
        foreach (var line in lines) //перебираем все строчки
        {
            if (line.Length > maxLength)  //если длина строчки больше длины максимальной  
                maxLength = line.Length; // максимальная длина равна тому чо нашли
        };
        return maxLength;
    }
}