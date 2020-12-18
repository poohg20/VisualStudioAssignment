using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSC_Folder
{
    public class ContractEmployee : BaseEmployee
    {
        public int HourlyPay {get; set;}
        public int TotalHours {get; set;}

        public override int GetMonthlySalary()
        {
            return this.TotalHours* this.HourlyPay;
        }
        
    }
}    