using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENGAGEMENT.DATA
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private REG_FSS_DB _context = null;
        private DbSet<T> table = null;

        public Repository()
        {
            this._context = new REG_FSS_DB();
            this.table = _context.Set<T>();
        }

        public Repository(REG_FSS_DB context)
        {
            _context = context;
            this.table = _context.Set<T>();
        }

        public void Delete(object id)
        {
            if (id == null) throw new ArgumentNullException("entity");
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            if (id == null) throw new ArgumentNullException("entity");
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            if (obj == null) throw new ArgumentNullException("entity");
            table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            if (obj == null) throw new ArgumentNullException("entity");
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        
    }
}
