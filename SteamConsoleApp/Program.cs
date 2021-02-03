using SteamConsoleApp.Abstract;
using SteamConsoleApp.Concrete;
using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();
            SaleManager sale = new SaleManager();


            Customer customer = new Customer()
            {
                TcKimlikNo = 17935161126,
                Ad = "BERK",
                Soyad = "ÜÇDAĞ",
                DogumTarihi = new DateTime(1998, 7, 9),
                EMail = "berkda3@gmail.com",
                Password = "123456",
                TelNo = "05422110301"
            };

            Campaign campaign = new Campaign()
            {
                KampanyaAdi = "Kış İndirimi",
                IndirimOrani = 25
            };

            Game game = new Game();
            game.OyunAdi = "Cyberpunk 2077";
            game.Fiyati = 250;


            var customerResult = customerManager.Add(customer);
            campaignManager.Add(campaign);
            gameManager.Add(game);

            if (customerResult != null)
            {
                sale.KampanyalıSatinAl(customer, game, campaign);
                sale.SendSms(customer, game);
            }
            else
            {
                Console.WriteLine("Kullanıcı Bilgileri Hatalı");
            }
            Console.ReadLine();

        }
    }
}
