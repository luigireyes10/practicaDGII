﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IgenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();

        IEnumerable<T> Find( Expression<Func<T , bool>> expression);

        void Add(T entity);

        void Update(T entity);
        void Remove(T entity);  



    }
}
