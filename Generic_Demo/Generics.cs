using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    //Generic means general form
    //It does not specify a particular data type
    //we are using <> (Angular bracket) with type name
    // TypeName <T> T is your type parameter
    //Generic allow us to a single class or methode that can be used in a different data type
    //Advantage - We can reuse the code.
    public class Generics<T>
    {
        // public string Name;
        public T data;
        public Generics(T data)
        {
            this.data = data;
            Console.WriteLine(this.data);
        }
        public void  GenericMethod(T num)
        {
            Console.WriteLine(num);
        }
    }
    public class GenericMethod
    {
        public void Generic<T>(T num)
        {
            Console.WriteLine(num);
        }
        public void GenericMethodOne<T>(T num)
        {
            Console.WriteLine(num);
        }
    }
}
