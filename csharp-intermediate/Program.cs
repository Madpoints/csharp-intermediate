using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intermediate
{

    partial class Program
    { 
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1985, 12, 31));

            Console.WriteLine(person.Age);
        }
    }
}
