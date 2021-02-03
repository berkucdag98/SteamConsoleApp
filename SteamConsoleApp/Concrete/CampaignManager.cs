using SteamConsoleApp.Abstract;
using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Concrete
{
    public class CampaignManager : ISaveService<Campaign>
    {

        public Campaign Add(Campaign entity)
        {
            Console.WriteLine(entity.KampanyaAdi + " isimli kampanya sisteme tanımlandı!!!");
            return entity;
        }

        public Campaign Delete(Campaign entity)
        {
            throw new NotImplementedException();
        }


        public Campaign Update(Campaign entity)
        {
            throw new NotImplementedException();
        }
    }
}
