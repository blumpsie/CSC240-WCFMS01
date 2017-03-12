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
            Movie aMovie = new Movie();
            aMovie.readIn();
            aMovie.display();
        }
    }
}
