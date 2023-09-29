using System;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Transactions;

namespace Sep29
{
    class S29
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------- Control Flow -----------------------------------------------------------------
            //----- Ques 1)
            /*int count = 0;
            for(int i = 1;i<=100;i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("Numbers between 1 and 100 divisible completely by 3 are : " + count);*/

            //----- Ques 2)
            /*int sum = 0;
            while (true)
            {
                Console.Write("\nEnter a number OR ok to quit : ");
                var numbers = Console.ReadLine();
                if (numbers.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(numbers);
            }
            Console.WriteLine("Sum is : " + sum);*/

            //------ Ques 3)
            /*  Console.Write("\n Enter a number starting from 0 to know the factorial of that number : ");
              var number = Console.ReadLine();
              int r = Convert.ToInt32(number);
              var numbers = number;
              while (Convert.ToInt32(numbers) < 0)
              { Console.WriteLine("Enter a number above -1");
                Console.WriteLine("Enter a number starting from 0 to know the factorial of that number: ");
                  numbers = Console.ReadLine();
                  r= Convert.ToInt32(numbers);
              }
               int factor = fact(r);
              int fact(int r)
              {
                  if (r == 0 || r == 1) return 1;
                  return r*fact(r - 1);
              }
              Console.WriteLine("Factorial is : " + factor);*/

            //------ Ques 4)
          /*  Random rnd = new Random();
            int month = rnd.Next(1, 11);
            int i = 0;
            while(i<4)
            {
                Console.Write("Enter a number : ");
                var st = Console.ReadLine();
                if(Convert.ToInt32(st)==month)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                    i++;
                }
                if(i==4)
                    Console.WriteLine("You Lost");
            }
*/
            //------ Ques 5)
            /* int max = int.MinValue;
             //var list = new List<int>();
             while (true)
             {
                 Console.Write("Enter a number OR quit to exit : ");
                 var number=Console.ReadLine();
                 int r=Convert.ToInt32(number);
                 if (number.ToLower() == "quit")
                     break;
                 if(r>max)
                     max = r;
                 //list.Add(r);
             }
             Console.WriteLine("Maximum no is : " + max);*/

            //-------------------------------------- Array and Lists --------------------------------------------------------------------

            // QUES 1
            //var li = new List<string>();
            //while(true)
            //{
            //    Console.Write("Enter Name : ");
            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    li.Add(input);
            //}

            //if (li.Count == 1)
            //    Console.WriteLine("{0} liked your post." , li[0]);
            //else if (li.Count == 2)
            //    Console.WriteLine("{0}, {1} liked your post." , li[0], li[1]);
            //else
            //{
            //    int size=li.Count-2;
            //    Console.WriteLine("{0}, {1} and {2} liked your post." , li[0], li[1], size);
            //}

            //QUES 2
            /*Console.Write("Enter Name : ");
            var str = Console.ReadLine();
            char[] arr = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            string revStr = new string(arr);
            Console.WriteLine(revStr);*/
            
            //Ques 3)
            /* Console.WriteLine("Enter 5 numbers : ");
             var lists = new List<int>();
             int count = 5,i=1;
             while(i<=count)
             {
                 var no=Console.ReadLine();
                 if(lists.Contains(Convert.ToInt32(no))==false)
                 {
                     int number=Convert.ToInt32(no);
                     lists.Add(number);
                     i++;
                 }
                 else
                 {
                     Console.WriteLine(" Please enter the unique number : ");
                 }
             }
             lists.Sort();
             foreach(int number in lists)
             {
                 Console.Write("Numbers in sorted form : " + number);
             }*/

            //Ques 4)
            /*var lists2 = new List<int>();
            var buffer = new List<int>();
            while (true)
            {
                Console.Write("Enter a number : ");
                var number=Console.ReadLine();
                if (number.ToLower() == "quit")
                    break;
                buffer.Add(Convert.ToInt32(number));
            }
           foreach(int n in buffer)
            {
                if (lists2.Contains(n))
                    continue;
                lists2.Add(n);
                Console.Write(n + " ");
            }*/

