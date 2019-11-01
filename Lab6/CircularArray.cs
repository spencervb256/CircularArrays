using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6
{
    public class CircularArray<T>
    {
        private T[] array;
        private int queueFront;
        private int queueRear;
        private int max;
        private int count;
        
        // Basic Constructor 
        // Creates an array and initializes the front and rear
        // O(1) in time O (N) in size
        public CircularArray(int size)
        {
            array = new T[size + 1];
            queueFront = 0;
            queueRear = 0;
            max = size;
            count = 0;
            
            
        }
        // NYI fully.  
        public void AddBack(T value)  //addBack is enqueue
        {

            if (count == max)
            {
                WriteLine("Queue has no space");
                return;
            }
            else
            {
                queueRear = (queueRear + 1) % max;
                array[queueRear] = value;

                count++;
            }


        }


        
        //Also Not Yet Implemented fully
        // Note that I've made it return the value being removed, that's not strictly required but makes the most sense. 
        public T RemoveFront()  //removeFront is dequeue
        {

            if (array != null)
            {
                T sample = array[queueFront];
                // Because technically T could be not nullable we need to use default(T), which is null.  
                array[queueFront] = default;


                if (queueFront % array.Length == 0)
                {
                    queueFront = (queueFront + 1) % max;
                }
                return sample;


            }
            if (array == null)
            {
                WriteLine("Queue is empty");
                return default;
            }
            //Right now, calling this on an empty queue will crash
            return default;
          
        }

        // Just returns the front element O(1)
        public T GetFront()
        {
            //Calling this on an empty queue will probably crash too
            if (array != null)
            {
                return array[queueFront];
            }
            else
            {
                grow(array.Length * 2);
                GetFront();
            }
            return default;
        }
        // Same old Grow, bit hard to know where to use it if at all though...
        // O(N)
        public void grow(int newsize)
        {
            Array.Resize(ref array, newsize);
        }
    }
}
