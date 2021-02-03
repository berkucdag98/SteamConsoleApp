using SteamConsoleApp.Abstract;
using SteamConsoleApp.CheckServiceReference;
using SteamConsoleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Concrete
{
    public class CustomerManager : ICustomerService
    {

        public Customer Add(Customer entity)
        {
            if (CheckIfRealPerson(entity) == true)
            {
                Console.WriteLine("Kayıt Başarılı");
                return entity;
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bilgiler Giriniz!");
                return null;
            }

        }

        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient servis = new KPSPublicSoapClient();
            bool result = servis.TCKimlikNoDogrula(Convert.ToInt64(customer.TcKimlikNo), customer.Ad.ToUpper(), customer.Soyad.ToUpper(), customer.DogumTarihi.Year);
            return result;
        }

        public Customer Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
