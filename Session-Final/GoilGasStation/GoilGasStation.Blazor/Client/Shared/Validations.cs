﻿using GoilGasStation.Blazor.Shared.ViewModels;

namespace GoilGasStation.Blazor.Client.Shared
{
    public class Validations
    {
        public bool Validate(CustomerEditViewModel CustomerItem)
        {
            if (CustomerItem.Name is not null && CustomerItem.Surname is not null && CustomerItem.CardNumber is not null && CustomerItem.CardNumber[0] == 'A'
            && CustomerItem.CardNumber.Count() == 6)
            {
                return true;
            }
            else return false;
            
        }
        public bool Validate(EmployeeViewModel employeeViewModel)
        {

            return true;
        }
    }
}
