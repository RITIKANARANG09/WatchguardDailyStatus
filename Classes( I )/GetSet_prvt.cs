using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /* this smells code as if we have 4 fields, then we have to declare 
    8 get set for each */
    public class GetSetPrvt
    {
        private string name;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }
    /* btr is to use properties */
    /* properties is the member of class which is used to write get set 
     with less code */
    public class Properties
    {
        public Properties(string Name)
        {
            this.Name = Name;
        }
        public string Name
        { get; set; }
        public int Value { get; set; }
    }

    // prvt set method
    public class Person
    {
        public DateTime BirthDate { get; private set; }
        public Person(DateTime dt) { BirthDate = dt; } 
        public int  Age
        {
            get
            {
                var time=DateTime.Now-BirthDate;
                var years = time.Days / 365;
                return years;
            }
        }
    }
    }

