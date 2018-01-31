using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    // private public 
    public class Car
    {
        public bool IsRepaired { get; set; }
        public bool HasAllWheels { get; set; }

        private bool _someVariable = true;

        public Car()
        {
            
        }

        public Car(string owner)
        {
            Owner = owner;
        }

        public Car(string owner, int value)
        {
            
        }

        public string Owner { get; set; }

        public void Repair(bool dupa)
        {
            _someVariable = dupa;
            IsRepaired = true;
            HasAllWheels = true;
        }
    }
}
