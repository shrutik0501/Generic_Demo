using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(25);
            Generics<string> genericsString = new Generics<string >("Shruti");
            Generics<double> genericsDouble = new Generics<double>(0.19);
            Generics<char> genericsChar = new Generics<char>('a');
            Generics<bool> genericsBool = new Generics<bool>(true);
            Generics<float> genericsFloat = new Generics<float>(1.2f);
            Generics<long> genericsLong = new Generics<long>(5);
            generics.GenericMethod(9);
            genericsString.GenericMethod("singh");
            genericsDouble.GenericMethod (1.46);
            genericsChar.GenericMethod('s');
            genericsBool.GenericMethod (false);
            genericsFloat.GenericMethod(3.4f);
            genericsLong.GenericMethod(7);
            GenericMethod obj = new GenericMethod();
            obj.Generic<int>(30);
            obj.Generic<string>("SINGH");

        }
    }
}
