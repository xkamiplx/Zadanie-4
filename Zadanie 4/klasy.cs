using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4 {
    public abstract class Produkt : IProdukt {
        public string Nazwa { get; set; }
        public decimal CenaNetto { get; set; }
        public abstract string KategoriaVAT { get; }
        public abstract decimal CenaBrutto { get; }
        public string KrajPochodzenia { get; set; }
    }
    public class ProduktSpozywczy : Produkt {
        public override string KategoriaVAT => "Spozywczy";
        public override decimal CenaBrutto => CenaNetto * 1.23m;
        public decimal Kalorie { get; set; }
        public HashSet<string> Alergeny { get; set; }
    }
    public class ProduktSpozywczyNaWage : ProduktSpozywczy {
        public decimal Waga { get; set; }
    }

    public class ProduktSpozywczyPaczka : ProduktSpozywczy {
        public decimal Waga { get; set; }
    }
    public class ProduktSpozywczyNapoj<T> : ProduktSpozywczyPaczka {
        public T Objetosc { get; set; }
    }
    public class Wielopak<T> : IWielopak<T> where T : IProdukt {
        public T Produkt { get; set; }
        public ushort Ilosc { get; set; }
        public decimal CenaNetto { get; set; }
        public decimal CenaBrutto => Produkt.CenaBrutto * Ilosc;
        public string KategoriaVAT => Produkt.KategoriaVAT;
        public string KrajPochodzenia => Produkt.KrajPochodzenia;
    }

}
