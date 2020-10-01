using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iudices3.Models
{
    public class JuryPool
    {
        public List<Juror> Pool = new List<Juror>();

        public int juryID;

        public string juryName;

        public string juryCity;
    }
}
