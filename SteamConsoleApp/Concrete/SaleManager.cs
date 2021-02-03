using SteamConsoleApp.Abstract;
using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Concrete
{
    public class SaleManager : ISaleService,ISmsMailService
    {
        public void KampanyalıSatinAl(Customer customer, Game game, Campaign campaign)
        {
            
            var price = game.Fiyati - (game.Fiyati * (campaign.IndirimOrani / 100));

            Console.WriteLine($"Sayın {customer.Ad} {customer.Soyad} {game.OyunAdi} isimli oyunu {campaign.KampanyaAdi} kampanyasını kullanarak kütüphanenize eklediniz. Fiyat: {price} TL");
        }

        public void SatinAl(Customer customer, Game game)
        {
            Console.WriteLine($"Sayın {customer.Ad} {customer.Soyad} {game.OyunAdi} isimli oyunu kütüphanenize eklediniz. Fiyat: {game.Fiyati} TL");
        }

        public void SendMail(Customer customer,Game game)
        {
            var kod = RandomString();
            Console.WriteLine($"Mail => {customer.EMail} Sayın {customer.Ad} {customer.Soyad} {game.OyunAdi} isimli oyun için aktivasyon kodunuz:{kod}");
        }

        public void SendSms(Customer customer, Game game)
        {
            var kod = RandomString();
            Console.WriteLine($"Tel No => {customer.TelNo} Sayın {customer.Ad} {customer.Soyad} {game.OyunAdi} isimli oyun için aktivasyon kodunuz:{kod}");
        }

        private static Random random = new Random();
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
