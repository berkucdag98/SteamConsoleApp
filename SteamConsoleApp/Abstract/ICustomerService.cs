using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Abstract
{
    public interface ICustomerService:ISaveService<Customer>
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
