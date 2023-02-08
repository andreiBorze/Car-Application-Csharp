using System;
using System.Collections.Generic;
using System.Text;

namespace lab7ex1
{
    public class Motor
    {
        private readonly int capacititateCilindrica;
        private readonly string combustibil;
        private readonly int putere;

        public Motor(int capacititate, string combustibil, int putere)
        {
            this.capacititateCilindrica = capacititate;
            this.combustibil = combustibil;
            this.putere = putere;
        }

        public int CapacititateCilindrica { get { return capacititateCilindrica; } } 
        public int Putere { get { return putere; } }    
        public string Combustibil { get { return combustibil; } }

        public void Pornire()
        {
            Console.WriteLine("Vhuumm Vhuum Vhumm");
        }

        public void Oprire()
        {
            Console.WriteLine("sttt sttt sttt");
        }

    }

}
