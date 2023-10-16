using System;
namespace Ab
{
    public interface Ibank
    {
        void WithdrawMoney();
        public static int x = 10;
        static Ibank()
        {
            Console.WriteLine("static constructor is called");
        }
        void CheckBalance();
    }
    public class BankName
    {
        public static Ibank BN(string type)
        {
            Ibank obj = null;
            if (type == "SBI")
            {
                obj = new SBI();
            }
            else
                obj= new AXIS();
            return obj;
        }
    }
    public class SBI : Ibank
    {
        public void WithdrawMoney()
        {
            Console.WriteLine("withdrawing money from SBI");
        }
        public void CheckBalance()
        {
            Console.WriteLine(" checking balance from SBI");
        }
    }
    public class AXIS : Ibank
    {
        public void WithdrawMoney()
        {
            Console.WriteLine("withdrawing money from AXIS");
        }
        public void CheckBalance()
        {
            Console.WriteLine("checking balance from AXIS");
        }
    }
    public class Check
    {
        public static void Main(string[]args)
        {
            Ibank ob = new SBI();
            //Console.WriteLine(x); -- error 
            SBI a=new SBI();
            /*Ibank ob2 = BankName.BN("SBI");
            ob2.CheckBalance();
            ob2.WithdrawMoney();*/

        }
    }
}
