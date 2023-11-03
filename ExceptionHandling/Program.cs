using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
/* ex= source(exception handling), stacktrace,(what actual exception is ) msg, targetsite( method )
* stacktrace= sequence of methods called in reverse order.
ex is the way of getting/access the actual exception
start with most specific to most generic and then finally/using
*/
namespace ExceptionHandling
{

   /* public class Calculator
    {
        public int divide(int n, int d)
        { return n/d;}
    }*/
   public class YoutubeException:Exception
    {
        public YoutubeException(string mesg, Exception e):base(mesg,e) { }
    }
    public class Youtube
    {
        public List<int> GetVideos()
        {
            try
            {
                throw new Exception("Low level youtube exception");
            }
            catch (Exception ex)
            {
                throw new YoutubeException("Couldn't fetch videos from youtube", ex)
            ;

            }
            return new List<int /*Video*/>();
        }
    }
    class Program
    {
        public static void Main(string[]args)
        {
            /*StreamReader streamReader = null;
            try
            {
               *//* using (StreamReader streamReader= new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd(); *//* used to read content*//*
                    throw new Exception("OOPS");
                }*//*
                    streamReader = new StreamReader(@"c:\file.zip");*//*it is a class used to read files*//*
                var content= streamReader.ReadToEnd(); *//* used to read content*//*
                throw new Exception("OOPS");
            }
            catch(Exception e)
            {
                Console.WriteLine("An unexpected error occured");
            }
            finally { if(streamReader!=null) streamReader.Dispose(); }*/
            /*try
            {
                Calculator c = new Calculator();
                c.divide(1, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide byzero exception");
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("Arithematic exception");
            }
            catch(Exception e)
            {
                Console.WriteLine("unknown error occurred");
            }
            finally /*in .net we have classes that access unmanaged resources(that are not managed by clr, so no garbage collection is there to cleanup), so we have to manually cleanup them so finally is used and uses interface idisposable that has method disposable that do the cleanup*/
           /* {
                IDisposable
            }*/
            
        }
    }
}