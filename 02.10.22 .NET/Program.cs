using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._10._22.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] city = { "Arizona", "Michigan ", "New York", "Arizona", "Nebraska" };
            Console.WriteLine("Масив всіх міст");
            Console.WriteLine("{0}", string.Join("\n", city));


            Console.WriteLine("Міста які починаються на А");
            var selectedCity = from c in city
                                 where c.ToUpper().StartsWith("A")
                                 
                               orderby c  
                                 select c;


            foreach (string citys in selectedCity)
                Console.WriteLine(citys);
            var selectedCitys = from c in city
                               where c.ToUpper().StartsWith("M")

                               orderby c
                               select c;


            foreach (string citys in selectedCitys)
                Console.WriteLine(citys);
            var selectedCiti = from c in city
                               where c.ToUpper().StartsWith("N")

                               orderby c
                               select c;


            foreach (string citys in selectedCiti)
                Console.WriteLine(citys);

        }
    }
}
