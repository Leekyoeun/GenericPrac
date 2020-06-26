using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrac
{
    class Wanted<T>
    {
        public T value;
        public Wanted(T value)
        {
            this.value = value;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> WantedString = new Wanted<string>("루피");
            Wanted<int> wantedInt = new Wanted<int>(100);
            Wanted<double> wanteddouble = new Wanted<double>(3.141592);
            Console.WriteLine(WantedString.value);
            Console.WriteLine(wantedInt.value);
            Console.WriteLine(wanteddouble.value);
        }
    }
}
