// <copyright file="IRepository.cs" company="Tiqri Ltd">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Deepakumar</author>
// <date>28/09/2017</date>
// <summary></summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Interface
{
    public interface IRepository<T> where T : EntityBase
    {
        /// <summary> 
        /// Load the proxy object for given Type 
        /// </summary> 
        /// <param name="whereCondition"></param> 
        /// <returns></returns> 
        T GetProxy(Expression<Func<T, bool>> whereCondition);

        /// <summary> 
        /// Get the given type with collections,related object  
        /// </summary> 
        /// <param name="whereCondition"></param> 
        /// <returns></returns> 
        T GetSingle(Expression<Func<T, bool>> whereCondition);

        /// <summary> 
        /// Get Collection of type for given expression 
        /// </summary> 
        /// <example> 
        /// Usage: _repository.GetAll(t=>t.id==10); 
        /// </example> 
        /// <param name="whereCondition"></param> 
        /// <returns></returns> 
        IList<T> GetAll(Expression<Func<T, bool>> whereCondition);

        /// <summary> 
        /// Get collection of All objects in the underlining database. 
        /// </summary> 
        /// <returns></returns> 
        IList<T> GetAll();

        /// <summary> 
        /// Returns a Query that supports for quering the collections 
        /// </summary> 
        /// <returns></returns> 
        IQueryable<T> GetQueryable();

        /// <summary> 
        /// Provide funtionality to Update/Edit/Delete given type/collections. 
        /// </summary> 
        /// <param name="entity"></param> 
        int Save(T entity);

        /// <summary> 
        /// Provide Function to delete entity based on id 
        /// </summary> 
        /// <param name="id"></param> 
        /// <returns></returns> 
        void Delete(int id);
    }
}
