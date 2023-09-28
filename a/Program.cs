using Microsoft.VisualBasic;
using System;
namespace D
{
    class d
    {
        static void Main(string[] args)
        {
//------------------------------------------------ DateTime --------------------------------------------------------------------------
            var date = new DateTime(2022-08-08);
            Console.WriteLine(date);       // 1/1/0001 12:00:00 AM
            Console.WriteLine("Added days are : " + date.AddDays(10));
            //Console.WriteLine("Added days are : " + date.AddDays(-1));
            Console.WriteLine("Added hours are : " + date.AddHours(2));
            Console.WriteLine("Added Minutes are : " + date.AddMinutes(4));
            Console.WriteLine("Added seconds are : " + date.AddSeconds(2));
            Console.WriteLine("Current date is " + DateTime.Now);
            var now= DateTime.Now;
            var hr=now.Hour;
            var min=now.Minute; ;
            Console.WriteLine("Current hour is : " + hr);
            Console.WriteLine("Current min is : " + min);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("YY-MM-DD"));

//---------------------------------------------- String Functions ------------------------------------------------------------------
            var str = "Ritika Narang";
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str);
            int index=str.IndexOf(" ");
            Console.WriteLine(str.IndexOf(" "));
            Console.WriteLine("First way to split a string : \nFirst Name is : " + str.Substring(0,index));
            Console.WriteLine("Last Name is : " + str.Substring(index+1));
            Console.WriteLine("2nd way to split a string : ");
            string[] splits = str.Split(' ');
            foreach(var i in splits)
                Console.WriteLine(i);
            Console.WriteLine("Replace R with G : " + str.Replace('R', 'G'));
            Console.WriteLine("Removing string : " + str.Remove(index));
            Console.WriteLine("is empty or null : " +  String.IsNullOrEmpty("null"));
            Console.WriteLine(" is empty or null or space : " +String.IsNullOrWhiteSpace(" "));
            Console.WriteLine(" STRINGS TO INTEGER : ");
            string no = "1234";
            string empt = " ";
            Console.WriteLine("1st method : " + int.Parse(no));
           // Console.WriteLine(" empty string : " + int.Parse(empt));
            Console.WriteLine("2nd method : " + Convert.ToInt32(no));
           // Console.WriteLine(" empty string : " + Convert.ToInt32(empt));
            Console.WriteLine(" INTEGER TO STRING : ");
            int ino = 12;
            Console.WriteLine(ino.ToString());
            Console.WriteLine(ino.ToString("C"));
            Console.WriteLine(ino.ToString("C0"));
            Console.WriteLine(ino.ToString("C1"));
            Console.WriteLine(ino.ToString("C2"));
            Console.WriteLine(ino.ToString("E"));
            Console.WriteLine(ino.ToString("X"));
            Console.WriteLine(ino.ToString("F"));
            Console.WriteLine(ino.ToString("D"));

//------------------------------------------- File and FileInfo --------------------------------------------------------

            // File =  .Create(), .ReadAllText(), ReadAllBytes(), .Delete(), .Copy(), .Move() etc.

            /*var paths=@"d:\temp\myfile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"D:\temp\myfile.JPG", true);
            File.Move(@"c:\temp\myfile.jpg", @"D:\temp\myfile.JPG");
            //var paths = @"c:\asdf.jpeg";
            var k = File.ReadAllText(paths);
            Console.WriteLine(k);
            File.Delete(paths);
            Console.WriteLine(File.Exists(paths));*/

//----------------------------------------- Directory and Directory Info -----------------------------------------------

            /*Directory.CreateDirectory(----);
            var file=Directory.GetFiles(@"c:\abc.jpeg","*,*",SearchOption.AllDirectories);
            foreach(var f in file)
                Console.WriteLine(f);
            var dir=Directory.GetDirectories(@"c:\abc.jpeg", "*,*", SearchOption.AllDirectories);
            foreach (var f in dir)
                Console.WriteLine(f);
            if(Directory.Exists(""))
            {
                ----;
            }
            var dirIn = new DirectoryInfo();
            dirIn.GetDirectories();
            dirIn.GetFiles();*/

//-------------------------------------------- Path --------------------------------------------------------

            var path = @"c:\abcd\wxyz.jpeg";
            Console.WriteLine(path.IndexOf('.'));
            Console.WriteLine(path.Substring(path.IndexOf(':')));
            Console.WriteLine("File name is : " + Path.GetFileName(path));
            Console.WriteLine("Extension is : " + Path.GetExtension(path));
            Console.WriteLine("File name without extension is : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name is : " + Path.GetDirectoryName(path));

          
        }
    }
}