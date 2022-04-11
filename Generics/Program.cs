using System;

namespace Generics
{
    //internal class Program
    //{
    static void Main()
    {
        var data = new Data<object>();

    }

//public class Addition<T,R>
//{
//    public void Add(T parameter1, R parameter)
//    {
//       Console.WriteLine(parameter + parameter1);
//    }
//    public void summation(int a, int b)
//    {
//        Console.WriteLine(a + b);
//    }
//    Shapes<T> shape1 = new Shapes<T>();


//}
//public class Shapes<T>
//{
//    public void Somemethod()
//    {

//    }
//}

//public class Circle<T> : Shapes<T>
//{
//    public void SomeOtherMethod(T value)
//    {

//    }
//}

public interface IData<D>
    {
        void Add(D item);
    }
    public class Data<D> : IData<D>
    {
        private D[] _data;  
        private int _index;

        public Data()
        {
            _data = new D[10];
        }

        public void Add(D item)
        {
            _data[_index++] = item; 
        }
    }

        
   
}
