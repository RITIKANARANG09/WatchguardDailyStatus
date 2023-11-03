using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace Linq
{
    public class Book
    {
        public string Title;
        public int price;
    }
    public class BookList
    {
        public List<Book> BL()
        {
            return new List<Book>() {
            new Book(){ Title="A" , price=20 },
            new Book(){ Title="B" , price=40 },
            new Book(){ Title="C" , price=60 },
            new Book(){ Title="D" , price=80 },
            new Book(){ Title="A" , price=20 }
            };
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var obj = new BookList().BL();
            //-------------------- where ------------------------------------- 
            /*var cheapbooks=obj.Where(b=>b.price>20);
            foreach(Book b in obj)
                Console.WriteLine(b.Title + " " +b.price);*/
            //-------------------- order by ----------------------------------
            /*var cheapbook=obj
                .Where(b=>b.price>20)
                .OrderByDescending(b=>b.price);
            foreach(Book b in cheapbook)
            {
                Console.WriteLine(b.Title +" "+ b.price);
            }*/
            //------------------- select ------------------------------------
            /*var cheapbook = obj.Where(b => b.price > 60).OrderByDescending(b => b.price)
                .Select(b => b.price);
            foreach (int b in cheapbook)
            {
                Console.WriteLine(b);
            }*/
            //------------------- single -------------------------------------------------
            /* var cheapbook = obj.Where(b => b.Title == "A");
             foreach(var book in cheapbook)
             {
                 Console.WriteLine();
             }*/
            //Console.WriteLine(book[0].Price);
            /*var cheapsbook = obj.Single(b => b.Title == "A");
            Console.WriteLine(cheapsbook.price);
            var cheapsbooks = obj.SingleOrDefault(b => b.Title == "A+");
            Console.WriteLine(cheapsbooks.price);*/
            //----------------------- last --------------------------------------
            /* var a = obj.Last(b=>b.price==20);
             Console.WriteLine(a.Title);
             var a = obj.LastOrDefault(b => b.price == 20);
             Console.WriteLine(a.Title); */
            //---------------------- first -------------------------------------
            /*var a = obj.First(b => b.price == 20);
            Console.WriteLine(a.Title);
            var a = obj.First(b => b.price == 20);
            Console.WriteLine(a.Title);*/
            //-------------------- skip,take (can work independently) -------------------------------------
            var a = obj.Skip(0).Take(40);
            foreach (var item in a) 
                Console.WriteLine(item.Title + " " + item.price);
            //------------------ AGGREGATE FXNS -------------------------
            /*count,sum,min,max,averege*/
            //----------------------- count ---------------------------------
            var counts = obj.Count();
            Console.WriteLine(counts);
            var add = obj.Sum(b=>b.price);
            Console.WriteLine(add);
            var max=obj.Max(b=>b.price);
            Console.WriteLine(max);
            var minimum=obj.Min(b=>b.price);
            Console.WriteLine(minimum);
            var avrg=obj.Average(b=>b.price);
            Console.WriteLine(avrg);
        }
    }
}