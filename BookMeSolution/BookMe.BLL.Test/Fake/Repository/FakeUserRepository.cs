
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookMe.DAL;
using BookMe.DAL.Repository;

namespace BookMe.BLL.Test.Fake.Repository
{
  public class FakeUserRepository:IRepository<User>
  {
    private readonly IQueryable<User> _users = new List<User>()
      {
        new User() {FirstName = "francis", LastName = "tchatchoua", Password = "123456", UserName = "admin"},
        new User() {FirstName = "tamo", LastName = "gaspar", Password = "123456", UserName = "patdiamant"},
        new User() {FirstName = "lion", LastName = "domou", Password = "123456", UserName = "didiversace"},
        new User() {FirstName = "franck", LastName = "capi", Password = "123456", UserName = "catlife"},

      }.AsQueryable();

    public User[] FindAll()
    {
      return _users.ToArray();
    }

    public User Single(Expression<Func<User, bool>> predicate)
    {
      return _users.SingleOrDefault(predicate);
    }

    public User[] Find(Expression<Func<User, bool>> predicate)
    {
      return _users.Where(predicate).ToArray();
    }

    public void Add(User entity)
    {
      _users.ToList().Add(entity);
    }

    public void Update(User entity)
    {
      var user = _users.ToList().SingleOrDefault(u => u.UserName == entity.UserName);

      if (user!=null)
      {
        _users.ToList().Remove(user);
      }

      _users.ToList().Add(entity);
     
    }

    public void Delete(User entity)
    {
      var user = _users.ToList().SingleOrDefault(u => u.UserName == entity.UserName);

      if (user != null)
      {
        _users.ToList().Remove(user);
      }
    }
  }
}
