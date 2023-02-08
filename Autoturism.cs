using System;
using System.Collections.Generic;
using System.Text;

namespace lab7ex1
{
    public class Autoturism
    {

        public static int nrTotalAutoturisme { get; private set ; }
        public static Autoturism powerfulCar { get; private set; }

        private readonly string marca;
        private readonly string model;
        private readonly int anDeFabricatie;
        private readonly Motor motor;
        private Usa[] usi;

        private void InregistrareAutoturism(Autoturism autoturism)
        {
            nrTotalAutoturisme++;

            if(powerfulCar == null || autoturism.motor.Putere > powerfulCar.motor.Putere)
            {
                powerfulCar = autoturism;
            }
        }
        public Autoturism(string marca, string model, int an, Motor motor, int numarDeUsi)
        {
            this.marca = marca;
            this.model = model;
            this.anDeFabricatie = an;
            this.motor = motor;

            usi = new Usa[numarDeUsi];
            for(var i = 0; i < numarDeUsi; i++)
            {
                usi[i] = new Usa();
            }

            InregistrareAutoturism(this);
        }

        public string GetDescriere()
        {
            return $"Marca: {marca}, Model: {model}, An de fabricatie: {anDeFabricatie}, Capacitate cilindrica: {motor.CapacititateCilindrica}, Combustibil: {motor.Combustibil}, Putere motor: {motor.Putere}, Numar de usi: {usi.Length}";
        }

        public void Porneste()
        {
            Console.WriteLine("Masina porneste");
            foreach (var usa in usi)
            {
                usa.Inchide();
            }
            motor.Pornire();
            Console.WriteLine("Masina este pornita");
        }

        public void Opreste()
        {
            Console.WriteLine("Masina se opreste");
            motor.Oprire();
            foreach (var usa in usi)
            {
                usa.Inchide();
            }
            Console.WriteLine("Masina s-a oprit");
        }
    }
}
