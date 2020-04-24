using System;
using System.Collections.Generic;
using System.IO;

#pragma warning disable CS0219  // Variable is assigned but its value is never used
#pragma warning disable CS0168  // Variable is declared but never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE0051 // Remove unused private members

namespace CSharpForDummies
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            /*
            * Types && Operators
            * Console IO
            * 
            * Fråga efter namn ålder och sedan skriv ut.
            * 
            * Conditions
            * Arrays && Collections
            * Loops
            * 
            * Skapa en array med 64 slumpmässigt genererade nummer 
            * Random rand = new Random();
            * rand.Next(min, max)
            * 
            * Sortera array med bubble sort
            * 
            * 
            * Methods 
            * Enums && struct
            * OOP
            * File IO
            * 
            * Skapa en arbets grupp på 4 personer som sparas i en lista
            * Där varje arbetare ska ha ett namn, ålder, kön, lön,              
            * Som sedans sparas till en fil och läsas från fil
            * 
            * 
            * Inheritance?
            * Abstract? C#?
            * Interface?
            * 
            * Threads?
            * Async compute????
            * 
            * 
            */

            //Steg1();
            //Steg2();
            Steg3();
            //Uppgift1();
            //Steg4();
            //Steg5();
            //Steg6();
            //Steg7();
            int nummerfrånplc = 0;
            switch (nummerfrånplc)
            {
                case 10:
                    //Gör saker
                    

                    break;
                default:
                    break;
            }

            int i = Add(1, 4);
            Console.WriteLine(i);
            string name;
            int age = 0;

            Console.WriteLine("Whats your name?");
            while ((name = Console.ReadLine()) == string.Empty) 
            {
                if (name == string.Empty)
                    Console.WriteLine("Please Enter your name...");
            }
            
            Console.WriteLine("Whats your age?");
            while (age == 0)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Please Enter an number...");
                }
            }
            
            Console.WriteLine("Your name is " + name + " and your age is: " + age);
        }


        //-------------------------------------------------------
        private static void Steg1() // Types && operators
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

            int testInteger = -1230;
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
            testInteger--;
            testInteger += 10 * 5 + 5;


            Console.WriteLine(testInteger);

            testString += testCharacter;

            Console.WriteLine(testString);

            testString = Console.ReadLine();
            Console.WriteLine("Your input was :" + testString);

            //Conversion
            //ui = (int)i;
            //i = (int)ui;


        }

        //-------------------------------------------------------
        private static void Steg2() // Conditions
        {
            int testInteger = 0;

            if (testInteger == 0)
            {
                Console.WriteLine("Hello");
            }
            else if (testInteger == 1)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Undefined");
            }


            switch (testInteger)
            {
                case 0:
                    Console.WriteLine("Hello");
                    break;
                case 1:
                    Console.WriteLine("Goodbye");
                    break;
                case 2:
                    Console.WriteLine("Hello");
                    break;
                default:
                    break;
            }


            bool testBool = true;

            int testInt;
            if (testBool)
            {
                testInt = 1;
            }
            else
            {
                testInt = 2;
            }

            testInt = testBool ? 1 : 2;

        }

        //-------------------------------------------------------
        private static void Steg3() // arrays && Collections && loops
        {

            int[] array0;
            int[] array1 = new int[3];
            int[] array2 = new int[3] { 1, 2, 3 };
            int[] array3 = new int[3] { 3, 2, 1 };
            int[] array4 = new int[3] { 2, 3, 1 };

            
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
                float f = 0.0f;
                int j = (int)f;
                genericCollection.Add((int)Math.Pow(i, 2));
            }

            genericCollection.RemoveAt(4); // tar bort det femte elementet
            genericCollection.Sort();
            //LinkedList
            //Dictionary
            //SortedList
            //Hashset
            //Queue
            //Stack
        }

        //-------------------------------------------------------
        private static void Uppgift1()
        {
            int[] array = new int[64];

            Random rand = new Random();

            //Generara slumpade nummer och fyller upp array.

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next() % 1000 + 1;
            }

            PrintArray(array);
            bool isSorted = false;
            //Sortera array med bubble sort
            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        isSorted = false;
                    }
                }
            }

            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine();
        }

        //-------------------------------------------------------
        private static void Steg4() // metoder
        {
            DoSomething();

            int integer = GetInt();
            Console.WriteLine(integer);

            int integer2 = Add(integer, 2);
            Console.WriteLine(integer2);
        }

        private static void DoSomething() // "Block"
        {
            //Do Something...
        }

        private static int GetInt()
        {
            return 1;
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        //-------------------------------------------------------
        private enum Gender
        {
            Male,
            Female,
            Other
        }

        private struct Person
        {
            public string Name;
            public int Age;
            public Gender Gender;

            private int m_test;
            private int m_test2;
        }

        private static void Steg5() // enums && structs
        {
            Person person;
            person.Name = "Gustav";
            person.Age = 22;
            person.Gender = Gender.Other;
        }

        //-------------------------------------------------------
        private static void Steg6()
        {
            Arbetare fredrik = new Arbetare("Fredrik", 18);
            Arbetare joel = new Arbetare("Joel", 55, 55000);

            Console.WriteLine(fredrik.ToString());

            fredrik.SetAge(19);
            fredrik.Raise(500);

            Console.WriteLine(fredrik.ToString());
        }

        //-------------------------------------------------------
        private static void Steg7() //File IO
        {
            string path = @"TestFile.txt";


            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello World");
            }



            string lineInput;
            using (StreamReader sr = File.OpenText(path))
            {
                while ((lineInput = sr.ReadLine()) != null)
                {
                    Console.WriteLine(lineInput);
                }

            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Test");
            }

        }
        //-------------------------------------------------------
    }
}
