using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class HotelService : IHotelService
    {
        List<Pokoj> pokoje;
        List<Rezerwacja> rezerwacje;
        public HotelService()
        {
            rezerwacje = new List<Rezerwacja>();
            pokoje = new List<Pokoj>();
            pokoje.Add(new Pokoj { LiczbaOsob = 2, Opis = "standard", wolny = true });
            pokoje.Add(new Pokoj { LiczbaOsob = 2, Opis = "standard", wolny = true });
            pokoje.Add(new Pokoj { LiczbaOsob = 2, Opis = "exclusive", wolny = true });
            pokoje.Add(new Pokoj { LiczbaOsob = 1, Opis = "premium", wolny = true });
            pokoje.Add(new Pokoj { LiczbaOsob = 12, Opis = "eco", wolny = true });
        }

        public Rezerwacja RezerwujPokoj(Rezerwacja dane)
        {
           if(pokoje.Exists(p=>p.wolny==true && p.LiczbaOsob==dane.LiczbaOsob))
            {
                dane.Akceptacja = true;
                rezerwacje.Add(dane);
                pokoje.Find(p => p.wolny == true && p.LiczbaOsob == dane.LiczbaOsob).wolny = false;
                Console.WriteLine("{0} zarezerwował pokój {1} osobowy",dane.Nazwisko,dane.LiczbaOsob);
            }
            return dane;
        }

        public List<Pokoj> WolnePokoje(DateTime data)
        {
            Console.WriteLine("Klient pyta o wolne pokoje na dzień "+data.ToLongDateString());
            return pokoje.Where(p => p.wolny).ToList();
        }
    }
}
