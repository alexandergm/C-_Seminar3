﻿Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
getCube();

void getCube(){
    for(double i = 1; i <= N; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}