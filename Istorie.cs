using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorPIU
{
    /// <summary>
    /// Rezolvare tema acasa exercitiu 1
    /// Identificarea claselor necesare pentru proiect, in cazul de fata aveam nevoie de clasa care
    /// face referire la intrebarile din mediul istoriei!
    /// </summary>
    public class Istorie
    {
        protected string denumire_intrebare;

        Istorie(string Denumire_intrebare)
        {
            denumire_intrebare = Denumire_intrebare;
        }

        public Istorie()
        {
        }

        public void MesajDeIntampinareIstorie()
        {
            Console.WriteLine("\nSalut! Tocmai ce ai ales intrebari din domeniul istoriei! Hai sa incepem! ");
        }

        void IntrebareIstorie()
        {
            ///Corpul functiei principale referitor la intrebarea de istorie
        }
    }
}
