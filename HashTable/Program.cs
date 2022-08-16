﻿using System;
using System.Collections.Generic;
namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Progrma!");
            Console.WriteLine("Please choose the option :\n1)Frequency of a sentence\n");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    HashTableMethod<string, int> hash = new HashTableMethod<string, int>(5);
                    string Words = "To be or not to be";
                    string[] array = Words.Split(' ');
                    LinkedList<string> checkForDuplicationS = new LinkedList<string>();
                    foreach (string element in array)
                    {
                        int count = 0;
                        foreach (string match in array)
                        {
                            if (element == match)
                            {
                                count++;
                                if (checkForDuplicationS.Contains(element))
                                {
                                    break;
                                }
                            }
                        }
                        if (!checkForDuplicationS.Contains(element))
                        {
                            checkForDuplicationS.AddLast(element);
                            hash.Add(element, count);
                        }
                    }
                    hash.Display();
                    break;


            }
        }
    }
}
