using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Abstract
{
    public interface ISaleService
    {
        void SatinAl(Customer customer,Game game);

        void KampanyalıSatinAl(Customer customer,Game game,Campaign campaign);
    }
}
