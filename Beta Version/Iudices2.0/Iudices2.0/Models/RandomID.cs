using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iudices2._0.Models
{
    public class RandomID
{
    private Random rand = new Random();
    public int getRandomID(int numberOfRows)
    {
        int result = rand.Next(numberOfRows); ;
        return result;
    }
}
}
