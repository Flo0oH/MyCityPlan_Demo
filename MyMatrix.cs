using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;

namespace MyCityPlan_Demo
{
    internal class MyMatrix
    {
        private bool console;

        public MyMatrix()
        {
            string[,,] lagerstore = new string[,,] { { { "one", "two" }, { "three", "four" }, { "five", "six" } }, { { "eight", "nine" }, { "ten", "eleven" }, { "twelf", "thierdthen" } },{ { "fourthen", "fifthen" }, { "sixthen", "seventhen" }, { "eightthen", "ninethen" } } } ;
            foreach (var item in lagerstore)
            {
                console += ("Lagerstore: " +item.ToString());
            }
            Console.WriteLine(console); //Ausgabe
        }

        internal void start()
        {
            throw new NotImplementedException();
        }
    }
}