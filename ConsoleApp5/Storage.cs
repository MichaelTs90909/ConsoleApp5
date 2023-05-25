using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        #region PrivateFields
        protected double _capacity;
        protected double _freeMemory;
        protected double _usedMemory;
        #endregion
        #region Methods
        public virtual double GetCapacity() => _capacity;
        public virtual bool Write(double data)
        {
            if (data <= _freeMemory)
            {
                _freeMemory -= data;
                _usedMemory += data;
                return true;
            }
            return false;
        }
        public virtual double GetFreeMemory() => _freeMemory;
        public abstract string GetInfo();
        #endregion
        public Storage(string name, string model, double capacity)
        {
            Name = name;
            Model = model;
            _capacity = capacity <= 0 ? 8 : capacity;
            _freeMemory = capacity;
            _usedMemory = 0;
        }
    }
}
