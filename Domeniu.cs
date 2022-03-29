using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectLaboratorPIU;

namespace ProiectLaboratorPIU
{
    /// <summary>
    /// Rezolvare tema acasa exercitiu 1
    /// Identificarea claselor necesare pentru proiect, in cazul de fata aveam nevoie de clasa care
    /// de baza pentru toate domeniile!
    /// </summary>
    public class Domeniu
    {
        protected string denumire;

        Domeniu(string Denumire)
        {
            denumire = Denumire;
        }

        public Domeniu()
        {
        }

        ProiectLaboratorPIU.Geografie G = new Geografie();
        ProiectLaboratorPIU.Istorie I = new Istorie();
        ProiectLaboratorPIU.Sport S = new Sport();


        public void CeDomeniu()
        {

            string[][] tabou_scara = new string[][] { new string[] { "r", "o", "n","a","l","d","o" }, new string[] {  "P","S","G" } };

            int counter = 0;
            string rg1;
            string ri1;
            string rs1;
            
            
                do
            {
                Console.WriteLine("Tastati 'geografie' pentru a alege intrebari din domeniul geografiei!");
                Console.WriteLine("Tastati 'istorie' pentru a alege intrebari din domeniul istoriei!");
                Console.WriteLine("Tastati 'sport' pentru a alege intrebari din domeniul sportului!");


                Console.Write("\nAici introduce utilizatorul optiunea sa!\n ->");

                /// Rezolvare tema acasa exercitiul 1 prima parte.
                /// Citirea datelor de la tastatura pentru furnizarea meniului
                denumire = Console.ReadLine();
                denumire = denumire.ToLower();
                switch (denumire)
                {
                    
                    case "geografie":
                        int punctajG = 0;

                            ///Apelez clasa Referitoare la intrebarile despre Geografie
                            G.MesajDeIntampinareGeografie();

                            Console.WriteLine("Press any key to continue!");
                            //Console.ReadKey();

                        foreach (string line in System.IO.File.ReadLines(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextGeografie.txt"))
                        {
                            System.Console.WriteLine(line);
                            counter++;
                        }

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU PRIMA INTREBARE A, B C sau D -> ");
                        rg1 = Console.ReadLine();
                        rg1 = rg1.ToUpper();

                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextGeografie.txt"))
                        {
                            writer.WriteLine(rg1);
                        }
                       
                        if (rg1 == "A" || rg1 == "C" || rg1 == "D")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (rg1 == "B")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajG += 1;
                        }


                        //System.Console.WriteLine("Ai citit cu succes atatea linii {0} din fisierul .text!", counter);
                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajG);

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A DOUA INTREBARE A, B C sau D -> ");
                        rg1 = Console.ReadLine();
                        rg1 = rg1.ToUpper();
                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextGeografie.txt"))
                        {
                            writer.WriteLine(rg1);
                        }

                        if (rg1 == "A" || rg1 == "C" || rg1 == "B")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (rg1 == "D")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajG += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajG);

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A TREIA INTREBARE A, B C sau D -> ");
                        rg1 = Console.ReadLine();
                        rg1 = rg1.ToUpper();
                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextGeografie.txt"))
                        {
                            writer.WriteLine(rg1);
                        }

                        if (rg1 == "A" || rg1 == "C" || rg1 == "C")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (rg1 == "B")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajG += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajG);

                        Console.WriteLine("Press any key to continue");
                        System.Console.ReadLine();

                        break;

                    case "istorie":
                        int punctajI = 0;

                            ///Apelez clasa Referitoare la intrebarile despre Istorie
                            I.MesajDeIntampinareIstorie();
                            Console.WriteLine("Press any key to continue!");
                            Console.ReadKey();

                        foreach (string line in System.IO.File.ReadLines(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextIstorie.txt"))
                        {
                            System.Console.WriteLine(line);
                            counter++;
                        }

                        //System.Console.WriteLine("Ai citit cu succes atatea linii {0} din fisierul .text!", counter);

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A PRIMA INTREBARE A, B C sau D -> ");
                        ri1 = Console.ReadLine();
                        ri1 = ri1.ToUpper();
                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextIstorie.txt"))
                        {
                            writer.WriteLine(ri1);
                        }

                        if (ri1 == "A" || ri1 == "C" || ri1 == "B")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (ri1 == "D")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajI += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajI);

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A DOUA INTREBARE A, B C sau D -> ");
                        ri1 = Console.ReadLine();
                        ri1 = ri1.ToUpper();
                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextIstorie.txt"))
                        {
                            writer.WriteLine(ri1);
                        }

                        if (ri1 == "D" || ri1 == "C" || ri1 == "B")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (ri1 == "A")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajI += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajI);
                        ///salvarea datelor in fisier text /// scriere in fisier
                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A TREIA INTREBARE A, B C sau D -> ");
                        ri1 = Console.ReadLine();
                        ri1 = ri1.ToUpper();

                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextIstorie.txt"))
                        {
                            writer.WriteLine(ri1);
                        }

                        if (ri1 == "D" || ri1 == "C" || ri1 == "B")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (ri1 == "A")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajI += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajI);

