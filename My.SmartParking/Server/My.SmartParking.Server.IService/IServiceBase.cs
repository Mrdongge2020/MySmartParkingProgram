using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace My.SmartParking.Server.IService
{
    public interface IServiceBase
    {
        /// <summary>
        /// 根据id查询实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T Find<T> (int id) where T : class;

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="funWhere"></param>
        /// <returns></returns>
        IQueryable<T> Query<T> (Expression<Func<T,bool>>  funWhere) where T:class;

        /// <summary>
        /// 新增数据，即时commit
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        T Insert<T>(T t) where T : class;

        /// <summary>
        /// 新增数据，即时commit 多条sql 一个连接，事务插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tList"></param>
        /// <returns></returns>
        IEnumerable<T> Insert<T>(IEnumerable<T> tList) where T : class;

        /// <summary>
        /// 更新数据 ，即时commit
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        void Update<T> (T t) where T : class;
        /// <summary>
        /// 多条更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tList"></param>
        void Update<T>(IEnumerable<T> tList) where T : class;
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        void Delete<T> (int id) where  T:class;
        /// <summary>
        /// 删除数据，即时commit
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        void Delete<T> (T t)where T : class;
        /// <summary>
        /// 删除数据，即时commit
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tList"></param>
        void Delete<T>(IEnumerable<T> tList) where T : class;

        /// <summary>
        /// 立即保存全部修改
        /// </summary>
        void Commit();
    }
}
