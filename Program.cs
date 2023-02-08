using System;

namespace lab7ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Câte autoturisme doriți să introduceți?");
            int numberDeAutoturisme = Convert.ToInt32(Console.ReadLine());

            Autoturism[] autoturisme = new Autoturism[numberDeAutoturisme];            

            for (int i = 0; i < numberDeAutoturisme; i++)
            {
                Console.WriteLine("Introduceți detaliile autoturismului " + (i + 1) + ":");
                Console.WriteLine("Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Anul fabricației: ");
                int an = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Capacitatea motorului: ");
                int capacititate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tipul combustibilului: ");
                string combustibil = Console.ReadLine();
                Console.WriteLine("Puterea motorului: ");
                int putere = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numărul de uși: ");
                int numarUsi = Convert.ToInt32(Console.ReadLine());

                autoturisme[i] = new Autoturism(marca, model, an, new Motor(capacititate, combustibil, putere), numarUsi);
            }

            foreach(var auto in autoturisme)
            {
                Console.WriteLine("Descrierea autoturismului: " + auto.GetDescriere());

                Console.WriteLine("Pornirea autoturismului... ");
                auto.Porneste();

                Console.WriteLine("Oprirea autoturismului... ");
                auto.Opreste();
            }



            Console.WriteLine("Numărul total de autoturisme create: " +  Autoturism.nrTotalAutoturisme);
            Console.WriteLine("Cel mai puternic autoturism: " + Autoturism.powerfulCar.GetDescriere());

            Console.ReadLine();
        }
    }
}
