using _1278941.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseVehicleEntity
    {
        private readonly IList<T> vehicles;
        public GenericRepository() 
        { 
            this.vehicles = new List<T>();
        }

        public List<T> GetAll()
        {
            return this.vehicles.ToList();
        }

        public T Get(int id)
        {
            return this.vehicles.FirstOrDefault(x => x.Id == id);
        }

        public void Add(T entity)
        {
           this.vehicles.Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                this.vehicles.Add(entity);
            }
        }


        public void Update(T entity)
        {
           int i = this.vehicles.IndexOf(entity);
            this.vehicles.RemoveAt(i);
            this.vehicles.Add(entity);
        }
        public void Delete(int id)
        {
           var entity= this.vehicles.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                this.vehicles.Remove(entity);
            }
        }
    }
}
