﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSAssignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter The Number : ");
            //bool Flage = int.TryParse(Console.ReadLine(), out int Num);
            //if (Flage) 
            //{
            //    Console.Clear();
            //    while (Num >= 1) 
            //    {
            //        Console.WriteLine(Num);
            //        Num--;
            //    }
            //}


            #endregion

            #region Q2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Enter The Number : ");
            //bool Flage = int.TryParse(Console.ReadLine(), out int Num);
            //int MP = 0;
            //if (Flage) 
            //{
            //    Console.Clear();
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        MP += Num;
            //        Console.WriteLine(MP);
            //    }
            //}

            #endregion

            #region Q3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter The Number : ");
            //bool Flage = int.TryParse(Console.ReadLine(), out int Num);

            //if (Flage) 
            //{
            //    for (int i = 2; i <= Num; i++) 
            //    {
            //        if (i%2==0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region Q4- Write a program that takes two integers then prints the power.
            //Console.Write("Enter The First Number : ");
            //bool Flage01 = int.TryParse(Console.ReadLine(), out int Num01);
            //Console.Write("Enter The Second Number : ");
            //bool Flage02 = int.TryParse(Console.ReadLine(), out int Num02);
            //int Power = 1;
            //if (Flage01 && Flage02) 
            //{
            //    for (int i = 0; i < Num02; i++)
            //    {
            //        Power *= Num01;
            //    }
            //    Console.WriteLine(Power);
            //}


            #endregion

            #region Q5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.Write("Enter The First Subject : ");
            //bool Flage01 = int.TryParse(Console.ReadLine(), out int Num01);
            //Console.Write("Enter The Second Subject : ");
            //bool Flage02 = int.TryParse(Console.ReadLine(), out int Num02);
            //Console.Write("Enter The Third Subject : ");
            //bool Flage03 = int.TryParse(Console.ReadLine(), out int Num03);
            //Console.Write("Enter The Forth Subject : ");
            //bool Flage04 = int.TryParse(Console.ReadLine(), out int Num04);
            //Console.Write("Enter The Fifth Subject : ");
            //bool Flage05 = int.TryParse(Console.ReadLine(), out int Num05);
            //int Sum;
            //int Avg;
            //double Perc;

            //if (Flage01 && Flage02 && Flage03 && Flage04 && Flage05) 
            //{
            //    Sum = Num01 + Num02 + Num03 + Num04 + Num05;
            //    Avg = Sum / 5;
            //    Perc = (Sum / 500.0) * 100;

            //    Console.WriteLine($"Total Marks = {Sum}");
            //    Console.WriteLine($"Average Marks = {Avg}");
            //    Console.WriteLine($"Percentage = {Perc}%");
            //}








            #endregion

            #region Q6- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter String: ");
            //string TheString = Console.ReadLine();

            //Console.Write("Reversed String: ");
            //for (int i = TheString.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(TheString[i]);
            //}

            //Console.WriteLine();

            #endregion

            #region Q7- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter The First Subject : ");
            //bool Flage01 = int.TryParse(Console.ReadLine(), out int Num01);

            //if (Flage01) 
            //{
            //    int reversed = 0;

            //    while (Num01 != 0)
            //    {
            //        int digit = Num01 % 10;      
            //        reversed = reversed * 10 + digit;
            //        Num01 = Num01 / 10;          
            //    }
            //    Console.WriteLine($"Reversed number: {reversed}");
            //}




            #endregion

            #region Q8- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Input starting number of range: ");
            //bool Flag1 = int.TryParse(Console.ReadLine(), out int start);

            //Console.Write("Input ending number of range: ");
            //bool Flag2 = int.TryParse(Console.ReadLine(), out int end);


            //if (Flag1 && Flag2)
            //{
            //    for (int num = start; num <= end; num++)
            //    {
            //        bool isPrime = true;

            //        if (num < 2)
            //        {
            //            isPrime = false;
            //        }
            //        else
            //        {
            //            for (int i = 2; i <= num / 2; i++)
            //            {
            //                if (num % i == 0)
            //                {
            //                    isPrime = false;
            //                    break;
            //                }
            //            }
            //        }

            //        if (isPrime)
            //        {
            //            Console.Write(num + " ");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter valid integers.");
            //}


            #endregion

            #region Q9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a Decimal Number: ");
            //if (int.TryParse(Console.ReadLine(), out int num))
            //    Console.WriteLine("Binary: " + Convert.ToString(num, 2));
            //else
            //    Console.WriteLine("Invalid input!");

            #endregion

            #region Q10Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //double slope1 = (y2 - y1) / (x2 - x1);
            //double slope2 = (y3 - y2) / (x3 - x2);

            //if (slope1 == slope2)
            //    Console.WriteLine("The points lie on the same straight line.");
            //else
            //    Console.WriteLine("The points do NOT lie on the same straight line.");

            #endregion


            #region Q11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter the size of the matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        if (row == col)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
                #endregion


            }
    }
}
