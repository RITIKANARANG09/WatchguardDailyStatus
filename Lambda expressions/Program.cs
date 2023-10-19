using System;
using System.Runtime.Intrinsics.X86;

namespace Lambda
{
    /*
     * An anonymous methods - has no return statement,no acess modifier,no name
     * for convenience = less code with more readable form
     * ()=>....
    x=>....
    (x,y)=>....
    */
    public class Book
    {
        public string Title;
        public int price;
    }
    public class BookList
    {
        public List<Book> b;
        public BookList() { b = new List<Book>(); }
    }
    public class BooksList
    {
        public List<Book> Hello()
        {
            return new List<Book>()
            {
                new Book(){Title="A",price=20 },
                new Book() {Title="B",price=40}
            };
        }
    }
        class LE
        {
            static int Square(int number)
            {
                return number * number;
            }        
            public static void Main(string[] args)
            {
            // Console.WriteLine(Square(5));
            /*BookList bl=new BookList();
            bl.b.Add(new Book() { Title = "b", price = 40 });
            bl.b.Add(new Book() { Title = "a", price=20});
            foreach(var books in bl.b)
            {
                Console.WriteLine(books.Title);
                Console.WriteLine(books.price);
            }*/
            var books=new BooksList().Hello();
            books.FindAll()
            }
        }
}
