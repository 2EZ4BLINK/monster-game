using System;

namespace MonsterGame;

public class Menu
{
    public static void DisplayMenu()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Choose a menu:");
        Console.WriteLine("1. View Monsters");
        Console.WriteLine("2. Find Monster");
        Console.WriteLine("3. Show Strong Monsters");
        Console.WriteLine("4. Sort Monsters by HP");
        Console.WriteLine("5. Defeat Monster");
        Console.WriteLine("6. View Defeat Statistics");
        Console.WriteLine("0. Exit");
    }
}
