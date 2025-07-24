using System;
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
        }
    }
}
