using StripsBL.Exceptions;
using StripsBL.Model;

namespace ConsoleAppTestBL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Auteur a1 = new Auteur("jos", "jos@gmail");
            Auteur a2 = new Auteur("josken", "jos@gmail");
            List<Auteur> list = new List<Auteur>(); 
            list.Add(a1);
            list.Add(a1);
            try
            {
                Strip s = new Strip("titel",list);
                s.VoegAuteurToe(a2);
                //s.Auteurs.Add(a2);
            }
            catch(DomeinException) { Console.WriteLine("ok"); }
            Console.WriteLine();
        }
    }
}
