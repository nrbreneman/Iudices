using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iudices1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of Jurors need for this pool:");
            string temp = Console.ReadLine();
            int numberOfJurors = int.Parse(temp);
            var rand = new Random();
            //This will out put rosterIDs to be run against the DB Currently displays them to console 
            for (int ctr = 1; ctr <= numberOfJurors; ctr++)
                Console.WriteLine("{0,8:N0}", rand.Next(2001));
            Console.ReadLine();
            
        }
    }
}
