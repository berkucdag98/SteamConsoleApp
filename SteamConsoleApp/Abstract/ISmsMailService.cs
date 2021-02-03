using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Abstract
{
    public interface ISmsMailService
    {
        void SendSms(Customer customer,Game game);

        void SendMail(Customer customer, Game game);
    }
}
