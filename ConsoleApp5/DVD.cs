using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DVD : Storage
    {
        public double Speed {get; private set;}
        public override string GetInfo() => $"Name: {Name}\nModel: {Model}\nCapacity: {_capacity}\nFree memory: {_freeMemory}\nUsed memory: {_usedMemory}\nSpeed: {Speed}";
        public DVD(string name, string model, double capacity, double speed) : base(name, model, capacity)
        {

        }
    }
}
