using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelService;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelService.HotelService serwis = new HotelService.HotelService();
            // tak robimy gdy serwis pracuje w trybie Single
            ServiceHost host = new ServiceHost(serwis);

            // tak w trybie PerSession i PerCall
            //ServiceHost host = new ServiceHost(typeof(HotelService.HotelService));

            Console.WriteLine("Uruchamiam serwer");
            host.Opened += Host_Opened;
            host.Open();

            Console.WriteLine("Naciśnij klawisz to zatrzymam serwer.");
            Console.ReadKey();



        }

        private static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("HotelService Serwer działa :)");
        }
    }
}
