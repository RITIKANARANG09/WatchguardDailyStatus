using System;
using System.Globalization;

namespace nonPrimitive
{
    class program
    {
        static void Main(string[] args)
        {
//------------------------------------------------------------------ ARRAYS -------------------------------------------------------------------------------------
           /*                         // STATIC ALLOCATION
            int[] numbers = {1,2,3};
            Console.WriteLine(numbers[0]);
            
                                   // DYNAMIC ALLOCATION
                                        // with declaration
            int[] prime = new int[5] { 2, 3, 5, 7, 11 };
            Console.WriteLine("(DA) WITH DECLARATION WE HAVE TO DECLARE VALUES");  
            Console.WriteLine(prime[0]);
            Console.WriteLine(prime[1]);
            Console.WriteLine(prime[2]);
            Console.WriteLine(prime[3]);
            Console.WriteLine(prime[4]);
            //Console.WriteLine(prime[5]);*/

                                        // without declaration
                                             // (string array)
            string[] name = new string[6];
            name[0] = "AS";
            name[1] = "SD";
            Console.WriteLine("(DA) STRING ARRAY OF SZE 6, WILL ALLOCATE SPACES ON NON DEFNED INDEXES");
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[3]);
            Console.WriteLine(name[4]);
            Console.WriteLine(name[5]);
                                             // (int array)
            /*int[] numb = new int[4];
            numb[0] = 2;
            Console.WriteLine("(DA) INT ARRAY OF SIZE 4, WILL ALLOCATE 0 ON NON DEFINED INDEXES");
            Console.WriteLine(numb[0]);
            Console.WriteLine(numb[1]);
            Console.WriteLine(numb[2]);
            Console.WriteLine(numb[3]);
                                            // (char array)
            var letters = new char[2];
            letters[0] = 'a';
            Console.WriteLine("(DA) CHAR ARRAY OF SIZE 2, WILL ALLOCATE SPACE ON NON DEFINED INDEXES");
            Console.WriteLine(letters[0]);
            Console.WriteLine(letters[1]);*/
           /*                                 // (bool array)
            var expression = new bool[2];
            expression[1] = true;
            Console.WriteLine("(DA) BOOL ARRAY OF SIZE 2, WILL ALLOCATE FALSE ON NON DEFINED INDEXES");
            Console.WriteLine(expression[0]);
            Console.WriteLine(expression[1]);*/
// ----------------------------------------------------------------------STRINGS -------------------------------------------------------------------------------
                                           // 1. using string literal
            /*var name1 = "Ritika";
            string name2 = "Narang";
            String name3 = "Ritika Narang";
            Console.WriteLine("\nString using string interpolation");
            Console.WriteLine($"First name is {name1} \nLast name is {name2} \nFull Name is {name3}");

                                           // 2. concat strings
            Console.WriteLine("\nString concat using +");
            Console.WriteLine(name1 + " " + name2);
            Console.WriteLine("\nString concat using format");
            Console.WriteLine(string.Format("First Name is {0} \nlast name is {1} \nFull name is {2} ", name1, name2, name3));

                                          // 3. join strings
            string[] program = { "Hello", "Ritika", "Narang" };
            string joining = string.Join(" ", program); 
            Console.WriteLine("\nString joining use Join of .net framework ");
            Console.WriteLine(joining);
            
                                          // 4. Verbatim strings
            Console.WriteLine("\nVerbatim Strings");
            string address = "\nThis is your address :\nhttps:\\chat.openai.com\\c\\fd7de188-bb14-4fdc-9ae2-7d4f550ce1a0";
            Console.WriteLine(address);
            string vaddress = @"This is your address :
https:\chat.openai.com\c\fd7de188-bb14-4fdc-9ae2-7d4f550ce1a0";
            Console.WriteLine(vaddress);
//---------------------------------------------------------------EXERCISE 1-----------------------------------------------------------------------------------------
                                          //************** QUESTION 1) 
            Console.WriteLine("QUESTION 1");
            Console.Write(" Enter any number btw 1 and 10 : ");
            var snumber=Console.ReadLine();
            if (int.TryParse(snumber, out int number))
            {
                if (number >= 1 && number <= 10)
                    Console.WriteLine("VALID");
                else
                    Console.WriteLine("INVALID");
            }
                                             //************ QUESTION 2) max of 2 numbers ****************
            *//*Console.WriteLine("\nQUESTION 2");
            Console.WriteLine("Enter first number");
            var one=Console.ReadLine();
            if (int.TryParse(one, out int one_i))
            {
                Console.WriteLine("Enter second number");
                var two = Console.ReadLine();
                if(int.TryParse(two, out int two_i))
                {
                    
                    if(one_i>two_i)
                    {
                        Console.WriteLine("Max, no. is : " + one);
                    }
                    else if(one_i<two_i)
                    {
                        Console.WriteLine("Max, no. is : " + two);
                    }
                    else
                        Console.WriteLine("Both no. are equal");
                }
            }
            
                       // Question 3)
            Console.Write("Enter height : ");
            var ht=Console.ReadLine();
            if(int.TryParse(ht, out int ht_i))
            {
                Console.WriteLine("Enter width : ");
                var wt = Console.ReadLine();
                if(int.TryParse(wt,out int wt_i))
                {
                    if (wt_i > ht_i)
                        Console.WriteLine("Image is landscape");
                    else if (wt_i < ht_i) Console.WriteLine("Image is portrait");
                    else Console.WriteLine("Image is neither portrait nor landscape");
                }
            }*//*
                 // QUESTION 4
            */
        }
    }
}
