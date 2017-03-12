using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            // temp display
            foreach (Movie movie in theMovies)
            {
                movie.display();
            }
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
