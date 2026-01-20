using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Person
    {
        //get set method
        /*  public string Name
          {
              get { return Name; }
              set { Name = value; }
          }*/

        //short method
        public string Name { get; set; }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}
