using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======

>>>>>>> UC2HashTable
namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Progrma!");
<<<<<<< HEAD
            Console.WriteLine("Please choose the option :\n1)Frequency of a sentence\n");
=======
            Console.WriteLine("Please choose the option :\n1)Frequency of a sentence\n" +
              "2)Frequency of a Paragraph");
>>>>>>> UC2HashTable
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

<<<<<<< HEAD

=======
                case 2:
                    HashTableMethod<string, int> hash2 = new HashTableMethod<string, int>(5);
                    string Word = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] array2 = Word.Split(' ');
                    LinkedList<string> checkForDuplication2 = new LinkedList<string>();
                    foreach (string element in array2)
                    {
                        int count = 0;
                        foreach (string match in array2)
                        {
                            if (element == match)
                            {
                                count++;
                                if (checkForDuplication2.Contains(element))
                                {
                                    break;
                                }
                            }
                        }
                        if (!checkForDuplication2.Contains(element))
                        {
                            checkForDuplication2.AddLast(element);
                            hash2.Add(element, count);
                        }
                    }
                    hash2.Display();
                    break;
>>>>>>> UC2HashTable
            }
        }
    }
}
