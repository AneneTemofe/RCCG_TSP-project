using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCCG_TSP_CRM.Models
{
    public class Departments : BaseClass
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
