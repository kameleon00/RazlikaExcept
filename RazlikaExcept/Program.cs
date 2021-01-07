using System;
using System.Collections.Generic;
using System.Linq;

namespace RazlikaExcept
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> gradovi = new HashSet<string>() { "Beograd", "Nis", "Kragujevac", "Subotica", "Novi Sad"};
            Console.WriteLine("=====================================");
            Console.WriteLine("HashSet<string> gradovi Pre Except");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("=====================================");
            
            string[] gradoviNaSeveru = { "Subotica", "Novi Sad", "Kraljevo", "Pristina"};
            
            var noviGradovi = gradovi.Except(gradoviNaSeveru);//STAMPA ONE KOJI SE NALAZE U PRVOBITNOM SKUPU
            Console.WriteLine("HashSet<string> gradovi Nakon Except");       //ALI NE I ONE KOJI SE NE NALAZE
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("=====================================");
            
            gradovi.ExceptWith(gradoviNaSeveru);
            Console.WriteLine("HashSet<string> gradovi Nakon ExceptWith");//STAMPA ONE KOJI SE NALAZE U PRVOBITNOM SKUPU
            foreach (var grad in gradovi)                           //DOK UKLANJA IZ PRVOBITNOG ONE KOJI SE NALAZE U DRUGOM
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("=====================================");
            
            gradovi.ExceptWith(gradoviNaSeveru);
            Console.WriteLine("HashSet<string> gradovi Nakon ExceptWith");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("=====================================");
            //==============================================================================================================
            
            HashSet<string> gradoviI = new HashSet<string>() { "Beograd", "Nis", "Kragujevac", "Subotica", "Novi Sad"};
            
            gradoviI.SymmetricExceptWith(gradoviNaSeveru);
            Console.WriteLine("HashSet<string> gradovi Nakon SymmetricExceptWith");//STAMPA ELEMENTE I IZ PRVOG I IZ DRUGOG SKUPA
            foreach (var grad in gradoviI)                                     //UKLANJAJUCI POSTOJECE
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("=====================================");
        }
    }
}