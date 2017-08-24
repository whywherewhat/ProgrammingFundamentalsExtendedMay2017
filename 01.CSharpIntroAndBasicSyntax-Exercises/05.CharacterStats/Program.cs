﻿using System;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string heroName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine($"Health: |" + new string('|', currentHealth) + new string('.', maxHealth - currentHealth) + "|");
            Console.WriteLine($"Energy: |" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|");
        }
    }
}
