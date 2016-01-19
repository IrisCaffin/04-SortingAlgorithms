using System;
// add using System.IO so that it can read from that namespace
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading file..");
            int[] list = readFromFile();
            Console.WriteLine("File loaded.");
            Console.WriteLine("Choose a sorting algorithm");
            Console.WriteLine();
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bubbleSort(list);
                    break;
                case "2":
                    insertionSort(list);
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
        
        // <return_type> <name_of_method>() {}
        static int[] readFromFile()
        {
            // implement file read here
            string fileContents = File.ReadAllText("C:\\dev\\data\\unsorted-numbers.txt");

            // unseparate (split) the numbers from the comma's so that you'll end up with string values
            string[] numbersAsString = fileContents.Split(',');


                    /* incase of the following example
                    string story = "The brown fox jumped";
                    string word = story.Split(' ');
                    the result of this would be ["The", "brown", "fox", "jumped"]
                    if you would have included brackets like below
                    string[] word = story.Split(' ');
                    it would select every single character, even spaces */


            /* I now have the numbers in a string in an array and need to convert that into an integer array
            I basically need to create a new integer array
            I have this string array and now I need to create an empty array
            so I can take each one step by step, convert that into an integer and put that in my array
            first thing to do is to make that array on the left hand side
            basically creating a new integer array and the size of this array has to match the size of the string array
            so if I have a hundred numbers, I have a new empty array with a hundred spaces */
            int[] numbers = new int[numbersAsString.Length];

            // now use the for-loop to loop through the string list below
            for(int i = 0; i < numbersAsString.Length; i++)
            {
                // on the numbers "shelve" take the numbers from the string list and put it through int.parse
                // and parse it to the new array
                // the letter i is just like a finger, a robotic arm
                numbers[i] = int.Parse(numbersAsString[i]);
            }

            return numbers;

        }

        static void bubbleSort(int[] list)
        {
            printList("Unsorted List", list);

            // implement bubble sort here

            for (int i = list.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        //we swap
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }


            printList("Sorted list", list);
        }

        static void insertionSort(int[] list)
        {
            printList("Unsorted List", list);

            // implement insertion sort here


            printList("Sorted list", list);
        }

        static void printList(string listName, int[] list)
        {
            Console.WriteLine("-- " + listName + " --");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
