﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[,] mas = new int[n, n];
            Random rnd = new Random(DateTime.Now.Millisecond);
            List<int> iIndex = new List<int>();
            List<int> jIndex = new List<int>();
            int res = 1;
            int flag = 0;
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(10, 99);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 3; j++)
                {
                    if (mas[i, j] * mas[i, j + 1] * mas[i, j + 2] * mas[i, j + 3] > res)
                    {
                        iIndex.Clear();
                        jIndex.Clear();
                        res = mas[i, j] * mas[i, j + 1] * mas[i, j + 2] * mas[i, j + 3];
                        iIndex.Add(i);
                        jIndex.Add(j);
                        jIndex.Add(j + 1);
                        jIndex.Add(j + 2);
                        jIndex.Add(j + 3);
                        flag = 1;
                    }
                }
            }
            for (int i = 0; i < n - 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[i, j] * mas[i + 1, j] * mas[i + 2, j] * mas[i + 3, j] > res)
                    {
                        iIndex.Clear();
                        jIndex.Clear();
                        res = mas[i, j] * mas[i + 1, j] * mas[i + 2, j] * mas[i + 3, j];
                        jIndex.Add(j);
                        iIndex.Add(i);
                        iIndex.Add(i + 1);
                        iIndex.Add(i + 2);
                        iIndex.Add(i + 3);
                        flag = 2;
                    }
                }
            }
            for (int i = 0; i < n - 3; i++)
            {
                for (int j = 0; j < n - 3; j++)
                {
                    if (i == j)
                    {
                        if (mas[i, j] * mas[i + 1, j + 1] * mas[i + 2, j + 2] * mas[i + 3, j + 3] > res)
                        {
                            iIndex.Clear();
                            jIndex.Clear();
                            res = mas[i, j] * mas[i + 1, j + 1] * mas[i + 2, j + 2] * mas[i + 3, j + 3];
                            jIndex.Add(j);
                            jIndex.Add(j + 1);
                            jIndex.Add(j + 2);
                            jIndex.Add(j + 3);
                            iIndex.Add(i);
                            iIndex.Add(i + 1);
                            iIndex.Add(i + 2);
                            iIndex.Add(i + 3);
                            flag = 3;
                        }
                    }
                }
            }
            for (int i = 0; i < n - 3; i++)
            {
                for (int j = n - 1; j > 2; j--)
                {
                    if (j == n - i - 1)
                    {
                        if (mas[i, j] * mas[i + 1, j - 1] * mas[i + 2, j - 2] * mas[i + 3, j - 3] > res)
                        {
                            iIndex.Clear();
                            jIndex.Clear();
                            res = mas[i, j] * mas[i + 1, j - 1] * mas[i + 2, j - 2] * mas[i + 3, j - 3];
                            jIndex.Add(j);
                            jIndex.Add(j - 1);
                            jIndex.Add(j - 2);
                            jIndex.Add(j - 3);
                            iIndex.Add(i);
                            iIndex.Add(i + 1);
                            iIndex.Add(i + 2);
                            iIndex.Add(i + 3);
                            flag = 4;
                        }
                    }
                }
            }
            if (iIndex.Count == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        x++;
                        if (flag == 1)
                        {
                            if ((i == iIndex[0] && j == jIndex[0]) || (i == iIndex[0] && j == jIndex[1]) || (i == iIndex[0] && j == jIndex[2]) || (i == iIndex[0] && j == jIndex[3]))
                            {
                                ForegroundColor = ConsoleColor.Green;
                                Write(mas[i, j] + " ");
                                x = 0;
                            }
                            if (x != 0)
                            {
                                ForegroundColor = ConsoleColor.Gray;
                                Write(mas[i, j] + " ");
                            }
                        }
                    }
                    WriteLine();
                }
            }
            else if (jIndex.Count == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        x++;
                        if (flag == 2)
                        {
                            if (j == jIndex[0])
                            {
                                if ((j == jIndex[0] && i == iIndex[0]) || (j == jIndex[0] && i == iIndex[1]) || (j == jIndex[0] && i == iIndex[2]) || (j == jIndex[0] && i == iIndex[3]))
                                {
                                    ForegroundColor = ConsoleColor.Red;
                                    Write(mas[i, j] + " ");
                                    x = 0;
                                }
                            }
                            if (x != 0)
                            {
                                ForegroundColor = ConsoleColor.Gray;
                                Write(mas[i, j] + " ");
                            }
                        }
                    }
                    WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        x++;
                        if (flag == 3)
                        {
                            if ((i == iIndex[0] && j == jIndex[0]) || (i == iIndex[1] && j == jIndex[1]) || (i == iIndex[2] && j == jIndex[2]) || (i == iIndex[3] && j == jIndex[3]))
                            {
                                ForegroundColor = ConsoleColor.Cyan;
                                Write(mas[i, j] + " ");
                                x = 0;
                            }
                            if (x != 0)
                            {
                                ForegroundColor = ConsoleColor.Gray;
                                Write(mas[i, j] + " ");
                            }
                        }
                        else if (flag == 4)
                        {
                            if ((i == iIndex[0] && j == jIndex[0]) || (i == iIndex[1] && j == jIndex[1]) || (i == iIndex[2] && j == jIndex[2]) || (i == iIndex[3] && j == jIndex[3]))
                            {
                                ForegroundColor = ConsoleColor.DarkCyan;
                                Write(mas[i, j] + " ");
                                x = 0;
                            }
                            if (x != 0)
                            {
                                ForegroundColor = ConsoleColor.Gray;
                                Write(mas[i, j] + " ");
                            }
                        }
                    }
                    WriteLine();
                }
            }
            ForegroundColor = ConsoleColor.Gray;
            WriteLine();
            Write(res);
            ReadKey();
        }
    }
}
