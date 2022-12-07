using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
            g.Opasnost();

            Console.WriteLine(g.ToString());

            Cat cat = new Cat();
            cat.Opasnost();

            Console.Write(cat.ToString());

            Console.ReadKey();
        }
    }

    class Cat
    {
        bool opasna;
        public bool Opasna { get => opasna; set => opasna = value; }

        public virtual void Opasnost()
        {
            this.Opasna = false;
        }
        public override string ToString()
        {
            return "Maca - opasnost = " + this.Opasna;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            this.Opasna = true;
        }
        public override string ToString()
        {
            return "Gepard - opasnost = " + this.Opasna;
        }
    }
}
