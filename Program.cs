using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectLaboratorPIU;


namespace ProiectLaboratorPIU
{
    public class Program 
    {
        static void Main(string[] args)
        {
            
            if(args.Length==0)
            {
                Console.WriteLine("Linia de comanda nu contine argumente");
            }
            else
            {
                Console.WriteLine("Lenght = {0}", args.Length);
            }

            Console.WriteLine("Salut, bine ai venit la testarea cunostiintelor!");

            ProiectLaboratorPIU.Domeniu d = new Domeniu();

            //Functionalitatea programului//
            d.CeDomeniu();
        }
    }
}
