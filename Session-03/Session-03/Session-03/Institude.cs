using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institude
    {
        public Guid ID { get; }

        public string Name { get; set; }

        public int ServiceYears { get; set; }

        public Institude()
        {
            ID = Guid.NewGuid();
        }

        public string GetName()
        {
            return Name;
        }

    }
}

