using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyRecordingSystemOOP.entities.abstracts;

namespace TechnologyRecordingSystemOOP.entities.concretes
{
    public class Phone : BaseMachine
    {

        public string TrLisans { get; set; }

        public override void GetProductName()
        {
            Console.WriteLine($"Telefon Adı --->{Name}");
        }
    }
}
