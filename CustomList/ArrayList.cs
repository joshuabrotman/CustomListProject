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
        //private int count;
        private T[] internalArray;
        private int arrayCapacity;
        private int count;

        public int ArrayCapacity {
            get
            {
                return arrayCapacity;
            }
            set
            {
                
            }
        }
        public int Count { 
            get 
            {
                return count;
            }
            set 
            { 
            } 
        }




        //constructors

        public ArrayList()
        {
            count = 0;
            arrayCapacity = 4;
            internalArray = new T[arrayCapacity];
        }


        //override plus operator

        public static ArrayList<T> operator+ (ArrayList<T> a1, ArrayList<T> a2)
        {
            ArrayList<T> a3 = new ArrayList<T>();
            //a3 = a1 , a2;
            for (int i = 0; i < a1.count; i++)
            {
                a3.Add(a1[i]);
            }
            for (int i = 0; i < a2.count; i++)
            {
                a3.Add(a2[i]);
            }
            return a3;
        }

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString = newString + Convert.ToString(internalArray[i]);
            }

            return newString;
        }

        public void Remove(T ValueToRemove)
        {
            int indexOfValueToRemove = -1;

            //get the index of requested removal
            for (int i = 0; i < count; i++)
            {
               if (EqualityComparer<T>.Default.Equals(internalArray[i], ValueToRemove))
                {
                    indexOfValueToRemove = i;
                    
                }

            }
            //if indexofvaluetoremove is not empty
            //shift list down, replacing the old values
            if (indexOfValueToRemove >= 0)
            {
                for (int j = indexOfValueToRemove; j < count; j++)
                {
                    if (count - 1 != j)
                    {
                        internalArray[j] = internalArray[j + 1];
                    }
                    else
                    {
                        internalArray[j] = default(T);
                    }
                }

                //reduce count by one
                count--;
            }

            

        }

        public void Add(T ValueToAdd)
        {

            //if internal array is at capacity, increase capacity then add
            if (count == arrayCapacity)
            {
                // double the array capacity
                arrayCapacity *= 2;
                //create temporary array
                T[] tempArray = new T[arrayCapacity];

                //transfer old data into temp array
                
                //Step through and set temparray values to the values from internalArray
                for(int i = 0; i<count;i++)
                {
                    tempArray[i] = internalArray[i];
                }

                internalArray = tempArray;
            }
            internalArray[Count] = ValueToAdd;
            count++;
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
