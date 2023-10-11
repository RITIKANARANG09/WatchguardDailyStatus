using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{   // Ques 1
     class Stack
    {
        List<object> data;
        public Stack()
        {
            data = new List<object>();
        }
        public void push(object ob)
        {
            if (ob == null)
                throw new InvalidOperationException("NULL object");
            data.Add(ob);
        }
        public void Clear()
        {
            data.Clear();
        }
        public object pop()
        {
            if (data.Count == 0)
                return null;
            int r=data.Count;
            var p = data[r-1];
            data.Remove(data[r-1]);
            return p;
        }
    }
    // Ques 2

}
