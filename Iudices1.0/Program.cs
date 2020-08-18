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
            int numberOfJurors = int.Parse(temp);
            int jurorID;
            List<Juror> Pool = new List<Juror>();
            JurySQLDAO juryDAO = new JurySQLDAO();
            int numberOfRows = juryDAO.GetRows();
            var rand = new Random();
            for (int i = 0; i < numberOfJurors; i++)
            {                
                jurorID = rand.Next(numberOfRows);                
                Juror juror = new Juror();
                juror = juryDAO.GetJuror(jurorID);
                Pool.Add(juror);
            }
            Console.WriteLine();
            Console.WriteLine("Jury Pool:");
            Console.WriteLine();

            foreach (Juror juror in Pool)
            {
                Console.WriteLine(juror.firstName + " " + juror.lastName);
                Console.WriteLine(juror.streetAddress);
                Console.WriteLine(juror.city + ", " + juror.state + " " + juror.zipcode);
                Console.WriteLine();
            }



            Console.ReadLine();

        }
    }
}
