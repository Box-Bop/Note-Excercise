using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteExcercise
{
    class Note
    {
        public string Author { get; set; }
        public string NoteText { get; set; }
        public DateTime ModificationDate { get; set; }

        public void CreateNote()
        {

            ModificationDate = DateTime.Now;
            Console.WriteLine("Author: " + Author + "\nNote: " + NoteText + "\nDate added: " + ModificationDate);
            Console.WriteLine();
        }

    }
}
