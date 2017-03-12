using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSC240_WCFMS01
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0; // to keep track of the number of movies

            // Create a temporary array that has a pretty big length
            Movie[] tempMovies = new Movie[50];

            // initialize each of the objects in tempMovies
            for(int i = 0; i < 50; i++)
            {
                tempMovies[i] = new Movie();
            }

            // Read in at least one Movie
            tempMovies[count].readIn();
            count++;

            // prompt the user to see if they want to enter another Movie
            Console.WriteLine("\nWould you like to eneter another movie (yes/no)?");
            string anotherMovie = Console.ReadLine().ToUpper();

            // check to see if the user input is valid
            while(!anotherMovie[0].Equals('Y') && !anotherMovie[0].Equals('N'))
            {
                Console.WriteLine("\nInvalid Input. \nPlease try again (yes/no)?");
                anotherMovie = Console.ReadLine().ToUpper();
            }

            // Loop through the reading of movies as long as the 
            //user wants to keep entering them
            while(anotherMovie[0] == 'Y')
            {
                tempMovies[count].readIn();
                count++;

                Console.WriteLine("\nWould you like to eneter another movie (yes/no)?");
                anotherMovie = Console.ReadLine().ToUpper();
            }

            // Create a new array with the a set size and fill it with the movies
            Movie[] theMovies = new Movie[count];
            for(int i = 0; i < theMovies.Length; i++)
            {
                theMovies[i] = tempMovies[i];
            }

            // Sort the array of Movie objects
            bubbleSort(theMovies);

            // present the menu for user to choose from
            // and process their choice
            bool terminate = false;
            do
            {
                bool validChoice = false;
                int userChoice = 0;
                do
                {
                    Console.Write("\nWEST CHESTER FABULOUS MOVIE SOCIETY DATA MENU\n"
                                 + "1 - Display the titles of all the movies\n"
                                 + "2 - Display the data for a specific movie\n"
                                 + "3 - Display the titles of all the movies released in a given year\n"
                                 + "4 - Display the titles of all the movies with a particular star\n"
                                 + "5 - Quit the program\n");
                    userChoice = Convert.ToInt32(Console.ReadLine());

                    if (userChoice != 1 ||
                        userChoice != 2 ||
                        userChoice != 3 ||
                        userChoice != 4 ||
                        userChoice != 5)
                    {
                        validChoice = true;
                    }

                } while (!validChoice);

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("NOT IMPLEMENTED YET!!!!");
                        break;
                    case 2:
                        Console.WriteLine("NOT IMPLEMENTED YET!!!!");
                        break;
                    case 3:
                        Console.WriteLine("NOT IMPLEMENTED YET!!!!");
                        break;
                    case 4:
                        Console.WriteLine("NOT IMPLEMENTED YET!!!!");
                        break;
                    case 5:
                        Console.WriteLine("\nAre you sure (Y/N)?");
                        string exitChoice = Console.ReadLine().ToUpper();
                        if (exitChoice[0] == 'Y')
                        {
                            terminate = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nNot a valid choice. Please choose again.");
                        break;
                }
            } while (!terminate);
        }

        // sorts an array of Movie objects using bubble sort
        public static void bubbleSort(Movie[] array)
        {
            bool swapped = true;
            int j = 0;
            Movie temp;

            while(swapped)
            {
                swapped = false;
                j++;

                for (int i = 0; i < array.Length - j; i++)
                {
                    if (String.Compare(array[i].getTitle(), array[i + 1].getTitle()) > 0)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }
            }
        }
    }
}
