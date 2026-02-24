using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//single casr
namespace DayThree
{
    public delegate void Mydele(string msg);

    public class SingleCast
    {
        static void MethodA(string msg)
        {
            Console.WriteLine("Method A:"+msg);
        }

        static void MethodB(string msg)
        {
            Console.WriteLine("Method B:"+msg);
        }

        //static void Main(string[] args)
        //{
        //    Mydele del = MethodA;

        //    del("Hello");

        //    del= MethodB;

        //    del("Bye");
        //}

    }
   
   }
