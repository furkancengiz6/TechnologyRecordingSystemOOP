using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyRecordingSystemOOP.business.abstracts;
using TechnologyRecordingSystemOOP.entities.concretes;

namespace TechnologyRecordingSystemOOP.business.concretes
{
    public class ComputerService : IComputerService
    {
        public void SetUsbInputs(Computer computer, int usbCount)
        {
            if(usbCount == 2 || usbCount == 4)
            {
                computer.NumberOfUsbInputs = usbCount;
            }
            else
            {
                Console.WriteLine("USB giriş sayısı yalnızca 2 veya 4 olabilir. Varsayılan olarak -1 atanıyor.");
                computer.NumberOfUsbInputs = -1;
            }
        }
    }
}
