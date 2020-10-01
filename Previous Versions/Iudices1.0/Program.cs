using Iudices1._0.DAL;
using System;
using Iudices1._0.Models;
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
            int numberOfJurors;
            bool success = Int32.TryParse(temp, out numberOfJurors);
            if (success)
            {
                numberOfJurors = int.Parse(temp);
                
                JuryPool juryPool = new JuryPool();
                JurySQLDAO juryDAO = new JurySQLDAO();
                RandomID randomID = new RandomID();
                int numberOfRows = juryDAO.GetRows();

                for (int i = 0; i < numberOfJurors; i++)
                {
                    
                    Juror juror = new Juror();
                    juror = juryDAO.GetJuror(randomID.getRandomID(numberOfRows));
                    juryPool.Pool.Add(juror);
                }
                Console.WriteLine();
                Console.WriteLine("Jury Pool:");
                Console.WriteLine();

                foreach (Juror juror in juryPool.Pool)
                {
                    Console.WriteLine(juror.firstName + " " + juror.lastName);
                    Console.WriteLine(juror.streetAddress);
                    Console.WriteLine(juror.city + ", " + juror.state + " " + juror.zipcode);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid whole number");
            }




            Console.ReadLine();

        }
    }
}
