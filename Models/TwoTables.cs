using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Master_Detail.Models
{
    public class TwoTables
    {
        public IEnumerable<Applicant>   applicants { get; set; }

        public IEnumerable<Exprience> expriences { get; set; }
    }
}
