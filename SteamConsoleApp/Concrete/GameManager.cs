using SteamConsoleApp.Abstract;
using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Concrete
{
    public class GameManager : ISaveService<Game>
    {
        

        public Game Add(Game entity)
        {
            Console.WriteLine($"{entity.OyunAdi} Sisteme Eklendi. Fiyat: {entity.Fiyati} TL");
            return entity;
        }


        public Game Delete(Game entity)
        {
            throw new NotImplementedException();
        }

        public Game Update(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
