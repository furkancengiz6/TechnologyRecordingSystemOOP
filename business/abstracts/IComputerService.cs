using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyRecordingSystemOOP.entities.concretes;

namespace TechnologyRecordingSystemOOP.business.abstracts
{
    public interface IComputerService
    {

        void SetUsbInputs(Computer computer, int usbCount);


    }
}
