using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nybble_zadatak
{
    class Device
    {
        public string id { get; set; }
        public int status { get; set; }
        public List<Sensor> sensors { get; set; }
        public string timestamp { get; set; }

        public Device()
        {
            sensors = new List<Sensor>();
        }
    }
}
