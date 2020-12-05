using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        List<Pokoj> WolnePokoje(DateTime data);

        [OperationContract]
        Rezerwacja RezerwujPokoj(Rezerwacja dane);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "HotelService.ContractType".
    [DataContract]
    public class Rezerwacja
    {
        DateTime data;
        string nazwisko;
        int liczbaOsob;
        bool akceptacja;

        [DataMember]
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        [DataMember]
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        [DataMember]
        public int LiczbaOsob
        {
            get { return liczbaOsob; }
            set { liczbaOsob = value; }
        }

        [DataMember]
        public bool Akceptacja
        {
            get { return akceptacja; }
            set { akceptacja = value; }
        }
    }

    [DataContract]
    public class Pokoj
    {

        public bool wolny { get; set; }
        [DataMember]
        public int LiczbaOsob { get; set; }
        [DataMember]
        public string Opis { get; set; }
    }
}
