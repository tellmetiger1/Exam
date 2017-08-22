using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldLib;

namespace HelloWorldMain
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldFactory factory = new HelloWorldFactory();
            // create hellowWorld obj
            IHelloWorld helloWorldObj = factory.CreateHelloWorldObj();

            // call any of the implemented function to output "Hello World" to either console or database or other places
            helloWorldObj.PrintHelloWorldToConsole("Hello World");
        }
    }
}
