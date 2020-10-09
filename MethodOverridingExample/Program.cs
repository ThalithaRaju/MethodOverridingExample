using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample
{ 
    
    class One
    {
       
        public virtual int Sum ( int a, int b)
            {
            return( a + b);
            }
    }

    internal class  Two: One
    {
        public override int Sum(int a, int b)
        {
             return (a + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            One obj = new One();
            Console.WriteLine("Sum of two Numbers=" + obj.Sum(3, 4));
            obj = new Two();
            Console.WriteLine("Second sum of two numbers=" + obj.Sum(5,10));
            Console.ReadKey();  
        }
    }
    }

