using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1 = new Note();
            Console.WriteLine("Sisestage enda nimi: ");
            note1.Author = Console.ReadLine();
            Console.WriteLine("Sisestage märge: ");
            note1.NoteText = Console.ReadLine();

            note1.CreateNote();

            Note note2 = new Note();
            Console.WriteLine("Sisestage enda nimi: ");
            note2.Author = Console.ReadLine();
            Console.WriteLine("Sisestage märge: ");
            note2.NoteText = Console.ReadLine();

            note2.CreateNote();

            Console.ReadLine();
        }
    }
}
