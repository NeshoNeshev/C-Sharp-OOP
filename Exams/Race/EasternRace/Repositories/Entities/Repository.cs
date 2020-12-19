
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class Repository<T>:IRepository<T>
    {
        private ICollection<T> models;

        public Repository()
        {
            this.models = new List<T>();
        }
        public T GetByName(string name)
        {
            T entity = this.models.FirstOrDefault(m => nameof(m) == name);
            return entity;
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return this.models.ToList().AsReadOnly();
        }

        public void Add(T model)
        {
            this.models.Add(model);
        }

        public bool Remove(T model)
        {
          return  this.models.Remove(model);
        }
    }
}
