using System;
using BookMe.BLL.Interface;
using BookMe.DAL;

namespace BookMe.BLL
{
  public class UserService : IUserService<User>
  {
    public int Create(User entity)
    {
      throw new NotImplementedException();
    }

    public void Update(User entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(User entity)
    {
      throw new NotImplementedException();
    }

    public User Find(int id)
    {
      throw new NotImplementedException();
    }

    public User[] FindAll()
    {
      throw new NotImplementedException();
    }
  }
}
