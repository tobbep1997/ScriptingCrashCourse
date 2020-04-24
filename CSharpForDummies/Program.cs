using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using CSharpForDummies.Classes;
using System.Text;

#pragma warning disable CS0219  // Variable is assigned but its value is never used
#pragma warning disable CS0168  // Variable is declared but never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE0051 // Remove unused private members

namespace CSharpForDummies
{
    internal class Program
    {
        private static int Main(string[] args)
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
            //Steg3();
            
            //Steg4();
            //Steg5();
            //Steg6();
            //Steg7();
            try
            {
                //Steg8();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Steg9();
            //Uppgift1();
            Uppgift2();
            return 0;
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
            Console.WriteLine("Allocating memory");
            int[] array = new int[100000];

            Random rand = new Random();

            //Generara slumpade nummer och fyller upp array.
            Console.WriteLine("Generating numbers");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }
            Console.WriteLine("Start sorting");
            //PrintArray(array);
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
            Console.WriteLine("Sorting completed");
            //PrintArray(array);
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
        private static void Uppgift2()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            List<Arbetare> arbetare = new List<Arbetare>();
            for (int i = 0; i < 10; i++)
            {
                arbetare.Add(new Arbetare(Encoding.ASCII.GetString(BitConverter.GetBytes(i.GetHashCode())), rand.Next(18, 65), rand.Next(30000, 65000)));
            }

            string path = @"Arbetare.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(arbetare.Count);
                for (int i = 0; i < arbetare.Count; i++)
                {
                    sw.WriteLine(arbetare[i].GetName().ToString());
                    sw.WriteLine(arbetare[i].GetAge().ToString());
                    sw.WriteLine(arbetare[i].Salary.ToString());
                }
                sw.Close();
            }

            arbetare.Clear();

            using (StreamReader sr = File.OpenText(path))
            {
                int antalArbetare = Convert.ToInt32(sr.ReadLine());

                for (int i = 0; i < antalArbetare; i++)
                {
                    string name = sr.ReadLine();
                    int age = Convert.ToInt32(sr.ReadLine());
                    int salary = Convert.ToInt32(sr.ReadLine());
                    arbetare.Add(new Arbetare(name, age, salary));
                }
                
            }

            for (int i = 0; i < arbetare.Count; i++)
            {
                Console.WriteLine(arbetare[i].ToString());
            }
        }
        //-------------------------------------------------------
        private static void Steg8() // Inheritance
        {
            Base b = new TestClass(123u);
            TestClass t = new TestClass(123u);

            Base b2 = new TestClass2(1234u);

            Exception exception = null;

            try
            {
                ((TestClass)b).TestClassFunction();
            }
            catch (Exception e)
            {
                exception = e;
            }

            try
            {
                ((TestClass2)b).TestClass2Function();
            }
            catch (Exception e)
            {
                exception = e;
            }

            if (exception != null)
                throw exception;


        }
        //-------------------------------------------------------
        private static void Steg9() // Threads
        {
            Thread thread = new Thread(new ThreadStart(ThreadTest));
            thread.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("This is the main thread {0}", i + 1);
            }
            
            
            thread.Join();
        }

        private static void ThreadTest()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("This is the thread {0}", i + 1);
            }
        }
    }
}
