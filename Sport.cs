using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProiectLaboratorPIU
{
    /// <summary>
    /// Rezolvare tema acasa exercitiu 1
    /// Identificarea claselor necesare pentru proiect, in cazul de fata aveam nevoie de clasa care
    /// face referire la intrebarile din mediul sporturilor!
    /// </summary>
    public class Sport
    {
        protected string denumire_intrebare;
        private string numeFisier;

        /*
        public void DeschidFisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        */

        public Sport()
        {

        }
        
        Sport(string Denumire_intrebare)
        {
            denumire_intrebare = Denumire_intrebare;
        }


        public void MesajDeIntampinareSport()
        {
            Console.WriteLine("\nSalut! Tocmai ce ai ales intrebari din domeniul sporturilor! Hai sa incepem! ");
        }

        public void Cauta()
        {
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextSport.txt"))
            {
                if(line == "Ronaldo")
                {
                    System.Console.WriteLine(line);
                }
            }
        }
        
        void IntrebareSport()
        {
            ///Corpul functiei principale referitor la intrebarea de sport
        }
    }
}
