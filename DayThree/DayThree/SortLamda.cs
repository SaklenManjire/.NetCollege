using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
    internal class SortLamda
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 3, 4, 89, 1 };


            //Ascending
            numbers.Sort((a,b)=>a.CompareTo(b));
            Console.WriteLine("Ascending");
            Console.WriteLine(string.Join(",",numbers));

           //Descending
           numbers.Sort((a,b)=>b.CompareTo(a));
           Console.WriteLine("Descending");
           Console.WriteLine(string.Join(",",numbers));
        }

    }
}
