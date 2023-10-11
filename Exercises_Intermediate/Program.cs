using System;
namespace Exercise
{
    class Oct10
    {
        public static void Main(string[] args)
        {
            var s = new Stack();
            s.push(1);
            s.push("Ritika");
            s.push("");
            s.push('a');
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());

            //
            // Ques 1
            var p=new SqlConnection();
            p.openc();
            p.closec();
        }
    }
}