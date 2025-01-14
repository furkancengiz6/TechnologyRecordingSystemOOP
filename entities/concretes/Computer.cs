using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TechnologyRecordingSystemOOP.entities.abstracts;

namespace TechnologyRecordingSystemOOP.entities.concretes
{
    public class Computer : BaseMachine
    {

        public int NumberOfUsbInputs { get; set; }

        public bool BluetoothEnabled { get; set; }

        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayar Adı --->{Name}");
        }







    }
}
