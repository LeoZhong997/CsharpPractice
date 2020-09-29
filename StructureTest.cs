using System;
using System.Text;

namespace StructureApplication
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void setValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title: {0}\nAuthor:{1}\nSubject:{2}\nBookID:{3}", 
                title, author, subject, book_id);
        }
    }
    public class StructureTest
    {
        static void Main1(string[] args)
        {
            Books book1 = new Books();
            Books book2 = new Books();

            book1.setValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495404);
            book2.setValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 4659523);

            book1.display();
            book2.display();

            Console.ReadLine();
        }
    }
}