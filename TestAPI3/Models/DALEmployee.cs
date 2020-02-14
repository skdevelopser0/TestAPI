using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI3.Models
{
    public class DALEmployee : IDALEmployee
    {
        public BOEmployee getEmployeeDetails()
        {
            return new BOEmployee
            {
                EmpId = 101,
                EmpName = "sanjeev",
                EmpAddress = "H12, Green Park"
            };
        }
    }
}