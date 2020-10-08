using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample
{
    class BaseClass
        {
        public  virtual void  Show()
        {
            Console.WriteLine("Base class");
        }

        }
    class Derived:BaseClass
    {
        public override  void Show()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj;
            obj = new BaseClass();
            obj.Show();
            obj = new Derived();
            obj.Show();
            //BaseClass obj = new BaseClass();
            //obj.Show();
            //BaseClass obj = new Derived();
            Console.ReadKey();
        }
    }
}
