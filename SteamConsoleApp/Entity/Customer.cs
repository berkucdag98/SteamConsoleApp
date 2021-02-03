using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConsoleApp.Entity
{
    public class Customer
    {
        public Int64 TcKimlikNo{ get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string EMail { get; set; }

        public string Password { get; set; }

        public string TelNo { get; set; }
    }
}
