using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI3.Models
{
    public class BALEmployee : IBALEmployee
    {
        private IDALEmployee _DALEmployee;

        public BALEmployee(IDALEmployee DALEmployee)
        {
            _DALEmployee = DALEmployee;
        }


        public BOEmployee getEmployeeDetails()
        {
            return _DALEmployee.getEmployeeDetails();
        }


    }
}