using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyRecordingSystemOOP.entities.abstracts
{
    public abstract class BaseMachine
    {
        public string Name { get; set; }
        public string Description { get; set; } 

        public DateTime ProductionDate { get; set; }

        public Guid SerialNumber { get; set; }

        public string OperatingSystem { get; set; }

        public BaseMachine() 
        {
            ProductionDate = DateTime.Now;
            Console.WriteLine("BaseMachine constructor çalıştı. Üretim tarihi atandı.");
        }

        public virtual void InfoPrint() 
        {

            Console.WriteLine($"[Uretim Tarihi] : {ProductionDate} , \n[Seri Numarasi] : {SerialNumber} , \n[Ad] : {Name} , \n[Acıklama] : {Description} , \n[Isletim Sistemi] : {OperatingSystem}");
           

        
        }

        public abstract void GetProductName(); 
        




    }
}
