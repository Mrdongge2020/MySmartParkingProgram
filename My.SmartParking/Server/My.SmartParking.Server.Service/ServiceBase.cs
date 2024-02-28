using My.SmartParking.Server.IService;
using My.SmartParking.Server.IEFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace My.SmartParking.Server.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceBase: IServiceBase
    {
        protected DbContext _dbContext;
        public ServiceBase(IEFContext.IEFContext eFContext) 
        {
            _dbContext = eFContext.CreateDBContext();
        }

        public void Commit()
        {
            this._dbContext.SaveChanges(); 
        }

        public void Delete<T>(int id) where T : class
        {
            T t = this.Find<T>(id);
            if (t==null) 
            {
                throw new Exception("t is null");
            }
            this._dbContext.Set<T>().Remove(t);
            this.Commit();
        }

        public void Delete<T>(T t) where T : class
        {
            if (t == null)
            {
                throw new Exception("t is null");
            }
            this._dbContext.Set<T>().Attach(t);
            this._dbContext.Set<T>().Remove(t);
            this.Commit();
        }

        public void Delete<T>(IEnumerable<T> tList) where T : class
        {
            foreach (var t in tList)
            {
                this._dbContext.Set<T>().Attach(t);
            }
            this._dbContext.Set<T>().RemoveRange(tList);
            this.Commit();
        }

        public T Find<T>(int id) where T : class
        {
            return this._dbContext.Set<T>().Find(id);
        }

        public T Insert<T>(T t) where T : class
        {
            this._dbContext.Set<T>().Add(t);
            this.Commit();
            return t;
        }

        public IEnumerable<T> Insert<T>(IEnumerable<T> tList) where T : class
        {
            this._dbContext.Set<T>().AddRange(tList);
            this.Commit();
            return tList;
        }

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> funWhere) where T : class
        {
            return this._dbContext.Set<T>().Where<T>(funWhere);
        }

        public void Update<T>(T t) where T : class
        {
            if (t == null)
            {
                throw new Exception("t is null");
            }
            this._dbContext.Set<T>().Attach(t);
            this._dbContext.Entry<T>(t).State = EntityState.Modified;
            this.Commit();
        }

        public void Update<T>(IEnumerable<T> tList) where T : class
        {
            foreach (var t in tList)
            {
                this._dbContext.Set<T>().Attach(t);
                this._dbContext.Entry<T>(t).State = EntityState.Modified;
            }           
            this.Commit();
        }
        public virtual void Dispose() 
        {
            if (this._dbContext!=null)
            {
                this._dbContext.Dispose();
            }
        }
    }

   
}
