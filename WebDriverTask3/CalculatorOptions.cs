using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTask3
{
    public class CalculatorOptions
    {
        public int NumberOfInstances { get; set; }
        public string OperatingSystem { get; set; }
        public string ProvisioningModel { get; set; }
        public string MachineFamily { get; set; }
        public string Series { get; set; }
        public string MachineType { get; set; }
        public string GpuType { get; set; }
        public int NumberOfGpus { get; set; }
        public string LocalSsd { get; set; }
        public string Location { get; set; }
    }
}
