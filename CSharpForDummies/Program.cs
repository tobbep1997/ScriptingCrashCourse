using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable CS0219  // Variable is assigned but its value is never used
#pragma warning disable CS0168  // Variable is declared but never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE0051 // Remove unused private members

namespace CSharpForDummies
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Types && Operators
             * Console IO
             * Conditions
             * Arrays && Collections
             * Loops
             * 
             * Skapa en array med 64 slumpmässigt genererade nummer
             * Sortera array med bubble sort
             * Använd IsSorted(int[] array)
             * 
             * Methods 
             * Enums && struct
             * OOP
             * 
             * Skapa en arbets grupp på 25 personer som sparas i en lista
             * Där varje arbetare ska ha ett namn, ålder, kön, lön,              
             *  
             * 
             * Inheritance?
             * Abstract? C#?
             * Interface?
             * 
             * Threads?
             * Async compute????
             * File IO
             * 
             */

            //Steg1();
            //Steg2();
            //Steg3();

            //Uppgift1();

            //Steg4();
            Steg5();

            Steg6();


        }





        static void Steg1() // Types && operators
        {
            //Olika typer

            //bool
            //int, uint = 1, 2, ... 
            //short, byte = 1, 2, ...
            //float, double = 3.14
            //string, char = "Hello World"
            //var = 

            //Måste starta med en bokstav

            //Lokala variabler

            bool testBool = true;

            int testInteger = 0;
            uint testUnsingedInteger = 123;

            float testFloat = 3.14f;
            double testDouble = 3.14;

            string testString = "Hello Worl";
            char testCharacter = 'd';

            //Operators =, 
            //==, !=, &&, ||
            // >, <, >=, <=
            //+, -, *, /, %
            //+=, -=, *=, /=, %=
            //++, --
            //!

            testInteger += 10*5+5;
            
            Console.WriteLine(testInteger);

            testString += testCharacter;

            Console.WriteLine(testString);

            //Conversion
            //ui = (int)i;
            //i = (int)ui;



        }

        static void Steg2() // Conditions
        {
            bool testBool1 = true, testBool2 = false;

            testBool2 = !testBool2;

            if (testBool1 == testBool2)
            {
                Console.WriteLine("Hello World");
            }
            else
            {
                Console.WriteLine("Goodbye World");
            }

            int testInt = testBool1 ? 1 : 2;

        }

        static void Steg3() // arrays && Collections && loops
        {

            int[] array0;
            int[] array1 = new int[3];
            int[] array2 = new int[3] { 1, 2, 3 };
            int[] array3 = new int[3] { 3, 2, 1 };
            int[] array4 = new int[3] { 3, 2, 1 };
                         

            int[,] tvåDimArray = new int[3, 4];

            int index = 0;

            Console.WriteLine("Array 1");

            while (index < array1.Length)
            {
                Console.WriteLine(array1[index]);
                index++;
            }

            Console.WriteLine("Array 2");

            index = 0;

            do
            {
                Console.WriteLine(array2[index]);
            } while (++index < array2.Length);

            Console.WriteLine("Array 3");

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }

            Console.WriteLine("Array 4");

            foreach (var item in array4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Två dimentioner");

            for (int i = 0; i < tvåDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < tvåDimArray.GetLength(1); j++)
                {
                    tvåDimArray[i, j] = i * j + 1;
                }
            }

            List<int> genericCollection = new List<int>();

            for (int i = 0; i < 64; i++)
            {
                genericCollection.Add((int)Math.Pow(i, 2));
            }

            genericCollection.RemoveAt(4); // tar bort det femte elementet

            //LinkedList
            //Dictionary
            //SortedList
            //Hashset
            //Queue
            //Stack
            

            
        }

        static void Uppgift1()
        {
            int[] array = new int[64];

            Random rand = new Random();

            //Generara slumpade nummer och fyller upp array.

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next() % 1000 + 1;                
            }

            PrintArray(array);

            //Sortera array med bubble sort
            while (!IsSorted(array))
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }

            PrintArray(array);
        }
        static bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            return true;
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                    Console.Write(array[i] + ", ");
                else
                    Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }

        static void Steg4() // metoder
        {
            DoSomething();

            int integer = GetInt();
            Console.WriteLine(integer);

            int integer2 = Add(integer, 2);
            Console.WriteLine(integer2);
        }
        static void DoSomething() // "Block"
        {
            //Do Something...
        }
        static int GetInt()
        {
            return 1;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        enum Gender
        {
            Male,
            Female,
            Other
        }
        struct Person
        {
            public string name;
            public int age;
            public Gender gender;

            private int test;
            int test2;
        }

        static void Steg5() // enums && structs
        {
            Person person;
            person.name = "Gustav";
            person.age = 22;
            person.gender = Gender.Other;
        }

        static void Steg6()
        {
            Arbetare fredrik = new Arbetare("Fredrik", 18);
            Arbetare joel = new Arbetare("Joel", 55, 55000);

            Console.WriteLine(fredrik.ToString());

            fredrik.SetAge(19);
            fredrik.Raise(500);

            Console.WriteLine(fredrik.ToString());
            

        }

    }
}
