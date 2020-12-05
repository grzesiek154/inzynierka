using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelTester.Serwer;
namespace HotelTester
{
    class Program
    {
        static void Main(string[] args)
        {
            IHotelService hotel = new HotelServiceClient();
           var lista=  hotel.WolnePokoje(DateTime.Now);

            foreach (var h in lista)
            {
                Console.WriteLine(h.Opis+" "+h.LiczbaOsob);
            }

            Console.ReadKey();

        }
    }
}
