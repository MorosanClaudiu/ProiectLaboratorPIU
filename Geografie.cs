using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorPIU
{
    /// <summary>
    /// Rezolvare tema acasa exercitiu 1
    /// Identificarea claselor necesare pentru proiect, in cazul de fata aveam nevoie de clasa care
    /// face referire la intrebarile din mediul geografiei!
    /// </summary>
    public class Geografie
    {
        protected string denumire_intrebare;

        Geografie(string Denumire_intrebare)
        {
            denumire_intrebare = Denumire_intrebare;
        }

        public Geografie()
        {
        }

        public async void MesajDeIntampinareGeografie()
        {
            Console.WriteLine("\nSalut! Tocmai ce ai ales intrebari din domeniul geografiei ! Hai sa incepem! ");
        }


        void IntrebareGeografie()
        {
            ///Corpul functiei principale referitor la intrebarea de geografie
        }

    }
}