            //Ques 5)
            /*Console.WriteLine("Enter numbers seperated by ,");
            var st = Console.ReadLine();
            
            string[] k = st.Split(',');
            var list=new List<int>();
            if (String.IsNullOrWhiteSpace(st) || k.Length < 5)
                Console.Write("Invalid List ");
            else
            {
                for (int i = 0; i < k.Length; i++)
                {
                    list.Add(Convert.ToInt32(k[i]));
                }
                list.Sort();
                for(int i=0;i<3;i++)
                    Console.Write(list[i] + " ");
            }*/

            //------------------------------------------------------- Files --------------------------------------------------------------
            // Ques 1)
            /*var path = "C:\\Users\\rnarang\\Downloads\\temp.txt";
            var fs = File.ReadAllText(path);
            string[] arr= fs.Split(" ");
            int count = 0;
            for(int i=0;i<arr.Length; i++)
            {
                count++;
            }
            Console.WriteLine("Total no. of words are : " + count);*/

            // Ques 2)

            /*var path = "C:\\Users\\rnarang\\Downloads\\temp.txt";
            var fs = File.ReadAllText(path);
            string[] arr = fs.Split(" ");
            int mx = int.MinValue;
            string st = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (mx < arr[i].Length)
                {
                    mx = arr[i].Length;
                    st = arr[i];
                }
            }
            Console.WriteLine("Longest word is : " + st);*/

            //----------------------------------------------------------- Working with text ---------------------------------------------------------

            //Ques 1)
            /* Console.WriteLine(" Write a number with hyphen ");
             var k = Console.ReadLine();
             string[] st = k.Split('-');
             if (Convert.ToInt32(st[0]) == Convert.ToInt32(st[1])+1)
             {
                 for(int i=2; i<st.Length; i++)
                 {
                     if (Convert.ToInt32(st[i - 1]) == Convert.ToInt32(st[i])+1)
                         continue;
                     else
                         Console.Write("\nNon Consecutive ");

                 }

             }
             else if(Convert.ToInt32(st[0])+1 == Convert.ToInt32(st[1]))
             {

                 for (int i = 2; i < st.Length; i++)
                 {
                     if (Convert.ToInt32(st[i - 1])+1 ==  Convert.ToInt32(st[i]))
                         continue;
                     else
                         Console.Write("\nNon Consecutive ");

                 }
             }
             else if(Convert.ToInt32(st[0]) + 1 != Convert.ToInt32(st[1]) || Convert.ToInt32(st[0]) != Convert.ToInt32(st[1])+1)
             {
                 Console.Write( "Non Consecutive ");
             }
             else
             Console.WriteLine("Consecutive");*/

            // Ques 2)
            /* var list = new List<string>();
             while (true)
             {
                 Console.WriteLine(" Write a number with hyphen OR press enter to exit");
                 var s = Console.ReadLine();
                 if (String.IsNullOrWhiteSpace(s) == true)
                     break;
                 string[] st=s.Split('-');
                 //int r = Convert.ToInt32(st);
                 foreach (string i in st)
                 {
                     if (list.Contains(i))
                     {
                         Console.WriteLine("Duplicate number entered ");
                         break;
                     }
                     list.Add(i);
                 }

             }*/

            //Ques 3)
            /*Console.Write("Enter time between 00:00 to 23:59 ");
            var st = Console.ReadLine();
            string[] s= new string[2];
            if(!String.IsNullOrWhiteSpace(st))
            s = st.Split(':');
            if(String.IsNullOrWhiteSpace(st) || Convert.ToInt32(s[0])< 0 || Convert.ToInt32(s[0]) > 23 || Convert.ToInt32(s[0]) < 0 || Convert.ToInt32(s[0]) > 59)
                Console.Write( "Invalid Time ");
            else
                Console.WriteLine("Valid Time ");*/

            //Ques 4)
            /*Console.Write("Write words with space");
            var st=Console.ReadLine();
            string[] s = st.Split(' ');
            string r = "";
            for(int i = 0;i< s.Length; i++) 
            {
                var k = s[i];
                var v = k.ToLower();
                r+=k.Substring(0, 1).ToUpper();
                r += k.Substring(1);
            }
            Console.WriteLine("String is : " + r);*/

            //Ques 5)
            /*Console.Write("\nEnter a word : ");
            var ar = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i]=='a' || ar[i] == 'e' || ar[i] == 'i' || ar[i] == 'o' || ar[i] == 'u')
                    count++;
            }
            Console.Write("\nTotal vowels are : " + count);*/
        }
    }
}
