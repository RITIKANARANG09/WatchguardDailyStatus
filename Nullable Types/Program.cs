using System;
namespace NullableTypes
{
    struct Program
    {
        struct Admin
        {
            string name;
            int age;
            private Admin()
            {
                name = "r";
            }
        }
        public static void Main(string[] args)
        {
            Admin Ritika = new Admin();
            /*DateTime d = new DateTime(2014,4,4);
            // DateTime dt = null;    // error
            DateTime? dt2 = null;
            *//* OR *//*
            Nullable<DateTime> dt3 = null;
            Console.WriteLine(dt2.GetValueOrDefault());
            Console.WriteLine(dt2.HasValue);
            Console.WriteLine(dt2.Value); // null exception
            //DateTime dt4 = dt2;  //error null to normal
            DateTime? dt4 = d;     // no error

            DateTime? dt5 = null;
            DateTime dt6;
            if (dt5 != null)
                dt6 = dt5.GetValueOrDefault();
            else
                dt6 = DateTime.Today;

            //----------------------- null coalescing operator ----------------------
            DateTime d7 = dt2 ?? DateTime.Today;
            *//*OR*//*
            DateTime dt8= (dt2==null) ? DateTime.Today : dt2.GetValueOrDefault();*/


        }   
    }
}
