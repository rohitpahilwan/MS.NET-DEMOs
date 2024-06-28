using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Shelf
    {
        List<String> books;

        public Shelf()
        {
            books = new List<string>();
            books.Add("LET US C");
            books.Add("C IN DEPTH");
            books.Add("Wings Of Fire");
        }

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }

        }
    }
}
