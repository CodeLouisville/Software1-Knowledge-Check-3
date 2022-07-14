using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck3_Refactoring
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string ENGINE { get; set; }
        public string Model_name { get; set; }

        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model_name}, Color: {Color}, Engine: {ENGINE}";
        }
    }
}
