using System;

namespace Generics.In.Interface
{
    public class Program
    {
        static void Main()
        {

        }
    }
    public class ShoppingBag<T> where T : Bag
    {
        public T[] aBag = new T[10];
        public int index = 0;
        
        public void AddItem(T item)
        {
            aBag[index++] =  item;
        }
        public T GetItem(int index)
        {
            return aBag[index];
        }
    }
    public class Bag
    {

    }
}