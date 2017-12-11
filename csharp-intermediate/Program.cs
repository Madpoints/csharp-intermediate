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
            var cookie = new HttpCookie();
            cookie["name"] = "John";
            Console.WriteLine(cookie["name"]);
        }
    }
}
