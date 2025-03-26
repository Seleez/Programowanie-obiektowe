using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budowniczy
{
    public class Komputer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string Storage { get; set; }
        public int RAM { get; set; }
        public string PSU { get; set; }

        public void PokażSpecyfikację()
        {
            Console.WriteLine($"Procesor: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Dysk: {Storage}");
            Console.WriteLine($"Karta Graficzna: {GPU}");
            Console.WriteLine($"Zasilacz: {PSU}");
            Console.WriteLine("=================================");
        }
    }
    public interface IKomputer
    {
        void ZbudujCPU();
        void ZbudujRAM();
        void ZbudujStorage();
        void ZbudujGPU();
        void ZbudujPSU();
        Komputer PobierzKomputer();
    }
    public class Gamingowy : IKomputer
    {
        private Komputer _komputer = new Komputer();

        public void ZbudujCPU() => _komputer.CPU = "i9 - 69999";
        public void ZbudujRAM() => _komputer.RAM = 32;
        public void ZbudujStorage() => _komputer.Storage = "3TB";
        public void ZbudujGPU() => _komputer.GPU = "RTX 6090";
        public void ZbudujPSU() => _komputer.PSU = "2000W";

        public Komputer PobierzKomputer()
        {
            return _komputer;
        }

    }
    public class Biurowy : IKomputer
    {
        private Komputer _komputer = new Komputer();

        public void ZbudujCPU() => _komputer.CPU = "i3 - 3000";
        public void ZbudujRAM() => _komputer.RAM = 8;
        public void ZbudujStorage() => _komputer.Storage = "0.5TB";
        public void ZbudujGPU() => _komputer.GPU = "Wbudowana";
        public void ZbudujPSU() => _komputer.PSU = "500W";

        public Komputer PobierzKomputer()
        {
            return _komputer;
        }

    }
    public class DyrektorPC
    {
        private IKomputer _budowniczy;

        public DyrektorPC(IKomputer budowniczy)
        {
            _budowniczy = budowniczy;
        }

        public void ZbudujPelnyKomputer()
        {
            _budowniczy.ZbudujCPU();
            _budowniczy.ZbudujRAM();
            _budowniczy.ZbudujStorage();
            _budowniczy.ZbudujGPU();
            _budowniczy.ZbudujPSU();
        }
    }

    public class Pojazd
    {
        public string Model { get; set;}
        public string Drzwi { get; set; }
        public string Ładowność { get; set; }
        public string Silnik {  get; set; }

        public void Pokaż()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Drzwi: {Drzwi}");
            Console.WriteLine($"Ładowność: {Ładowność}");
            Console.WriteLine($"Silnik: {Silnik}");
        }
    }

    public interface IPojazd
    {
        void ustawModel();
        void ustawDrzwi();
        void ustawŁadowność();
        void ustawSilnik();

        Pojazd PobierzPojazd();
    }

    public class Truck : IPojazd
    {
        private Pojazd _pojazd = new Pojazd();
        public void ustawModel() => _pojazd.Model = "SAS";
        public void ustawDrzwi() => _pojazd.Drzwi = "2";
        public void ustawŁadowność() => _pojazd.Ładowność = "15T";
        public void ustawSilnik() => _pojazd.Silnik = "v10";

        public Pojazd PobierzPojazd()
        {
            return _pojazd;
        }
    }
    public class Bus : IPojazd
    {
        private Pojazd _pojazd = new Pojazd();
        public void ustawModel() => _pojazd.Model = "School bus";
        public void ustawDrzwi() => _pojazd.Drzwi = "4";
        public void ustawŁadowność() => _pojazd.Ładowność = "2T";
        public void ustawSilnik() => _pojazd.Silnik = "v4";

        public Pojazd PobierzPojazd()
        {
            return _pojazd;
        }
    }
    public class Car : IPojazd
    {
        private Pojazd _pojazd = new Pojazd();
        public void ustawModel() => _pojazd.Model = "Audi";
        public void ustawDrzwi() => _pojazd.Drzwi = "5";
        public void ustawŁadowność() => _pojazd.Ładowność = "100KG";
        public void ustawSilnik() => _pojazd.Silnik = "v8";

        public Pojazd PobierzPojazd()
        {
            return _pojazd;
        }
    }
    public class DyrektorPojazd
    {
        private IPojazd _budowniczy;

        public DyrektorPojazd(IPojazd budowniczy)
        {
            _budowniczy = budowniczy;
        }

        public void ZbudujPojazd()
        {
            _budowniczy.ustawModel();
            _budowniczy.ustawDrzwi();
            _budowniczy.ustawŁadowność();
            _budowniczy.ustawSilnik();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IKomputer gamingowyBudowniczy = new Gamingowy();
            //DyrektorPC dyrektor = new DyrektorPC(gamingowyBudowniczy);
            //dyrektor.ZbudujPelnyKomputer();
            //Komputer gamingowyPC = gamingowyBudowniczy.PobierzKomputer();
            //gamingowyPC.PokażSpecyfikację();


            //IKomputer biuroBudowniczy = new Biurowy();
            //dyrektor = new DyrektorPC(biuroBudowniczy);
            //dyrektor.ZbudujPelnyKomputer();
            //Komputer biurowyPC = biuroBudowniczy.PobierzKomputer();
            //biurowyPC.PokażSpecyfikację();

            IPojazd truckBuilder = new Truck();
            DyrektorPojazd dyrektorP = new DyrektorPojazd(truckBuilder);
            dyrektorP.ZbudujPojazd();
            Pojazd truck = truckBuilder.PobierzPojazd();
            truck.Pokaż();

            IPojazd busBuilder = new Bus();
            dyrektorP = new DyrektorPojazd(busBuilder);
            dyrektorP.ZbudujPojazd();
            Pojazd bus = busBuilder.PobierzPojazd();
            bus.Pokaż();

            IPojazd carBuilder = new Car();
            dyrektorP = new DyrektorPojazd(carBuilder);
            dyrektorP.ZbudujPojazd();
            Pojazd car = carBuilder.PobierzPojazd();
            car.Pokaż();



        }
    }
}
