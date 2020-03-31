using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        int count;
        public int Count { get; set; }
        int capacity;
        public int Capacity { get; set; }
        private T[] items;
        public MyList()
        {
            capacity = 4;
            items = new T[capacity];
        }

        public void Add()
        {

        }
    }
}