                        Console.WriteLine("Press any key to continue");
                        System.Console.ReadLine();

                        break;

                    case "sport":
                        int punctajS = 0;

                            ///Apelez clasa Referitoare la intrebarile despre Sport
                        
                        S.MesajDeIntampinareSport();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        foreach (string line in System.IO.File.ReadLines(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextSport.txt"))
                        {
                            System.Console.WriteLine(line);
                            counter++;
                        }

                        //System.Console.WriteLine("Ai citit cu succes atatea linii {0} din fisierul .text!", counter);

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A PRIMA INTREBARE A, B C sau D -> ");
                        rs1 = Console.ReadLine();
                        rs1 = rs1.ToUpper();
                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextSport.txt"))
                        {
                            writer.WriteLine(rs1);
                        }

                        if (rs1 == "D" || rs1 == "C" || rs1 == "B")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (rs1 == "A")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajS += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajS);

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A DOUA INTREBARE A, B C sau D -> ");
                        rs1 = Console.ReadLine();
                        rs1 = rs1.ToUpper();
                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextSport.txt"))
                        {
                            writer.WriteLine(rs1);
                        }

                        if (rs1 == "D" || rs1 == "C" || rs1 == "B")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (rs1 == "A")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajS += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajS);

                        Console.Write("Aici trebuie sa alegi raspunsul PENTRU A PRIMA INTREBARE A, B C sau D -> ");
                        rs1 = Console.ReadLine();
                        rs1 = rs1.ToUpper();
                        ///salvarea datelor in fisier text /// scriere in fisier
                        using (StreamWriter writer = File.AppendText(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextSport.txt"))
                        {
                            writer.WriteLine(rs1);
                        }

                        if (rs1 == "D" || rs1 == "C" || rs1 == "B")
                        {
                            Console.WriteLine("Raspuns gresit :( !");
                        }
                        else if (rs1 == "A")
                        {
                            Console.WriteLine("Raspuns CORECT! :) ");
                            punctajS += 1;
                        }

                        Console.WriteLine("\nAcesta este punctajul tau -> {0}", punctajS);


                        ///FUNCTIE DE CAUTARE
                        foreach (string line in System.IO.File.ReadLines(@"C:\Users\Dell\Desktop\c++\ProiectLaboratorPIU\ProiectLaboratorPIU\TextSport.txt"))
                        {
                            foreach(string word in line.Split(' '))
                            {
                                if (word == "Ronaldo")

                                {
                                    System.Console.WriteLine(line);
                                }
                            }

                        }
                        Console.WriteLine("Press any key to continue");
                        System.Console.ReadLine();



                        break;

                    default:

                            Console.WriteLine("Optiune inexistenta!");
                            Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                            break;
                }
            } while (true);
        }
    }
}
