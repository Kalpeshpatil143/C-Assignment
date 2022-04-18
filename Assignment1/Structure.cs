using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    using System;

    namespace Structure
    {


        enum BookType : byte
        {
            Magazine = 10,
            Novel = 1,
            ReferenceBook = 100,
            Miscellaneous = 9
        }

        struct BOOK
        {
            public int BookID;
            public string title;
            public short Price;
            public BookType heading;


            public BOOK(int i, string n, short p, BookType et)
            {
                BookID = i;
                title = n;
                Price = p;
                heading = et;

            }
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
                BOOK fred;
                fred.BookID = 40;
                fred.title = "Fred";
                fred.Price = 250;
                fred.heading = BookType.Novel;

                BOOK mary = new BOOK(50, "Mary", 1450, BookType.Magazine);

                Console.WriteLine("BookID is {0} ", mary.BookID);
                Console.WriteLine("Title is {0}", mary.title);
                Console.WriteLine("Price is {0}", mary.Price);
                Console.WriteLine("Tyoe of the book is {0}", mary.heading);

                Console.WriteLine("\n");

                Console.WriteLine("BookID is {0}", fred.BookID);
                Console.WriteLine("Title is {0}", fred.title);
                Console.WriteLine("Price is {0}", fred.Price);
                Console.WriteLine("Tyoe of the book is {0}", fred.heading);


            }
        }
    }
}
