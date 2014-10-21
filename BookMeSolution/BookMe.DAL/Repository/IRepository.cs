﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace BookMe.DAL.Repository
{
  public interface IRepository<T>
  {
    T[] FindAll();
    T Single(Expression<Func<T, bool>> predicate);
    T[] Find(Expression<Func<T, bool>> predicate);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
  }
}
