using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ArrayList<T>
    {

        //member variables
        private int count;
        private T[] internalArray;
        private int arrayCapacity;

        public int ArrayCapacity { get; set; }
        public int Count { get; set; }




        //constructors

        public ArrayList()
        {
            count = 0;
            arrayCapacity = 4;
            internalArray = new T[arrayCapacity];
        }
        public void Add(T ValueToAdd)
        {

        }



        //indexer
        public T this[int number]
        {
            get
            {
                // This is invoked when accessing Layout with the [ ].
                if (number >= 0 && number < internalArray.Length)
                {
                    // Bounds were in range, so return the stored value.
                    return internalArray[number];
                }
                // Return an error number.
                throw new System.ArgumentException("Index out of bounds", "error");
            }
            set
            {
                // This is invoked when assigning to Layout with the [ ].
                if (number >= 0 && number < internalArray.Length)
                {
                    // Assign to this element slot in the internal array.
                    internalArray[number] = value;
                }
            }
        }
    }
}
