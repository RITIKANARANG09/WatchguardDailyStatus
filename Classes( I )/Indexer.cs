using System;

namespace Classes
{
    public class Indexer
    {
        private Dictionary<string, string> _dictionary=new Dictionary<string,string>();

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
    public class Name
    {
        public string name;
        public string this[int i]=>name;
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int id { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public Employee(string FirstName,string LastName,int id,string Job,double Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
            this.id = id;
            this.Job = Job; 
        }
        public object this[int i]
        {
            get
            {
                if (i == 0)
                    return FirstName;
                else if (i == 1)
                    return LastName;
                else if (i == 2)
                    return id;
                else if (i == 3)
                    return Job;
                else if (i == 4)
                    return Salary;
                else
                    return null;

            }
            set
            {
                     if (i == 0)
                    this.FirstName = value.ToString();
                else if (i == 1)
                    this.LastName  = value.ToString();
                else if (i == 2)
                    this.id        = Convert.ToInt32(value);
                else if (i == 3)
                    this.Job       = value.ToString();
                else if (i == 4)
                    this.Salary    = Convert.ToDouble(value);
            }
        }
        //------------ indexer overloading ----------------
        public object this[string name]
        {
            get {
                if (name      == "FirstName") return FirstName;
                else if (name == "LastName") return LastName;
                else if (name == "id") return id;
                else if (name == "Job") return Job;
                else if (name == "Salary") return Salary;
                else
                    return null;
            }
            set
            {
                if (name      == "FirstName") this.FirstName=value.ToString();
                else if (name == "LastName") this.LastName = value.ToString();
                else if (name == "id") this.id = Convert.ToInt32(value);
                else if (name == "Job") this.Job = value.ToString();
                else if (name == "Salary") this.Salary=Convert.ToInt32(value);
            }
        }
    }
}
