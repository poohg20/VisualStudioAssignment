using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSC_Folder
{
    public class FullTimeEmployee : BaseEmployee
    {
        public int AnnualSalary {get; set;}
        
        public override int GetMonthlySalary()
        {
            return this.AnnualSalary/12;
        }
        
    }
}    