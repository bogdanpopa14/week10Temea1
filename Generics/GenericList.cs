using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericList<T> where T:IComparable<T>,IEquatable<T>,IFormattable
    {

        private int index = 0;
        private int size;
        private T[] arr;

        public GenericList(int size)
        {
            this.size = size;
            arr = new T[size];
        }
        public void Add(T value)
        {

            if (index < size)
            {
                arr[index] = value;
                index++;
            }
            else if (index == size)
            {
                T[] aux = new T[size];
                aux = arr;

                size = size * 2;
                arr = new T[size];
                aux.CopyTo(arr, 0);
               
                arr[index] = value;

            }
        }

        public T GetVal(int i)
        {
            T var = default(T);
            if(i<size)
            {
                var = arr[i];
            }

            else 
            {
                Console.WriteLine();

            }

            return var;



        }

        public void Delete(int i)
        {

            arr[i] = default(T);
        }

        public void Insert(T value, int i)
        {
            if (i < size)
            {
                arr[i] = value;
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void ClearList()
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = default(T);
            }
        }

        public T Max()
        {
            T max = default(T);
            for (int i = 0; i < size; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if(arr[i].CompareTo(arr[j])>0)
                    {
                        max = arr[i];
                    }
                    else
                    {
                        max = arr[j];
                    }
                }
            }
            return max;
        }

        public T Min()
        {
            T min = default(T);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i].CompareTo(arr[j]) < 0)
                    {
                        min = arr[i];
                    }
                    else
                    {
                        min = arr[j];
                    }
                }

            }
            return min;
        }

        public string GetByValue(T value)
        {
            T ret = default(T);
            for (int i = 0; i < size; i++)
            {
                if(arr[i].Equals(value))
                {
                    ret = arr[i];
                }
            }
            return ret.ToString();
        }
    }
}
