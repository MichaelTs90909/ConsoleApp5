using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class HDD : Storage
    {
        public double Speed { get; private set; }
        public int Sectors { get; private set; }
        public override string GetInfo() => $"Name: {Name}\nModel: {Model}\nCapacity: {_capacity}\nFree memory: {_freeMemory}\nUsed memory: {_usedMemory}\nSpeed: {Speed}\nSectors: {Sectors}";
        public HDD(string name, string model, double capacity, double speed, int sectors) : base(name, model, capacity)
        {
            Speed = speed < 2 ? 2 : speed;
            Sectors = sectors > 0? sectors:100;
        }
    }
}
