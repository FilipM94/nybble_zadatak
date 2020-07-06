using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nybble_zadatak
{
    class Sensor
    {
        public int id { get; set; }
        public string desc { get; set; }
        public string value { get; set; }

        public Sensor() { }
        public Sensor(int id, string dest, string value)
        {
            this.id = id;
            this.desc = desc;
            this.value = value;
        }
    }
}
