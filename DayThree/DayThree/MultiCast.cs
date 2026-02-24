using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{

    public delegate void Mydel(string msg);

    public class MultiCast
    {
   
        static void MethodA(string msg)
        {
            Console.WriteLine("Method A:"+msg); 
        }

        static void MethodB(string msg)
        {
            Console.WriteLine("Method B:" + msg);
        }

        static void MethodD(string msg)
        {
            Console.WriteLine("Method D:" + msg);
        }

  


        //static void Main(string[] args)
        //{

        //    Mydel del = MethodA;

        //    del += MethodB;
        //    del += MethodD;

        //    del("Hello");
        //}
    

    }
}
