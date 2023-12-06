using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Classes_and_Object
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Console.WriteLine("The title of a second book is: "+book2.title);
            Console.WriteLine("The author of a second book is: "+book2.author);
            Console.WriteLine("The pages: "+book2.pages);
            Console.WriteLine("The title of a first book is: "+book1.title);
            Console.ReadLine();


        }
    }
}
