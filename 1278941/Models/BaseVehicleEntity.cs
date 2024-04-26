using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Models
{
    public abstract class BaseVehicleEntity
    {
        public BaseVehicleEntity() { }
        public BaseVehicleEntity(int id)
        {
            this.Id = id;
        }

           public int Id { get; set; }
    }
}
