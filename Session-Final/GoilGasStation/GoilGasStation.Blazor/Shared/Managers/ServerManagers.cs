using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.Blazor.Shared.Managers
{
    public class ServerManagers
    {
        public int GetLastDayOfMonth(int Year,int Month)
        {
            //initialize a datetime variable with ledger input
            DateTime ledgerdate = new DateTime(Year,Month,1);

            //create a datetime object to generate last day of month
            DateTime tempDate = ledgerdate.AddMonths(1);
            DateTime tempDate2 = new DateTime(tempDate.Year, tempDate.Month, 1);
            DateTime lastDayOfMonth = tempDate2.AddDays(-1);
            return lastDayOfMonth.Day;
        }
    }
}
