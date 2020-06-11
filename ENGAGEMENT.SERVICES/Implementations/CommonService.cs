using AutoMapper;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.SERVICES.Implementations
{
    public class CommonService<T> : ICommonService<T> where T : class
    {
        private IRepository<T> _repository;
        public CommonService(IRepository<T> repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
           
        }

        public void Delete(object id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public T Insert(T obj)
        {
            _repository.Insert(obj);
            return obj;
        }

        public void Save()
        {
            _repository.Save();
        }

        public T Update(T obj)
        {
            _repository.Update(obj);
            return obj;
        }
    }
}
