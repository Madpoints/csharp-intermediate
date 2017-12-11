using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intermediate
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    partial class Program
    { 
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1985, 12, 31));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
