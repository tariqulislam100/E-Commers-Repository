using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Models
{
    public class VehicleType : BaseVehicleEntity
    {
        public VehicleType()
        {
        }

        public VehicleType(int id, string name) : base(id)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
