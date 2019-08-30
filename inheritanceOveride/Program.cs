using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceOveride
{

    public class CityBaseClass
    {

        public virtual void SayHello()
        {
            Console.Write("Hello World");
        }

        
    }

    public class CityDerivedClass : CityBaseClass
    {
        public override void SayHello()
        {
            Console.Write("Hello Everybody!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cityBaseInstance = new CityBaseClass();
            cityBaseInstance.SayHello();

            var cityOverideInstance = new CityDerivedClass();
            cityOverideInstance.SayHello();

            Console.ReadLine();
        }
    }
}
